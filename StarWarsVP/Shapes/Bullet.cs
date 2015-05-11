using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsVP
{
    public class Bullet : Shape
    {
        public BulletType Type { get; set; }

        public Bullet(Point position,BulletType type)
            : base(position)
        {
            Type = type;
            VelocityY = (type == BulletType.GREEN ? -VelocityY : +VelocityY);
            Radius = DEFAULT_RADIUS/2;
        }

        public override void Move(Direction Direction,Rectangle Bounds)
        {
            Position = new Point(Position.X, Position.Y + VelocityY);
        }


        public override void Draw(Graphics g)
        {
            //Debuging
            //Pen p = new Pen(Color.Green);
            //g.DrawEllipse(p, Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
            //g.FillEllipse(new SolidBrush(Color.Red), Position.X - 5, Position.Y - 5, 10, 10);
            //p.Dispose();

            Image i = SpriteList.Instance.Bullets[0];
            if (Type == BulletType.GREEN)
            {
                i = SpriteList.Instance.Bullets[1];
            }
            g.DrawImage(i, Position.X - Radius, Position.Y - Radius, Radius * 2, Radius * 2);
        }

    }
}
