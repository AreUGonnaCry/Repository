using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Circle : Base
    {
        public double Radius { get; set; } //радиус круга

        public Circle(double area, string color, double radius)
        {
            Area = area;
            Color = color;
            Radius = radius;
        }

        public override void GetInfo() // Настройка вывода результатов в консоль.
        {
            Console.WriteLine("Figure: Circle; Area: " + Area + "; Radius: " + Radius + "; Color: " + Color + ";");
        }
    }
}
