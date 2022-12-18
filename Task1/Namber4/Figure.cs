using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Namber4
{
    public class Figure
    {
        int A;
        int[] d= new int[10];
        Random rnd = new Random();
        Point[] mas;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("введите количество вершин фигуры");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            A = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Вы ввели такое кол-во точек {A} спасибо за ваше решение но мы сами выберем их количество");
            Console.WriteLine($"Их количество вы узнаете когда их всех напишите может быть от 1 до 10; спасибо за понимание");
            Console.ResetColor();
            for (int i = 0; i < 10; i++)
            {
                d[i] = rnd.Next(1, 11);
                int x = Convert.ToInt32(d[i]);
                mas = new Point[x];
            }
                for (int y = 0; y < mas.Length; y++)
                {
                    mas[y] = new Point();
                }
            
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
          

        public double CalculatePerimeter()
        {
            

            double perimeter = 0;
            for (int i = 1; i < mas.Length; i++)
            {

                perimeter += this.LengthSide(mas[i - 1], mas[i]);
            }
            perimeter += this.LengthSide(mas[0], mas[mas.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }
}
