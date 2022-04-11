using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №2");
            Console.WriteLine("Студент группы ВИС-31 Солтанов Владислав");

            Circle a = new Circle()
            {
                Name = "Кружок",
                Raduis = 3
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());

            Triangle b = new Triangle()
            {
                Name = "Треугольник",
                Height = 4,
                Bottom = 5
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());

            Square c = new Square()
            {
                Name = "Квадрат",
                Side = 5
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Площадь фигуры: {0}", c.GetArea());

            Rhomb d = new Rhomb()
            {
                Name = "Ромб",
                Side = 3,
                Height = 6
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", d.Name);
            Console.WriteLine("Площадь фигуры: {0}", d.GetArea());

            Rectangle e = new Rectangle()
            {
                Name = "Прямоугольник",
                Width = 14.2,
                Height = 13.8

            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", e.Name);
            Console.WriteLine("Площадь фигуры: {0}", e.GetArea());

            Trapeze f = new Trapeze()
            {
                Name = "Трапеция",
                Top = 2,
                Bottom = 6
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", f.Name);
            Console.WriteLine("Площадь фигуры: {0}", f.GetArea());

            Parallelogram g = new Parallelogram()
            {
                Name = "Параллелограмм",
                Side = 4,
                Height = 8
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", g.Name);
            Console.WriteLine("Площадь фигуры: {0}", g.GetArea());

            Pentagon h = new Pentagon()
            {
                Name = "Пятиугольник",
                Side = 5
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", h.Name);
            Console.WriteLine("Площадь фигуры: {0}", h.GetArea());


            Decagon i = new Decagon()
            {
                Name = "Десятиугльник",
                Side = 10
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", i.Name);
            Console.WriteLine("Площадь фигуры: {0}", i.GetArea());

            
            

            

           
        }
    }
}
