using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_СамРабота._Структуры
{
    struct LinearEquation
    {
        public double k;
        public double b;

        public double Root()
        {
            return -b / k;
        }
    }
}   