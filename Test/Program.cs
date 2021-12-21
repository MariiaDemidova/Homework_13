using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "Боровая, 7";
            double length = 10.5;
            double width = 4.3;
            double height = 15.6;
            Console.WriteLine("Здание по адресу {0}", address + "Длина здания: {1}м", length + "Высота здания: {2}м", height + "Ширина здания: {3}м", width);
            Console.ReadKey();
        }
    }
}
