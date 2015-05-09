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
        public List<Bitmap> Fighter;
        public List<Bitmap> Imperial;
        public List<Bitmap> Explosion;
        public List<Bitmap> Bullets;
        public bool DoneLoading;

        public void LoadSprites()
        {
            Fighter.Add(Resources.fighter);
            Fighter.Add(Resources.fighter1);
            Fighter.Add(Resources.fighter2);
            Fighter.Add(Resources.fighter3);
            Fighter.Add(Resources.fighter4);
            Fighter.Add(Resources.fighter5);

            Explosion.Add(Resources.e1);
            Explosion.Add(Resources.e2);
            Explosion.Add(Resources.e3);
            Explosion.Add(Resources.e4);
            Explosion.Add(Resources.e5);
            Explosion.Add(Resources.e6);
            Explosion.Add(Resources.e7);
            Explosion.Add(Resources.e8);
            Explosion.Add(Resources.e9);
            Explosion.Add(Resources.e10);
            Explosion.Add(Resources.e11);

            Bullets.Add(Resources.RedLaser);
            Bullets.Add(Resources.GreenLaser);

            Imperial.Add(Resources.imperialFighter);

            DoneLoading = true;
        }

        public static SpriteList Instance;

        public static SpriteList GetSprites(){
            if (Instance == null)
            {
                Instance = new SpriteList();
            }
            return Instance;
        }

        private SpriteList()
        {
            DoneLoading = false;
            Fighter = new List<Bitmap>();
            Imperial = new List<Bitmap>();
            Explosion = new List<Bitmap>();
            Bullets = new List<Bitmap>();
            LoadSprites();
        }
    }
}
