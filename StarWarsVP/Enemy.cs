using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StarWarsVP
{
    public class Enemy : Shape
    {

        public Enemy(Point position)
            : base(position)
        {

        }

        public override void Move(Direction direction)
        {

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
