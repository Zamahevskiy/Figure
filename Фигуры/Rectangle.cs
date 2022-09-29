using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигуры 
{
    internal class Rectangle : Shape
    {
        public int height;
         public int width;
        public int height1;
        public int width1;

        public Rectangle(int height, int width, int height1, int width1, string color) : base(color)
        {

            this.height = height;
            this.width = width;
            this.height1 = height1;
            this.width1 = width1;
        }
         
        public override void draw()
        {
            Console.WriteLine($"Рисую прямоугольник со сторонами:({height},{width},{height1},{width1}), {color} цвета");
        }
        public override bool equals(Shape shape)
        {
            if (this.GetType() == shape.GetType())
            {
                Rectangle rectangle = shape as Rectangle;

                if (this.color == shape.color && this.height == rectangle.height && this.width == rectangle.width && this.height1 == rectangle.height1 && this.width1 == rectangle.width1)
                {
                    return true;
                }
            }
            return false;
        }
    }
   
}
