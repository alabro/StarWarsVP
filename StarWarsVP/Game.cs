using StarWarsVP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarsVP
{
    public partial class Game : Form
    {
        public static Image image = new Bitmap(Resources.Falcon1, new Size(Shape.DEFAULT_RADIUS, Shape.DEFAULT_RADIUS));
        private Scene Scene;
        Timer timer;
        int time;
        static readonly int TIMER_INTERVAL = 40;

        public Game()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public void NewGame()
        {
            lblTime.Text = "00:00";
            time = 0;
            //SpriteList.Instance.LoadSprites();
            Scene = new Scene(pnlScene.DisplayRectangle);
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TIMER_INTERVAL;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            time++;
            //lblTime.Text = string.Format("{0:00}:{1:00}", (time/24)/60, (time/24)%60);
            Scene.Update();
            lblTime.Text = string.Format("{0}", Scene.Life());
            pnlScene.Invalidate();
        }


        public void ToggleViews()
        {
            pnlMainMenu.Visible = !pnlMainMenu.Visible;
            pnlOptions.Visible = !pnlOptions.Visible;
            pnlScore.Visible = !pnlScore.Visible;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pnlScene.Visible = true;
            ToggleViews();
            NewGame();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            ToggleViews();
            pnlHighScores.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //TODO SAVE SCORE
            ToggleViews();
            if (timer != null)
            {
                timer.Stop();
            }
            Scene = null;
            pnlScene.Visible = false;
            pnlHighScores.Visible = false;
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            //todo toggle sound
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (Scene != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        Scene.Move(Direction.LEFT);
                        break;

                    case Keys.Right:
                        Scene.Move(Direction.RIGHT);
                        break;
                }

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

        
        

    }


    



}
