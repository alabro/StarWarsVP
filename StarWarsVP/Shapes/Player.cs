using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using StarWarsVP.Properties;

namespace StarWarsVP
{
    public class Player : Shape, Armed
    {
        private Point LeftGun;
        private Point RightGun;
        public int Life { get; set; }
        public int Score { get; set; }

        public Player(Point position)
            : base(position)
        {
            CenterGuns();
            Life = 3;
        }

        public override void Move(Direction direction,Rectangle Bounds)
        {
            if(Life!=0){
                int L = Bounds.Left;
                int R = Bounds.Right;
                switch (direction)
                {
                    case Direction.LEFT:
                        VelocityX = -Radius;
                        break;

                    case Direction.RIGHT:
                        VelocityX = Radius;
                        break;
                }
                if ((Position.X - Radius + VelocityX < L) || (Position.X + Radius + VelocityX > R))
                {
                    VelocityX = 0;
                }
                Position = new Point(Position.X + VelocityX, Position.Y);
                CenterGuns();

            }

        }


        public void CenterGuns()
        {
            LeftGun = new Point(Position.X - Radius, Position.Y-Radius);
            RightGun = new Point(Position.X + Radius, Position.Y-Radius);
        }

        public override void Draw(Graphics g)
        {
            //Debuging
            //Pen p = new Pen(Color.Green);
            //g.DrawEllipse(p, Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
            //g.FillEllipse(new SolidBrush(Color.Red), Position.X - 5, Position.Y - 5, 10, 10);
            //p.Dispose();

            if (Hit)
            {
                TTD++;
            }
            if (TTD == 10)
            {
                TTD = 0;
                Hit = false;
            }
            g.DrawImage(GetImage(), Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
        }

        public void DecreaseLife()
        {
            if (!Hit)
            {
                //Comment for debuging
                Life--;
            }
            else
            {
                if (TTD == 10)
                {
                    TTD = 0;
                    Hit = false;
                }

                if (Life == 0)
                {
                    Dead = true;
                }
            }

        }


        public Image GetImage()
        {
            Image i;
            switch (Life)
            {
                case 3:
                    i = DateTime.Now.Millisecond % 2 == 0 ? SpriteList.Instance.Fighter[0] : SpriteList.Instance.Fighter[1];
                    break;
                case 2:
                    i = DateTime.Now.Millisecond % 2 == 0 ? SpriteList.Instance.Fighter[2] : SpriteList.Instance.Fighter[3];
                    break;
                case 1:
                    i = DateTime.Now.Millisecond % 2 == 0 ? SpriteList.Instance.Fighter[4] : SpriteList.Instance.Fighter[5];
                    break;
                default:
                    i = SpriteList.Instance.Explosion[TTD++%10];
                    break;
            }
            if (Hit && TTD%3==0 && Life!=0)
            {
                i = SpriteList.Instance.Fighter[6];
            }
            return i;
        }

        public List<Bullet> Shoot()
        {
            List<Bullet> Bullets = new List<Bullet>();
            if (Life!=0)
            {
                Bullets.Add(new Bullet(LeftGun, BulletType.GREEN));
                Bullets.Add(new Bullet(RightGun, BulletType.GREEN));
            }
            return Bullets;
        }

    }
}
