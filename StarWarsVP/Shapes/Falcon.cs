using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StarWarsVP.Shapes
{
    
    public class Falcon : Shape
    {


        public Falcon(Point point): base(point){

        }

        public override void Draw(Graphics g)
        {

        }

        public override bool IsHit()
        {
            throw new NotImplementedException();
        }

        public void Move(bool direction){
            Position = new Point(Position.X + (direction?-10:+10),Position.Y);
        }
    }
}
