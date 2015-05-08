using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Drawing.Imaging;

namespace StarWarsVP
{
    public class SpriteList
    {
        public Bitmap[] Plane;
        public Bitmap[] BPlane;
        public Bitmap[] Bullet1;
        public Bitmap[] Bullet2;
        public Bitmap[] Explotion;
        private bool doneLoading;
        public void LoadSprites()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Bitmap plane = new Bitmap(asm.GetManifestResourceStream("StarWarsVP.Data.Sprites.Falcon.bmp"));
            Bitmap bPlane = new Bitmap(asm.GetManifestResourceStream("StarWarsVP.Data.Sprites.Emp.bmp"));
            Bitmap bullet1 = new Bitmap(asm.GetManifestResourceStream("StarWarsVP.Data.Sprites.Bullet1.bmp"));
            Bitmap bullet2 = new Bitmap(asm.GetManifestResourceStream("StarWarsVP.Data.Sprites.Bullet2.bmp"));
            Bitmap explotion = new Bitmap(asm.GetManifestResourceStream("StarWarsVP.Data.Sprites.Explotion.bmp"));
            Plane = ParseSpriteStrip(plane);
            BPlane = ParseSpriteStrip(bPlane);
            Bullet1 = ParseSpriteStrip(bullet1);
            Bullet2 = ParseSpriteStrip(bullet2);
            Explotion = ParseSpriteStrip(explotion);
            
            plane.Dispose();
            bPlane.Dispose();
            bullet1.Dispose();
            bullet2.Dispose();
            explotion.Dispose();

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
