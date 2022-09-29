using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Shape[] shapes = new Shape[2];
                shapes[0] = new Circle(1, 2, "зеленый");
                shapes[1] = new Rectangle(1, 2, 1, 2, "красный");

                foreach (Shape shape in shapes)
                {
                    shape.draw();
                }
                Console.ReadKey();
            }

        }
    }

}
