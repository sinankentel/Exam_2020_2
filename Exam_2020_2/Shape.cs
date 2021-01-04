using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2020_2
{
    public class Shape
    {
        public virtual void drawShape()
        {
            Console.WriteLine("draewing a shape");
        }
    }

    public  class Square: Shape
    {
        public override void drawShape()
        {
            Console.WriteLine("drawing a Square");
        }
    }

    public class Circle : Shape
    {
        public override void drawShape()
        {
            Console.WriteLine("drawing a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void drawShape()
        {
            Console.WriteLine("drawing a Rectangle");
        }
    }

    public class ShapeFactory
    {
        public void drawShape(string type)
        {
            // default değeri null.
            Shape shape;

            if(type == "Circle")
            {
                shape = new Circle();
            }
            else if(type == "Square")
            {
                shape = new Square();
            }
            else if (type == "Rectangle")
            {
                shape = new Rectangle();
            }
            else
            {
                Console.WriteLine("drawing {0} is not supported", type);
                return;
            }

            // null check koymazsan burada patlıyor ama zaten buraya gelmeden else içinde return olması gerekiyor. 
            // switch case kullandığında default değere girebileceği için null setlemiş ve null check (?) kullanmış.
            shape.drawShape();
        }
    }

}
