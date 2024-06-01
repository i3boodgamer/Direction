using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public class DirectionArgs : OnlyPrintArgs
    {
        public DirectionCalcBack SetDirection; // Поле указывающие, что диркция готова принимать
        // При свободной диреции очереди получает событие "Дирекция свободна"
        // Когда заходит студент, остальные очереди должны знать, что диреция занятя
        public bool isFree;
    }
}
