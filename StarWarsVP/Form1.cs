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
    public partial class Form1 : Form
    {
        private Scene Scene;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }


        public void ToggleViews()
        {
            pnlMainMenu.Visible = !pnlMainMenu.Visible;
            pnlOptions.Visible = !pnlOptions.Visible;
            pnlScore.Visible = !pnlScore.Visible;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ToggleViews();
            pnlScene.Visible = true;
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
            pnlScene.Visible = false;
            pnlHighScores.Visible = false;
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            //todo toggle sound
        }

    }


    



}
