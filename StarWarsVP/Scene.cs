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
        private static readonly int GENERATION_FACTOR = 20;
        private static Rectangle Bounds;
        private int Generation;
        private List<Enemy> Enemies;
        private Player Player;
        private List<Bullet> Bullets;
        private Random random;
        private GameOver End;

        public Scene(Rectangle Rectangle)
        {
            Shape.DEFAULT_RADIUS = Rectangle.Width / 20;
            Bounds = new Rectangle(Rectangle.X+Shape.DEFAULT_RADIUS, Rectangle.Y, Rectangle.Width-Shape.DEFAULT_RADIUS*2, Rectangle.Height);
            Player = new Player(new Point(Bounds.Left + Bounds.Width / 2, Bounds.Bottom - Shape.DEFAULT_RADIUS*2));
            Enemies = new List<Enemy>();
            Bullets = new List<Bullet>();
            random = new Random();
            Generation = 0;
        }

        public void Draw(Graphics g)
        {
            //Debuging
            //g.DrawRectangle(new Pen(Color.Green), Bounds);

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
            Generation++;
            if (Generation % GENERATION_FACTOR == 0)
            {
                int n = random.Next(0, 4);
                int lastX = 0;
                int p = 0;
                for (int i = 0; i < n; i++)
                {
                    p = random.Next(Shape.DEFAULT_RADIUS, Bounds.Width-Shape.DEFAULT_RADIUS*4);
                    while (p >= lastX && p <= lastX + Shape.DEFAULT_RADIUS * 2)
                    {
                        p = random.Next(Shape.DEFAULT_RADIUS, Bounds.Width);
                    }
                    Enemies.Add(new Enemy(new Point((Shape.DEFAULT_RADIUS * 2 + p),i * Shape.DEFAULT_RADIUS * 2)));
                    lastX = p;
                }
                Generation = 0;
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

                            if (Player.IsHit(b) && BulletType.RED == b.Type)
                            {
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

        public bool EndGame()
        {
            bool status = false;
            if (End == null)
            {
                End = new GameOver(GetScore());
                if (End.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    status = true;
                }
                End.Dispose();
                End = null;
            }
            if (Player.Dead)
            {
                status = true;
            }
            return status;
        }


        public void Update()
        {
            if (!Player.Dead)
            {
                DetectColisions();

                UpdateBullets();

                UpdateEnemies();


                GenerateEnemies();
            }
        }

        private void UpdateBullets()
        {
            List<Bullet> AliveBullets = new List<Bullet>();

            foreach (Bullet b in Bullets)
            {
                   
                if (!b.OutOfBounds(Bounds) && !b.Dead)
                {
                    AliveBullets.Add(b);
                    b.Move(Direction.UP,Bounds);
                }
            }
            Bullets = AliveBullets;
        }

        private void UpdateEnemies()
        {
            List<Enemy> Alive = new List<Enemy>();
            foreach (Enemy e in Enemies)
            {
                
                if (!e.OutOfBounds(Bounds) && !e.Dead)
                {
                    Alive.Add(e);
                    Bullets.AddRange(e.Shoot());
                    e.Move(Direction.DOWN,Bounds);
                }
            }
            Enemies = Alive;
        }

        public void Move(Direction Direction)
        {
            Player.Move(Direction,Bounds);
        }

        public int Life()
        {
            return Player.Life;
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
