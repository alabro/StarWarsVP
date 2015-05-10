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
        //private EnemyType Type;

        public Enemy(Point position)
            : base(position)
        {
            random = new Random();
            VelocityY = random.Next(4,6);
            VelocityX = DateTime.Now.Millisecond % 2 == 0 ? random.Next(1, 6) : -random.Next(1, 6);
        }

        public override void Move(Direction direction)
        {
            if (!Hit)
            {
                int L = Scene.Bounds.Left;
                int R = Scene.Bounds.Right;

                if (Position.X + VelocityX <= L || Position.X + VelocityX >= R)
                {
                    VelocityX = -VelocityX;
                }
                else
                {
                    if (random.Next() < 200)
                    {
                        int newVel = random.Next(1, 11);
                        VelocityX = VelocityX>0? -newVel:newVel;
                    }
                }

                Position = new Point(Position.X + VelocityX, Position.Y + VelocityY);
            }
        }

        public override void Draw(Graphics g)
        {
            Image i = SpriteList.Instance.Imperial[0];
            if (!Hit)
            {
                if (DateTime.Now.Millisecond%2==0)
                {
                    //i = SpriteList.Instance.Imperial[1];
                }
            }
            else
            {
                timeToDie++;
                if (timeToDie == 10)
                {
                    Dead = true;
                }
                i = SpriteList.Instance.Explosion[timeToDie];
            }
            g.DrawImage(i,Position.X + DEFAULT_RADIUS,Position.Y+DEFAULT_RADIUS,DEFAULT_RADIUS*2,DEFAULT_RADIUS*2);
        }


        public List<Bullet> Shoot()
        {
            List<Bullet> Bullets = new List<Bullet>();
            Bullets.Add(new Bullet(new Point(Position.X + DEFAULT_RADIUS, Position.Y + DEFAULT_RADIUS*2), BulletType.RED));
            return Bullets; 
        }
    }
}
