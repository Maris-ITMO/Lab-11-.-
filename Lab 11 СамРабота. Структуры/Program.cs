using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_СамРабота._Структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation eq = new LinearEquation { k = 2, b =  };
            double root = eq.Root();
            Console.WriteLine("Root: " + root);            
            Console.ReadKey();
        }
    }
}