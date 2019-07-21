using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Trapeze : Base
    {
        public double Middle { get; set; } //средняя линия трапеции 

        public Trapeze(double area, string color, double middle)
        {
            Area = area;
            Color = color;
            Middle = middle;
        }

        public override void GetInfo() // Настройка вывода результатов в консоль.
        {
            Console.WriteLine("Figure: Trapeze; Area: " + Area + "; Middle: " + Middle + "; Color: " + Color + ";");
        }
    }
}
