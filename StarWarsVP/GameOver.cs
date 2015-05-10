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
    public partial class GameOver : Form
    {
        private int Score;
        public PlayerScore PlayerScore { get; set; }
        public GameOver()
        {
            InitializeComponent();
        }

        public GameOver(int p)
        {
            InitializeComponent();
            this.Score = p;
            lblScore.Text = "Your score: " + Score; 
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            PlayerScore = new PlayerScore(tbPlayerName.Text, Score);
            Serializer.AddPlayer(PlayerScore);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
