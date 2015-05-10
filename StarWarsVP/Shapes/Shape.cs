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

        private readonly int VELOCITY = 20;
        public static int DEFAULT_RADIUS = 200;
        protected int Radius;
        public Point Position { get; set; }
        public int VelocityX { get; set; }
        public int VelocityY { get; set; }
        public bool Hit { get; set; }
        public bool Dead { get; set; }
        protected int timeToDie;

        public Shape(Point position)
        {
            Position = position;
            VelocityX = VELOCITY;
            VelocityY = VELOCITY;
            Radius = DEFAULT_RADIUS;
            timeToDie = 0;
            Hit = false;
            Dead = false;
        }

        public abstract void Move(Direction direction);

        public abstract void Draw(Graphics g);

        public bool IsHit(Shape s)
        {
            int xx = (Position.X + Radius - s.Position.X + s.Radius) * (Position.X + Radius - s.Position.X + s.Radius);
            int yy = (Position.Y + Radius - s.Position.Y + s.Radius) * (Position.Y + Radius - s.Position.Y + s.Radius);
            return xx + yy <= Radius * Radius + Radius*1.5;
        }



    }
}
