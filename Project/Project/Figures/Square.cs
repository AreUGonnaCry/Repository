using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Square : Base
    {
        public double Length { get; set; } //длинна стороны квадрата

        public Square(double area, string color, double length)
        {
            Area = area;
            Color = color;
            Length = length;
        }

        public override void GetInfo() // Настройка вывода результатов в консоль.
        {
            Console.WriteLine($"Figure: Square; Area: {Area}; Length: {Length}; Color: {Color};");
        }
    }
}
