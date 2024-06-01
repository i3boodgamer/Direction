using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    // Требуется для готовности дирекции принимать студентов
    public delegate bool DirectionCalcBack(StudentArgs e);
    // Требуется для информации о действиях
    public delegate void CalcBack(string s);
    // Требутеся для отчета
    public delegate void LogCalcBack(LogItem e);
    // Требуется для перехода с диреции в другую очереди 
    public delegate void Finished(StudentArgs e, List<Queue> q);
}
