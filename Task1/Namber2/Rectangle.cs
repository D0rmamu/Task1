using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Namber2
{
    public class Rectangle
    {
        public double side1;
        public double side2;
        

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator() => (side1 * side2);

        public double PerimeterCalculator =>  (side1 + side2) * 2;

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator; }
        }
    }


}

