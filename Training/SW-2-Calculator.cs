using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
 
    class Square
    {
        public int length;

    public Square(int length)
        {
        this.length = length;
        }
    }

    class Circle
    {
        public int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
    }


    class AreaCalculator
    {
        public ArrayList shapes = new ArrayList() { new Circle(6), new Square(5) };
        
        public AreaCalculator(ArrayList shapes)
        {
        this.shapes = shapes;
       
        }

        public double sum()
        {

            double area=0.00;
            foreach (object shape in shapes) 
            {
                object obj = shape;
                if (typeof(Circle)== shape.GetType()) 
                {
                    Console.WriteLine(shape.GetType());
                area = Math.Pow(3, 2);
                    Console.WriteLine("Circle Obj");
                }
                

            }

            return area;
        }
    
        static void Main(string[] args)
        {
            ArrayList shapes = new ArrayList() { new Circle(6), new Square(5) };
            AreaCalculator a1 = new AreaCalculator(shapes);
            a1.sum();

            Console.WriteLine(typeof(Circle));
            Console.WriteLine(typeof(Square));
            Console.WriteLine(typeof(AreaCalculator));
        }
    }
}
