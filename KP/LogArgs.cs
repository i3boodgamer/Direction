using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public  class LogArgs: OnlyPrintArgs
    {
        
        public LogCalcBack PringLog; // Поле, для отображение информации в визуальном компоненте отчета
        public List<Queue> Queues; // Поле, для определение следующей очереди, после выхода с диреции
    }
}
