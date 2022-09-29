using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фигуры
{
    internal abstract class Shape
    {
        public abstract void draw();

        public string color;
        public Shape(string color)
        {
            this.color = color;
        }
        public abstract bool equals(Shape shape);
    }
}
