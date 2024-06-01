using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public class Manager
    {
        private List<Queue> Queues = new List<Queue>(); // Список очередей
        private List<LogItem> LogList = new List<LogItem>(); // Список приемов

        private Random rnd = new Random(); // Генерация случайных чисел

        private TextBox _LogStudent_TB, _Start_TB; // Визуальные компоненты для совершенных действий и отчета соотвественно

        // Поля для генерации студентов
        private int _CountStudent = 1;
        private int _Chance = 2;

        public Manager(TextBox LogStudent_TB, TextBox Start_TB) // Констурктор класса 
        {
            _LogStudent_TB= LogStudent_TB;
            _Start_TB= Start_TB;
        }
        public Manager(): this(null, null) { } // Значения поумолчанию, при создании котсруктора без параметров 


        public int CountStudent
        {
            set { if (value >= 1 && value <= 3) _CountStudent = value; }
            
        }
        public int Chance
        {
            set { if (value >= 1 && value <= 5) _Chance = value; }
        }

        public event EventHandler<StudentArgs> NewStudent; // Событие "Новый студент"
        private void onNewStudent()
        {
            StudentArgs E = new StudentArgs();
            E.Student = new Student(1); // Создание нового студента
            E.PrintResult = PrintResult; 

            // Активация события "Новый студент"
            if (NewStudent!=null) 
                NewStudent(this, E);

            // Если студент существует, тогда ни одна очередь его не возьмет
            if (E.Student != null)
                PrintResult("Не найдена подходящая очередь. " + E.Student + " - " + "ушел");
        }
        

        private event EventHandler<LogArgs> RunTimeEvent; // Событие "Шаг"
        

 
        public void OnRunTime() // Активация события "Шаг"
        {
            if(RunTimeEvent != null)
            {
                LogArgs E = new LogArgs();
                E.PrintResult = PrintResult;
                E.PringLog = PrintLog;
                E.Queues = Queues;
                RunTimeEvent(this, E);

            }
        }

 
        private void PrintResult(string s) // Метод отображения выполненного действия
        {
            if(_LogStudent_TB != null)
            {
                _LogStudent_TB.AppendText(s + Environment.NewLine);
            }
        }

        private void PrintLog(LogItem Item) //Метод добавлние в "список приемов"
        {
            LogList.Add(Item);
        }

        public void OnTimer() // Метод генерации события "Шаг" и "Новый студент"
        {
            _LogStudent_TB.Clear();
            OnRunTime();

            if(rnd.Next(_Chance) == 0)
                for (int i = 1; i <= rnd.Next(_CountStudent) + 1; i++)
                    onNewStudent();
        }


        // Метод для создания отчета посещаемости дирекции
        public void SetReport()
        {
            _Start_TB.Clear();
            var studentReport =
            from log in LogList
            group log by log.RequirementNumber into reqGroup
            select new
            {
                RequirementNumber = reqGroup.Key,
                Students = from log in reqGroup
                           group log by log.StudentID into stuGroup
                           select new
                           {
                               StudentID = stuGroup.Key,
                               VisitCount = stuGroup.Count() // Группа "Кол-во посещямости дирекции"
                           }
                           into visitGroup
                           group visitGroup by visitGroup.VisitCount into visitCountGroup
                           select new
                           {
                               VisitCount = visitCountGroup.Key,
                               StudentCount = visitCountGroup.Count() // Кол-во людей в группе "Кол-во посещямости дирекции"
                           }
            };



            foreach (var requirement in studentReport)
            {
                _Start_TB.AppendText(($"Потребность {requirement.RequirementNumber}:") + Environment.NewLine);

                foreach (var visitGroup in requirement.Students)
                {
                    _Start_TB.AppendText($"  Количество посещений: {visitGroup.VisitCount}, Количество студентов: {visitGroup.StudentCount}" + Environment.NewLine);
                }
            }
        }

        
        public void AddQueue(Queue queue) // Метод добавление новой очереди
        {
            Queues.Add(queue);

            NewStudent += queue.NewStudent;
        }

        public void AddDirection(Direction direction) // Метод добавление новой диреции
        {
            RunTimeEvent += direction.Step;

            foreach (Queue queue in Queues)
            {
                queue.SingleStudentEvent += direction.WaiteSingle;
                direction.isFreeEvent += queue.SetDirection;
                direction.isFinish += queue.SetQueueRun;
            }
            
        }


    }


}
