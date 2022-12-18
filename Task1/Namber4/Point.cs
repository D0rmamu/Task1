using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Namber4
{
    public class Point 
    {
        public Point() : this("", 0, 0) { }
        public Point(string name, int x, int y) 
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Введите наименование точки:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            this.name = Console.ReadLine();
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Ввеидте X:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            this.x = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Ввеидте y:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            this.y = int.Parse(Console.ReadLine());
            Console.ResetColor();
        }
        string name;
        int x, y;
        public int X => x;
        public int Y => y;
        public string Name => name;

        
    }
}

