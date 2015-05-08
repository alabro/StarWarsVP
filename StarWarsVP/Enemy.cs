using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StarWarsVP
{
    public class Enemy : Shape, Armed
    {
        private Random random;
        private int Dir;
        private EnemyType Type;

        public Enemy(Point position)
            : base(position)
        {
            random = new Random();
            VelocityY = random.Next(4,6);
            Dir = random.Next() % 2 == 0 ? 1 : -1;
        }

        public override void Move(Direction direction)
        {
            int newVel = random.Next(0,11);
            VelocityX = newVel;
            if (random.Next(0, 100) < 10)
            {
                Dir = -Dir;
            }

            if (Position.X - VelocityX*Dir <= Scene.Bounds.Left + 40)
            {
                Dir = -Dir;
            }

            if (Position.X + VelocityX * Dir >= Scene.Bounds.Right-40)
            {
                Dir = -Dir;
            }

            if (Position.X + VelocityX * Dir >= Scene.Bounds.Left || Position.X + VelocityX * Dir <= Scene.Bounds.Right)
            {
                Position = new Point(Position.X + VelocityX*Dir, Position.Y + VelocityY);
            }
            Position = new Point(Position.X, Position.Y + VelocityY);
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Aqua);
            g.FillEllipse(b,Position.X + DEFAULT_RADIUS+DEFAULT_RADIUS/10,Position.Y+DEFAULT_RADIUS,DEFAULT_RADIUS*2,DEFAULT_RADIUS*2);
        }

        public override bool IsHit(Shape s)
        {
            return false;
        }


        public List<Bullet> Shoot()
        {
            List<Bullet> Bullets = new List<Bullet>();
            Bullets.Add(new Bullet(new Point(Position.X + DEFAULT_RADIUS, Position.Y + DEFAULT_RADIUS*2), BulletType.RED));
            return Bullets; 
        }
    }
}
