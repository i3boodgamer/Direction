using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KP
{
     public class LogItem
    {
        private static int Counter;
        private int _ID;
        private int _StudentID;
        private int _RequirementNumber;
        private string _Name = "";

        public LogItem(int RequirementNumber, int StudentID)
        {
            if (RequirementNumber>0 && RequirementNumber <= 5)
            {
                _ID = ++Counter;
                _Name += _ID;
                _StudentID = StudentID;
                _RequirementNumber = RequirementNumber;
                switch (_RequirementNumber)
                {
                    case 1:
                        _Name += ". Потребуность: получение допуска к сессии ";
                        break;
                    case 2:
                        _Name += ". Потребуность: получение бегунка  ";
                        break;
                    case 3:
                        _Name += ". Потребуность: получение квинтации на оплату ";
                        break;
                    case 4:
                        _Name += ". Потребуность: возрата бегунка с оценкой ";
                        break;
                    case 5:
                        _Name += ". Потребуность: закрытия сессии ";
                        break;
                }
            }
            else
            {
                //Если параметры отчета не правильные
                throw new Exception(
                    "Параметры записи Log-файла заданы не правильно");
            }
        }
        public override string ToString()
        {

            return _Name + ". Студент: " + _StudentID;
                
            
        }

        public int ID
        {
            get { return _ID; }
        }

        public int StudentID
        {
            get { return _StudentID; }
        }

        public int RequirementNumber
        {
            get { return _RequirementNumber; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _RequirementNumber = value;
                }
            }
        }
        
    }
}
