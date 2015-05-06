using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsVP
{
    abstract public class Shape
    {
        public Point Position { get; set; }

        public Shape(Point point)
        {
            Position = point;
        }

        public abstract void Draw(Graphics g);

        public abstract bool IsHit();


    }
}
