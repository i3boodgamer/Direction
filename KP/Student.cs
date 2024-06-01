using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Markup;

namespace KP
{
    public class Student
    {
        private static int Counter;
        private int _ID;
        private int _Requirement;
        private string _Name;
        private int _Time; // Время проведенная дирекции

        public Student(int Requirement)
        {
            _ID = ++Counter;
            _Name = $"Cтудент {_ID}";
            _Requirement = Requirement;

        }

        public Student() : this(1) { }

        public override string ToString()
        {
            return _Name;
        }

        public int Requirement
        {
            get { return _Requirement; }
            set
            {
                if(value>=1 || value<= 5)
                {
                    _Requirement = value;
                }
                else
                {
                    _Requirement = 1;
                }
            }
        }

        public int Time
        {
            get
            {
                return _Time;
            }
            set
            {
                if (value >= 0)
                    _Time = value;
            }
        }
        
        public int ID
        {
            get { return _ID; }
        }

        
        
    }
}
