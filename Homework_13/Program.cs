using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Боровая, 7", 10, 4, 20);
            building.Print();
            Console.WriteLine();
            MultiBuilding building2 = new MultiBuilding("ул. Усилова, 5", 23.5, 10.1, 27.5, 9);
            building2.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        string address;
        double length;
        double width;
        double height;
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        public double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Длина не может быть отрицательной");
                }
            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Ширина не может быть отрицательной");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Высота не может быть отрицательной");
                }
            }
            get
            {
                return height;
            }
        }
        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Здание по адресу {0}", Address);
            Console.WriteLine("Длина здания: {0}м", Length);
            Console.WriteLine("Ширина здания: {0}м", Width);
            Console.WriteLine("Высота здания: {0}м", Height);
        }
    }
    sealed class MultiBuilding:Building
    {
        int ground;
        public int Ground
        {
            set
            {
                if (value > 0)
                {
                    ground = value;
                }
                else
                {
                    Console.WriteLine("Недопустимая этажность");
                }
            }
            get
            {
                return ground;
            }
        }
        public MultiBuilding (string address, double length, double width, double height, int ground)
            :base(address, length, width, height)
        {
            Ground = ground;
        }
        public void NewPrint()
        {
            base.Print();
            Console.WriteLine("Этажность здания: {0}", Ground);
        }
    }
}
