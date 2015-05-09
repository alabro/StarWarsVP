using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Drawing.Imaging;
using System.Data;
using StarWarsVP.Properties;

namespace StarWarsVP
{
    public class SpriteList
    {
        public Bitmap[] Plane;
        public Bitmap[] BPlane;
        public Bitmap[] Bullet1;
        public Bitmap[] Bullet2;
        public Bitmap[] Explosion;
        private bool doneLoading;
        public void LoadSprites()
        {
            Bitmap Falcon = new Bitmap(Resources.Falcon1);
            Bitmap Enemy = new Bitmap(Resources.Emp);
            Bitmap bullet1 = new Bitmap(Resources.Bullet1);
            Bitmap bullet2 = new Bitmap(Resources.Bullet2);
            Bitmap explosion = new Bitmap(Resources.Explosion);
            Plane = ParseSpriteStrip(Falcon);
            BPlane = ParseSpriteStrip(Enemy);
            Bullet1 = ParseSpriteStrip(bullet1);
            Bullet2 = ParseSpriteStrip(bullet2);
            Explosion = ParseSpriteStrip(explosion);
            Falcon.Dispose();
            Enemy.Dispose();
            bullet1.Dispose();
            bullet2.Dispose();
            explosion.Dispose();
            doneLoading = true;
        }

        public static readonly SpriteList Instance = new SpriteList();

        private Bitmap[] ParseSpriteStrip(Bitmap spriteStrip)
        {
            Rectangle spriteRectangle = new Rectangle(1, 1, spriteStrip.Height - 2, spriteStrip.Height - 2);
            Bitmap[] destinationArray = new Bitmap[(spriteStrip.Width - 1) / (spriteStrip.Height - 1)];

            for (int i = 0; i < destinationArray.Length; ++i)
            {
                destinationArray[i] = new Bitmap(spriteRectangle.Width, spriteRectangle.Height);
                Graphics g = Graphics.FromImage(destinationArray[i]);
                spriteRectangle.X = i * (spriteRectangle.Width + 2) - (i - 1);
                g.DrawImage(spriteStrip, 0, 0, spriteRectangle, GraphicsUnit.Pixel);
                g.Dispose();
            }

            return destinationArray;
        }

        private SpriteList()
        {
        }
    }
}
