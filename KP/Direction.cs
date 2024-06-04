using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public class Direction
    {
        /*Статический счетчик, который при созданиин нового экземпляра класса, увеличивается на 1 и присваивается _ID*/
        private static int Counter; 
        private int _ID;
        private TextBox _TB; // Визуальный компонент Direction_TB
        private StudentArgs _Current; // Текущий Студент
        private string _Name; // Название для созданной диреции

        public Direction(TextBox TB)
        {
            _ID = ++Counter;
            _Name = "Дирекция " + _ID;
            _TB = TB;
            if (_TB != null) { TB.Clear(); }
        }

        // Значения поумолчанию, при создании котсруктора без параметров 
        public Direction(): this(null) { }

        public int ID
        {
            get { return _ID; }
        }

        // Выходящие название класса
        public override string ToString()
        {
            return _Name;
        }

        private bool SetStudent(StudentArgs E)
        {
            // Проверка, что полученный студент существует
            if (E.Student != null) 
            {
                // Проверка, что предыдущий студент ушел.
                // Анулируется в методе Step()
                if (_Current == null)
                {
                    //Запоминаем студента и записываем, что он в дирецию зашел
                    _Current = E;
                    if (_TB != null)
                    {
                        // Записывает в визуальный компонент, что он в дирецию зашел
                        _TB.Text = E.Student.ToString() + " -";
                        switch (E.Student.Requirement)
                        {
                            case 1:
                                _TB.Text += " получение допуска к сессии ";
                                break;
                            case 2:
                                _TB.Text += " получение бегунка  ";
                                break;
                            case 3:
                                _TB.Text += " получение квинтации на оплату ";
                                break;
                            case 4:
                                _TB.Text += " возрата бегунка с оценкой ";
                                break;
                            case 5:
                                _TB.Text += " закрытия сессии ";
                                break;
                        }

                    }

                    // Записывает в Info_TB информацию о совершенном действии
                    if (E.PrintResult != null)
                        E.PrintResult(this + ". Зашел в дирекция - " + E.Student);



                }
                // Если в Step() не анулирован, т.е текущий пациент не ушел
                else
                {
                    if (E.PrintResult != null)
                        E.PrintResult(this + ":" + E.Student + " не смог войти в дирекцию, т.к она занята"); 
                }
            }
            // False - если пациент в дирекции, True - если диреция свободна
            return _Current == null;
        }

        // Событие "Дирекция свободна"
        public event EventHandler<DirectionArgs> isFreeEvent;

        // Активация события "Дирекция свободна"
        private void onIsFree(CalcBack PrintResult)
        {
            if (isFreeEvent != null && _Current == null)
            {
                // Создание класса параметров события
                DirectionArgs E = new DirectionArgs();
                // Ретрансляция метода вывода описания выполненного действия
                E.PrintResult = PrintResult;
                // Указание метод размещения нового студента
                E.SetDirection = SetStudent;

                E.isFree = true;
                isFreeEvent(this, E);
            }
        }
        // Событие "окончание приема"
        public event Finished isFinish;
        
        // Обработчик события "шаг"
        public void Step(object s, LogArgs e)
        {
            if(_Current != null)
            {
                //Проверяется, что студент находится в диреции
                if (_Current.Student != null)
                {
                    //Отображение в визуальном компоненте
                    if (e.PrintResult != null)
                        e.PrintResult(this + ". " + _Current.Student + ". Зашел с очереди - " + _Current.Student.Requirement);

                    // Результат работы дирекции записывается в отчет
                    if (e.PringLog != null)
                        e.PringLog(new LogItem(_Current.Student.Requirement, _Current.Student.ID));
                    
                    //Нахождение в дирекции минуту
                    _Current.Student.Time++;


                    //Проверка на время нахождения
                    if (_Current.Student.Time == 1)
                    {
                        //Чистим предыдущий результат
                        if (_TB != null)
                            _TB.Clear();

                        //Отображение в визуальном компоненте
                        if (e.PrintResult != null)
                            e.PrintResult(this + ". Покинул дирекцию - " + _Current.Student);


                        //Проверка, что студент закрыл сессию
                        if (_Current.Student.Requirement == 5)
                            e.PrintResult(this + ". Закрыл сессию  - " + _Current.Student);

                        Student st = _Current.Student;
                        if (isFinish != null && st.Requirement!=5)
                        {
                            if (st.Requirement == 1)
                            {
                                st.Requirement = 4;
                            }
                            else if (st.Requirement == 4)
                            {
                                int[] numbers = { 3, 5 };
                                int index = new Random().Next(numbers.Length);
                                int randomNumber = numbers[index];

                                st.Requirement = randomNumber;
                            }
                            else if (st.Requirement == 3)
                            {
                                st.Requirement = 2;

                            }
                            else if (st.Requirement == 2)
                            {
                                st.Requirement = 4;
                            }
                            isFinish(_Current, e.Queues); // Отправляем студента в следующею очередь
                        }

                        //Анулируемя время провождения в дирекции
                        st.Time = 0;

                        // Студент ушел из диреции
                        _Current = null;

                        // Создание события "Дирекция свободна"
                        onIsFree(e.PrintResult);
                    }
                }
            }
        }


        // Обработка события "Первый студент"
        public void WaiteSingle(object s, OnlyPrintArgs e)
        {
            // Дает знак о том, что дирекция готова принимать
            onIsFree(e.PrintResult);
        }
    }
}
