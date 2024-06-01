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
        private static int Counter;
        private int _ID;
        private Queue<Student> _Queue = new Queue<Student>(); // Списко студентов, находящийся в очереди
        private ListBox _LB;
        private int _Requirement;
        private string _Name;
        
        public Queue(int Requirement, ListBox LB)
        {
            _ID = ++Counter;
            _LB = LB;
            _Requirement = Requirement;
            _Name = "Очередь " + _ID + " -";

            switch (_Requirement)
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

        public int QueueNumber
        {
            get { return _ID; }
        }

        public int Requirement
        {
            get { return _Requirement; }
            set
            {
                if (value >= 1 || value <= 5)
                {
                    _Requirement = value;
                }
                else
                {
                    _Requirement = 1;
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
           if (e.Student != null && e.Student.Requirement == Requirement)
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
            if(E.Student != null && Q != null)
            {
                if (E.Student.Requirement == 1)
                {
                    E.Student.Requirement = 4;
                }
                else if (E.Student.Requirement == 4)
                {
                    int[] numbers = { 3, 5 };
                    int index = new Random().Next(numbers.Length);
                    int randomNumber = numbers[index];

                    E.Student.Requirement = randomNumber;
                }
                else if (E.Student.Requirement == 3)
                {
                    E.Student.Requirement = 2;

                }
                else if (E.Student.Requirement == 2)
                {
                    E.Student.Requirement = 4;
                }
                Q.ElementAt(E.Student.Requirement-1).NewStudent(this, E);
            }
        }


    }
}
