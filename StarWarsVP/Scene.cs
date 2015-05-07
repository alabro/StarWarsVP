using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace StarWarsVP
{

    public class Scene
    {
        private int PLAYER_Y;
        public static Rectangle Bounds;
        private List<Enemy> Enemies;
        private Player Player;
        private List<Bullet> Bullets;
        private Semaphore locked;
        private Random random;
        private int count;

        public Scene(Rectangle Rectangle)
        {
            Bounds = Rectangle;
            PLAYER_Y = Bounds.Bottom - 50;
            Player = new Player(new Point(Bounds.Left + Bounds.Width / 2 - 15, Bounds.Bottom - 70));
            Enemies = new List<Enemy>();
            Bullets = new List<Bullet>();
            locked = new Semaphore(1, 1);
            random = new Random();
            count = 0;
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

        private void GenerateEnemies()
        {
            int n = random.Next(1, 4);
            for (int i = 0; i < n; i++)
            {
                Enemies.Add(new Enemy(new Point(random.Next(0, Bounds.Right - 40), Bounds.Top + 10)));
            }

        }

        public void Update()
        {
            if (count++ % 20 == 0)
            {
                GenerateEnemies();
            }

            foreach (Enemy e in Enemies)
            {
                e.Move(Direction.DOWN);
            }

            
            locked.WaitOne();
            foreach (Bullet b in Bullets)
            {
                b.Move(Direction.UP);
                if (b.Position.Y < Bounds.Top)
                {
                    b.Hit = true;
                }
            }
            locked.Release();
            
        }

        public void Move(Direction Direction)
        {
            Player.Move(Direction);
        }


        public void Shoot()
        {
            Point Position = Player.Position;
            Bullet left = new Bullet(Position, BulletDirection.UP);
            Bullet right = new Bullet(new Point(Position.X+40,Position.Y), BulletDirection.UP);
            Bullets.Add(left);
            Bullets.Add(right);
        }
    }
}
