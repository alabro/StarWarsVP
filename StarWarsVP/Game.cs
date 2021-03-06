﻿using StarWarsVP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsVP
{
    public partial class Game : Form
    {
        private Scene Scene;
        Timer timer;
        int time;
        static readonly int TIMER_INTERVAL = 40;
        public SpriteList Sprites;
        public Serializer Scores; 
        private SoundPlayer Theme;
        private int TimeToLive;


        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            SpriteList.GetSprites();
            Serializer.GetSerializer();
            //Serializer.ClearScores();
        }

        public void NewGame()
        {
            System.Threading.Thread.Sleep(100);
            Scene = new Scene(pnlScene.DisplayRectangle);
            Theme = new SoundPlayer(Resources.imperial);
            Theme.PlayLooping();
            time = 0;
            TimeToLive = 20;
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TIMER_INTERVAL;
            
            UpdateMenu();
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (Scene != null)
            {
                Scene.Update();
                time++;
                UpdateMenu();
                if (Scene.GameOver())
                {
                    if (TimeToLive-- == 0)
                    {
                        timer.Stop();
                    }
                }
                pnlScene.Invalidate();
            }
        }

        private void UpdateMenu()
        {
            lblScore.Text = string.Format("Score : {0}", Scene.GetScore());
            lblTime.Text = string.Format("{0:00}:{1:00}", (time / 24) / 60, (time / 24) % 60);
            switch (Scene.Life())
            {
                case 3:
                    pbHeart3.Visible = pbHeart1.Visible = pbHeart2.Visible = true;
                    break;
                case 2:
                    pbHeart3.Visible = false;
                    break;
                case 1:
                    pbHeart2.Visible = false;
                    break;
                case 0:
                    pbHeart1.Visible = false;
                    break;
            }
        }


        public void ToggleViews()
        {
            pnlMainMenu.Visible = !pnlMainMenu.Visible;
            pnlOptions.Visible = !pnlOptions.Visible;
            pnlScore.Visible = !pnlScore.Visible;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (SpriteList.DoneLoading)
            {
                btnRestart.Visible = true;
                pnlScene.Visible = true;
                ToggleViews();
                NewGame();
            }
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            ToggleViews();
            BlankMenu();
            btnRestart.Visible = false;
            pnlHighScores.Visible = true;
            lblScores.Text = Serializer.GetString();
            lblScores.Visible = true;
        }

        private void BlankMenu()
        {
            pbHeart1.Visible = pbHeart2.Visible = pbHeart3.Visible = false;
            lblScore.Text = "";
            lblTime.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Serializer.SaveScores();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Theme != null)
            {
                Theme.Stop();
            }
            ToggleViews();
            if (timer != null)
            {
                timer.Stop();
            }
            lblScores.Visible = false;
            btnRestart.Visible = false;
            Scene = null;
            pnlScene.Visible = false;
            pnlHighScores.Visible = false;
        }

        

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (Scene != null)
            {
                if (e.KeyCode == Keys.D)
                {
                    Scene.Shoot();
                }
            }
            
        }

        private void pnlScene_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (Scene != null)
            {
                if (Scene.Life() == 0)
                {
                    NewGame();
                }
                else
                {
                    if (Scene.EndGame())
                    {
                        NewGame();
                    }
                    else
                    {
                        timer.Start();
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (Scene != null)
            {
                switch (keyData)
                {
                    case Keys.Left:
                        Scene.Move(Direction.LEFT);
                        break;

                    case Keys.Right:
                        Scene.Move(Direction.RIGHT);
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        

    }


    



}
