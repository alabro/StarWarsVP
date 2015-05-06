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
        public static Rectangle Bounds;
        private List<Enemy> Enemies;
        private Player Player;
        private List<Bullet> Bullets;


        public Scene(Rectangle Rectangle)
        {
            Bounds = Rectangle;
            Player = new Player(new Point(Bounds.Left + Bounds.Width / 2 - 15, Bounds.Bottom - 70));
            Enemies = new List<Enemy>();
            Bullets = new List<Bullet>();
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

        public void Update()
        {
            foreach (Enemy e in Enemies)
            {
                e.Move(Direction.DOWN);
            }

            foreach (Bullet b in Bullets)
            {
                b.Move(Direction.UP);
            }
        }

        public void Move(Direction Direction)
        {
            Player.Move(Direction);
        }


        public void Shoot()
        {
            Point Position = Player.Position;
            Bullet l = new Bullet(Position, BulletDirection.UP);
            Bullet r = new Bullet(new Point(Position.X+40,Position.Y), BulletDirection.UP);
            Bullets.Add(l);
            Bullets.Add(r);
        }
    }
}
