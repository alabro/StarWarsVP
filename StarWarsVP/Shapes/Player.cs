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

        public override void Move(Direction direction)
        {
            int newX = 0;

            switch (direction)
            {
                case Direction.LEFT:
                    newX = Position.X - VelocityX;
                    break;

                case Direction.RIGHT:
                    newX = Position.X + VelocityX;
                    break;
            }

            if (newX <= Scene.Bounds.Right-40 && newX >= Scene.Bounds.Left)
            {
                Position = new Point(newX, Position.Y);
                CenterGuns();
            }

        }


        public void CenterGuns()
        {
            LeftGun = new Point(Position.X, Position.Y + DEFAULT_RADIUS/2);
            RightGun = new Point(Position.X + DEFAULT_RADIUS * 2, Position.Y + DEFAULT_RADIUS / 2);
        }

        public override void Draw(Graphics g)
        {
            if (Hit)
            {
                timeToDie++;
            }
            if (timeToDie == 10)
            {
                timeToDie = 0;
                Hit = false;
            }
            g.DrawImage(GetImage(), Position.X + DEFAULT_RADIUS, Position.Y + DEFAULT_RADIUS, DEFAULT_RADIUS * 2, DEFAULT_RADIUS * 2);
        }

        public void DecreaseLife()
        {
            if (!Hit)
            {
                Life--;
            }
            else
            {
                if (timeToDie == 10)
                {
                    timeToDie = 0;
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
                    i = SpriteList.Instance.Explosion[timeToDie++%10];
                    break;
            }
            if (Hit && timeToDie%3==0 && !Dead)
            {
                i = SpriteList.Instance.Fighter[6];
            }

            return i;
        }



        public List<Bullet> Shoot()
        {
            List<Bullet> Bullets = new List<Bullet>();
            Bullets.Add(new Bullet(LeftGun, BulletType.GREEN));
            Bullets.Add(new Bullet(RightGun, BulletType.GREEN));
            return Bullets;
        }

        public int getTime()
        {
            return timeToDie;
        }

    }
}
