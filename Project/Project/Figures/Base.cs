using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public abstract class Base
    {
        // Выведем общие параметры фигур
        public double Area { get; set; } // площадь 
        public string Color { get; set; } // цвет
        public string Name { get; set; } // имя фигуры
        public abstract void GetInfo(); // Настройка вывода результатов в консоль.
    }
}
