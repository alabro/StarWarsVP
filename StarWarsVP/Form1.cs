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
        }


        public void ToggleViews()
        {
            btnNewGame.Visible = !btnNewGame.Visible;
            btnHighScores.Visible = !btnHighScores.Visible;
            btnExit.Visible = !btnExit.Visible;
        }

    }


    



}
