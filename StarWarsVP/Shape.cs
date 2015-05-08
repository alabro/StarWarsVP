using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsVP
{
    public abstract class Shape : Sprites
    {

        private readonly int VELOCITY = 20;
        public static int DEFAULT_RADIUS = 40;
        public Point Position { get; set; }
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }
        public bool Hit { get; set; }
        public bool Dead { get; set; }

        public Shape(Point position)
        {
            Position = position;
            VelocityX = VELOCITY;
            VelocityY = VELOCITY;
            Hit = false;
            Dead = false;
        }

        public abstract void Move(Direction direction);

        public abstract void Draw(Graphics g);

        public abstract bool IsHit(Shape s);



    }
}
