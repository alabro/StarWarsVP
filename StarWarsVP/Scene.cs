using StarWarsVP.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
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
        private Random random;
        private int GenerationFactor;
        private GameOver End;

        private static Scene Instance;

        public static Scene GetScene(Rectangle Rectangle)
        {
            if (Instance == null)
            {
                Instance = new Scene(Rectangle);
            }
            return Instance;
        }

        private Scene(Rectangle Rectangle)
        {
            Shape.DEFAULT_RADIUS = Rectangle.Width / 20;
            Bounds = new Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Width - Shape.DEFAULT_RADIUS*2, Rectangle.Height);
            PLAYER_Y = Bounds.Bottom - Shape.DEFAULT_RADIUS;
            Player = new Player(new Point(Bounds.Left + Bounds.Width / 2 - 15, Bounds.Bottom - Shape.DEFAULT_RADIUS*5));
            Enemies = new List<Enemy>();
            Bullets = new List<Bullet>();
            random = new Random();
            GenerationFactor = 0;
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
            GenerationFactor++;
            if (GenerationFactor % 20 == 0)
            {
                int n = random.Next(0, 4);
                int lastX = -Shape.DEFAULT_RADIUS * 2;
                int p = 0;
                for (int i = 0; i < n; i++)
                {
                    p = random.Next(0, Bounds.Width);
                    while (p >= lastX && p <= lastX + Shape.DEFAULT_RADIUS * 2)
                    {
                        p = random.Next(0, Bounds.Width);
                    }
                    Enemies.Add(new Enemy(new Point((Shape.DEFAULT_RADIUS * 2 + p) % Bounds.Width, Bounds.Top - Shape.DEFAULT_RADIUS + i * Shape.DEFAULT_RADIUS * 2)));
                    lastX = p;
                }
                GenerationFactor = 0;
            }

        }

        public void DetectColisions()
        {
            foreach(Enemy e in Enemies){
                if (!e.Hit)
                {
                    if (e.IsHit(Player))
                    {
                        Player.DecreaseLife();
                        Player.Hit = true;
                        e.Hit = true;
                        if (Player.Life == 0)
                        {
                            //GAME OVER
                            EndGame();
                            Player.Dead = true;
                        }
                    }
                    foreach (Bullet b in Bullets)
                    {
                        if (e.IsHit(b))
                        {
                            if (b.Type == BulletType.GREEN)
                            {
                                Player.Score++;
                            }
                            e.Hit = true;
                            b.Dead = true;
                        }
                    
                        if(Player.IsHit(b) && BulletType.RED == b.Type){
                            Player.DecreaseLife();
                            Player.Hit = true;
                            b.Dead = true;
                            if (Player.Life == 0)
                            {
                                //GAME OVER
                                EndGame();
                                Player.Dead = true;
                            }
                        }
                    }
                }

            }
        }

        public void EndGame()
        {
            if (End == null)
            {
                End = new GameOver(GetScore());
                End.ShowDialog();
            }
        }


        public void Update()
        {
            GenerateEnemies();

            DetectColisions();

            UpdateEnemies();

            UpdateBullets();
        }

        private void UpdateBullets()
        {
            List<Bullet> AliveBullets = new List<Bullet>();
            foreach (Bullet b in Bullets)
            {
                b.Move(Direction.UP);
                if (b.Position.Y >= Bounds.Top && b.Position.Y <= Bounds.Bottom && !b.Dead)
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
                    if (!e.Hit)
                    {
                        Bullets.AddRange(e.Shoot());
                    }
                }
                if (e.Position.Y >= Bounds.Top - Shape.DEFAULT_RADIUS && e.Position.Y <= Bounds.Bottom && !e.Dead)
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

        public int Life()
        {
            return Player.Life;
        }

        public int timeto()
        {
            return Player.getTime();
        }


        public void Shoot()
        {
            if (Player.Life!=0)
            {
                Bullets.AddRange(Player.Shoot());
            }
        }

        public int GetScore()
        {
            return Player.Score;
        }

        public bool GameOver()
        {
            return Player.Dead;
        }
    }
}
