﻿using System;
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
        private Semaphore bulletSemaphore;
        private Semaphore enemySemaphore;
        private Random random;
        private int count;

        public Scene(Rectangle Rectangle)
        {
            Bounds = Rectangle;
            PLAYER_Y = Bounds.Bottom - 50;
            Player = new Player(new Point(Bounds.Left + Bounds.Width / 2 - 15, Bounds.Bottom - 70));
            Enemies = new List<Enemy>();
            Bullets = new List<Bullet>();
            bulletSemaphore = new Semaphore(1, 1);
            enemySemaphore = new Semaphore(1, 1);
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

            UpdateEnemies();

            List<Bullet> AliveBullets = new List<Bullet>();
            foreach (Bullet b in Bullets)
            {
                b.Move(Direction.UP);
                if (b.Position.Y >= Bounds.Top && b.Position.Y <= Bounds.Bottom)
                {
                    AliveBullets.Add(b);
                }
            }

            Bullets = AliveBullets;
            
        }

        private void UpdateEnemies()
        {
            List<Enemy> Alive = new List<Enemy>();

            foreach (Enemy e in Enemies)
            {
                e.Move(Direction.DOWN);
                if (random.Next(0, 100) < 5)
                {
                    Bullet enemy = new Bullet(e.Position, Direction.DOWN, BulletType.RED);
                    Bullets.Add(enemy);
                }
                if (e.Position.Y >= Bounds.Top && e.Position.Y <= Bounds.Bottom)
                {
                    Alive.Add(e);
                }
            }

            Enemies = Alive;
        }

        public void Move(Direction Direction)
        {
            Player.Move(Direction);
        }

  

        public void Shoot()
        {
            Point Position = Player.Position;
            Bullet left = new Bullet(Position, Direction.UP,BulletType.GREEN);
            Bullet right = new Bullet(new Point(Position.X+40,Position.Y), Direction.UP,BulletType.GREEN);
            Bullets.Add(left);
            Bullets.Add(right);
        }
    }
}
