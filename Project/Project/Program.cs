using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    class Program
    {
        static void Main() {
            Console.Write("Number of figures: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine()); // Количество вызываемых фигур.


            var figures = new List<Base>(); // Создание Листа
            for (int i = 0; i < arrayLength; i++) {
                var rand = new Random();
                int randomNumber = rand.Next(0, 16); // Диапазон генерируемых фигур в операторе Switch, в случайном порядке.
                switch (randomNumber) {
                    case 0:
                        figures.Add(new Circle(rand.Next(0,1000), "Red", rand.Next(0,1000)));
                        break;
                    case 1:
                        figures.Add(new Trapeze(rand.Next(0, 1000), "Blue", rand.Next(0, 1000)));
                        break;
                    case 2:
                        figures.Add(new Triangle(rand.Next(0, 1000), "Yellow", rand.Next(0, 1000)));
                        break;
                    case 3:
                        figures.Add(new Square(rand.Next(0, 1000), "Green", rand.Next(0, 1000)));
                        break;
                    case 4:
                        figures.Add(new Circle(rand.Next(0, 1000), "Green", rand.Next(0, 1000)));
                        break;
                    case 5:
                        figures.Add(new Trapeze(rand.Next(0, 1000), "Yellow", rand.Next(0, 1000)));
                        break;
                    case 6:
                        figures.Add(new Triangle(rand.Next(0, 1000), "Blue", rand.Next(0, 1000)));
                        break;
                    case 7:
                        figures.Add(new Square(rand.Next(0, 1000), "Red", rand.Next(0, 1000)));
                        break;
                    case 8:
                        figures.Add(new Circle(rand.Next(0, 1000), "Blue", rand.Next(0, 1000)));
                        break;
                    case 9:
                        figures.Add(new Trapeze(rand.Next(0, 1000), "Yellow", rand.Next(0, 1000)));
                        break;
                    case 10:
                        figures.Add(new Triangle(rand.Next(0, 1000), "Red", rand.Next(0, 1000)));
                        break;
                    case 11:
                        figures.Add(new Square(rand.Next(0, 1000), "Green", rand.Next(0, 1000)));
                        break;
                    case 12:
                        figures.Add(new Circle(rand.Next(0, 1000), "Yellow", rand.Next(0, 1000)));
                        break;
                    case 13:
                        figures.Add(new Trapeze(rand.Next(0, 1000), "Green", rand.Next(0, 1000)));
                        break;
                    case 14:
                        figures.Add(new Triangle(rand.Next(0, 1000), "Green", rand.Next(0, 1000)));
                        break;
                    case 15:
                        figures.Add(new Square(rand.Next(0, 1000), "Red", rand.Next(0, 1000)));
                        break;
                    default:
                        break;
                }
            }
            figures.ForEach(figure => figure.GetInfo()); // Обращение к каждому объекту класса, для вывода значений в консоль.
            Console.ReadLine();
        }
    }
}
