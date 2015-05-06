using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsVP
{

    public class Scene
    {
        private Rectangle Bounds;
        private List<Enemy> Enemies;
        private Player Player;
        private List<Bullet> Bullets;


        public Scene(Rectangle Rectangle)
        {
            Bounds = Rectangle;

            Player = new Player(new Point(Bounds.Left + Bounds.Width/2,Bounds.Bottom - 50));

        }

        public void Draw(Graphics g)
        {
            foreach (Enemy e in Enemies)
            {
                e.Draw(g);
            }

            foreach (Bullet b in Bullets)
            {
                b.Draw(g);
            }

            Player.Draw(g);
        }

        public void Move(Direction Direction)
        {
            Player.Move(Direction);
        }

    }
}
