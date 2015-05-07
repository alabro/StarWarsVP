using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StarWarsVP
{
    public class Enemy : Shape
    {
        private Random random;
        private int change;
        private int Dir;

        public Enemy(Point position)
            : base(position)
        {
            VelocityY = 10;
            random = new Random();
            Dir = random.Next() % 2 == 0 ? 1 : -1;
            change = 0;
        }

        public override void Move(Direction direction)
        {
            int newVel = random.Next(0,11);
            VelocityX = newVel;
            if (random.Next(0, 100) < 10)
            {
                Dir = -Dir;
            }

            if (Position.X - VelocityX*Dir <= Scene.Bounds.Left+20)
            {
                Dir = -Dir;
            }

            if (Position.X + VelocityX * Dir >= Scene.Bounds.Right-40)
            {
                Dir = -Dir;
            }



            Position = new Point(Position.X + VelocityX*Dir, Position.Y + VelocityY);
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Aqua);
            g.FillEllipse(b,new Rectangle(Position,new Size(40,40)));
        }

        public override bool IsHit()
        {
            return false;
        }


    }
}
