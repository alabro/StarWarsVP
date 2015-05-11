using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsVP
{
    public abstract class Shape
    {

        public static int DEFAULT_RADIUS;
        private readonly int VELOCITY;
        protected int Radius { get; set;}
        protected Point Position { get; set; }
        protected int VelocityX { get; set; }
        protected int VelocityY { get; set; }
        protected int TTD { get; set; }
        public bool Hit { get; set; }
        public bool Dead { get; set; }

        public Shape(Point position)
        {
            VelocityX = DEFAULT_RADIUS;
            VelocityY = DEFAULT_RADIUS;
            Radius = DEFAULT_RADIUS;
            Position = new Point(position.X,position.Y);
            TTD = 0;
            Hit = false;
            Dead = false;
        }

        public abstract void Move(Direction direction,Rectangle Bounds);

        public abstract void Draw(Graphics g);

        public bool IsHit(Shape s)
        {
            int xx = (Position.X - s.Position.X) * (Position.X - s.Position.X);
            int yy = (s.Position.Y - Position.Y) * (s.Position.Y - Position.Y);
            return xx + yy <= (Radius+s.Radius) * (Radius+s.Radius);
        }

        public bool OutOfBounds(Rectangle Bounds)
        {
            bool Status = false;

            if (Position.Y <= Bounds.Top-Radius*4 || Position.Y >= Bounds.Bottom)
            {
                Status = true;
            }

            //if (Position.X >= Bounds.Right + DEFAULT_RADIUS || Position.Y <= Bounds.Left - DEFAULT_RADIUS)
            //{
            //    Status = true;
            //}

            return Status;

        }

    }
}
