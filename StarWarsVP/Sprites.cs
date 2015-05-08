using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace StarWarsVP
{
    public class Sprites : IDrawable
    {
        protected int x;
        protected int y;
        protected Size spriteSize;
        protected Point collitionPoint;
        protected Rectangle collitionRectangle;
        protected ImageAttributes imgAttribs;
        public abstract int GetSpriteIndex();
        public virtual Rectangle GetCollitionRectangle()
        {
            collitionRectangle.X = x + collitionPoint.X;
            collitionRectangle.Y = y + collitionPoint.Y;
            return collitionRectangle;
        }

        public abstract void Draw(Graphics g);

        public void Sprite()
		{
			x = 0;
			y = 0;	
			spriteSize = new Size(0, 0);
			collitionPoint = new Point(0, 0);
			collitionRectangle = new Rectangle(x, y, spriteSize.Width, spriteSize.Height);
			
			imgAttribs = new ImageAttributes();			
			imgAttribs.SetColorKey(Color.FromArgb(0, 66, 173), Color.FromArgb(0, 66, 173));
		}
    }
}

