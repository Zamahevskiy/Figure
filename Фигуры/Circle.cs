using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигуры
{
    internal class Circle : Shape
    {
        int x;
        int y;
        public Circle(int x, int y, string color) : base(color)
        {
            this.x = x;
            this.y = y;
        }

        public override void draw()
        {
            Console.WriteLine($"Рисую круг с центром:({x},{y}) и цветом {color}");
        }
        public override bool equals(Shape shape)
        {
            if (this.GetType() == shape.GetType())
            {
                Circle circle = shape as Circle;
                if (this.color == shape.color && this.x == circle.x &&
                    this.y == circle.y)
                {
                    return true;
                }
            }

            return false;
        }
    }
   
}

