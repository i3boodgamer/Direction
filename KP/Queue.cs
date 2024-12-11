using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KP
{
    public class Queue
    {
        private int _ID;
        private Queue<Student> _Queue = new Queue<Student>(); // Списко студентов, находящийся в очереди
        private ListBox _LB;
        private string _Name;
        
        public Queue(int ID, ListBox LB)
        {
            _ID = ID;
            _LB = LB;
            _Name = "Очередь " + _ID+ " -";

            switch (_ID)
            {
                case 1:
                    _Name += " получение допуска к сессии ";
                    break;
                case 2:
                    _Name += " получение бегунка  ";
                    break;
                case 3:
                    _Name += " получение квинтации на оплату ";
                    break;
                case 4:
                    _Name += " возрата бегунка с оценкой ";
                    break;
                case 5:
                    _Name += " закрытия сессии ";
                    break;
            }
        }

        public Queue():this(1,  null) { }

        public override string ToString()
        {
            return _Name;
        }

        public int QueueCount
        {
            get { return _Queue.Count; }
        }

        public int ID
        {
            get { return _ID; }
            set
            {
                if (value >= 1 || value <= 5)
                {
                    _ID = value;
                }
                else
                {
                    _ID = 1;
                }
            }
        }

        // Событие "Первый в очереди"
        public event EventHandler<OnlyPrintArgs> SingleStudentEvent;
        
        private void OnSingleStudent(CalcBack PrintResult)
        {
            // Событие генерируется, если студент первый в очереди
            if(SingleStudentEvent != null && _Queue.Count == 1)
            {
                OnlyPrintArgs E = new OnlyPrintArgs(); // Создание параметров события
                E.PrintResult = PrintResult;
                SingleStudentEvent(this, E); // Генерация события
            }
        }

        // Обработка события "Новый студент"
        public void NewStudent(object s, StudentArgs e)
        {
           // Студент должен существовать и должен заходить в нужную очередь
           if (e.Student != null && e.Student.Requirement == 1)
           {
                _Queue.Enqueue(e.Student);
                if (_LB != null)
                    _LB.Items.Add(e.Student);

                if (e.PrintResult != null)
                    e.PrintResult(this + ". Добавлен " + e.Student);

                e.Student = null;

                OnSingleStudent(e.PrintResult);
           }
        }

        // Обработка события "Дирекция свободна"
        public void SetDirection(object s, DirectionArgs e)
        {
            if(_Queue.Count > 0 && e.isFree)
            {
                StudentArgs E = new StudentArgs();

                E.Student = _Queue.Dequeue();
                _LB.Items.Remove(E.Student);
               
                if (e.PrintResult != null)
                    e.PrintResult(this + ". Ушел " + E.Student);

                E.PrintResult = e.PrintResult;
                e.isFree = e.SetDirection(E);
            }
        }

        // Обработка события "Окончание приёма"
        public void SetQueueRun(StudentArgs E, List<Queue> Q)
        {
            if (E.Student != null && Q != null && E.Student.Requirement == _ID)
            {
                // Добавление студента в очередь
                _Queue.Enqueue(E.Student);
                // Отображение в визуальном компоненте
                if (_LB != null)
                    _LB.Items.Add(E.Student);
   
                if (E.PrintResult != null)
                    E.PrintResult(this + ". Добавлен " + E.Student);

                E.Student = null;

                // Возможная активация события "Первый в очереди"
                // Т.к задачи подразумевает преоритеты, нужно рассматривать наличие студентов в очередях,
                // которые должны быть приняты первые
                if (Q.ElementAt(1).QueueCount > 0)
                    OnSingleStudent(E.PrintResult);
                else if(Q.ElementAt(2).QueueCount > 0)
                    OnSingleStudent(E.PrintResult);
                else if (Q.ElementAt(3).QueueCount > 0)
                    OnSingleStudent(E.PrintResult);
                else if (Q.ElementAt(4).QueueCount > 0)
                    OnSingleStudent(E.PrintResult);
            }
        }


    }
}
