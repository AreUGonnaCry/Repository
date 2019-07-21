using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Triangle : Base 
    {
        public double Hypotenuse { get; set; } //гипотенуза треугольника

        public Triangle(double area, string color, double hypotenuse)
        {
            Area = area;
            Color = color;
            Hypotenuse = hypotenuse;
        }

        public override void GetInfo() // Настройка вывода результатов в консоль.
        {
            Console.WriteLine($"Figure: Triangle; Area: {Area}; Hypotenuse: {Hypotenuse}; Color: {Color};");
        }
    }
}
