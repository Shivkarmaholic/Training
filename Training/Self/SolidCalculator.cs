using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    interface IShape
    {
        public double area(double x);
    }
 
    class Square:IShape
    {
        public double length;

        public Square(double length)
        {
        this.length = length;
        }
        public double area(double length)
        {
            return Math.Pow(length, 2);
        }
    }

    class Circle:IShape
    {
        public double radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public double area(double radius)
        {
            return 3.14 * Math.Pow(radius, 2);
        }

    }


    class AreaCalculator
    {
        public ArrayList shapes;
        
        public AreaCalculator(ArrayList shapes)
        {
        this.shapes = shapes;
       
        }

        public double sum()
        {

            double area=0.00;
            foreach (dynamic shape in shapes) 
            {
                object obj = shape;
                //Console.WriteLine(obj.GetType());
                if(shape is IShape)
                {
                    Console.WriteLine(shape.area());
                }
                
                



            }

            return area;
        }
    
        static void Main(string[] args)
        {
            ArrayList shapes = new ArrayList() { new Circle(10), new Square(10) };
            AreaCalculator a1 = new AreaCalculator(shapes);
            Console.WriteLine("Area of all Shapes = "+ a1.sum());

           
        }
    }
}
