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
            VelocityY = random.Next(6,12);
            VelocityX = DateTime.Now.Millisecond % 2 == 0 ? random.Next(1, 6) : -random.Next(1, 6);
        }

        public override void Move(Direction direction,Rectangle Bounds)
        {
            if (!Hit)
            {
                int L = Bounds.Left;
                int R = Bounds.Right;

                if (Position.X-Radius + VelocityX<= L)
                {
                    VelocityX = -VelocityX;
                }
                else if (Position.X+Radius + VelocityX >= R)
                {
                    VelocityX = - VelocityX;
                }
                else
                {
                    if (random.Next(0,100) < 5)
                    {
                        int newVel = random.Next(1, 6);
                        VelocityX = VelocityX > 0 ? -newVel : newVel;
                    }
                }
                Position = new Point(Position.X + VelocityX, Position.Y + VelocityY);
            }
        }

        public override void Draw(Graphics g)
        {
            
            //Debuging
            //Pen p = new Pen(Color.Green);
            //g.DrawEllipse(p, Position.X-Radius, Position.Y-Radius, Radius * 2, Radius * 2);
            //g.FillEllipse(new SolidBrush(Color.Red), Position.X-5, Position.Y-5, 10, 10);
            //p.Dispose();



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
                TTD++;
                if (TTD == 10)
                {
                    Dead = true;
                }
                i = SpriteList.Instance.Explosion[TTD%10];
            }
            g.DrawImage(i, Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
        }


        public List<Bullet> Shoot()
        {
            List<Bullet> Bullets = new List<Bullet>();
            if (!Hit && random.Next(0, 100) < 5)
            {
                Bullets.Add(new Bullet(new Point(Position.X + Radius, Position.Y + Radius*2), BulletType.RED));
            }
            return Bullets; 
        }
    }
}
