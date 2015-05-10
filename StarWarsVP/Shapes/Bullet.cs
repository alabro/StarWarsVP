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

        public override void Move(Direction Direction)
        {
            Position = new Point(Position.X, Position.Y + VelocityY);
        }


        public override void Draw(Graphics g)
        {
            Image i = SpriteList.Instance.Bullets[0];
            if (Type == BulletType.GREEN)
            {
                i = SpriteList.Instance.Bullets[1];
            }
            g.DrawImage(i, Position.X + Radius, Position.Y + Radius, Radius*2, Radius*2);
        }

    }
}
