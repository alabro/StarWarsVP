namespace StarWarsVP
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlHighScores = new System.Windows.Forms.Panel();
            this.pnlScene = new StarWarsVP.Game.PanelDoubleBuffered();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::StarWarsVP.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Location = new System.Drawing.Point(0, -11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(357, 153);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(86, 205);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(176, 81);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Location = new System.Drawing.Point(86, 292);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(176, 81);
            this.btnHighScores.TabIndex = 2;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(86, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 81);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(20, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(329, 6);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(51, 31);
            this.btnSound.TabIndex = 5;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.Gold;
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOptions.Controls.Add(this.btnBack);
            this.pnlOptions.Controls.Add(this.btnSound);
            this.pnlOptions.Location = new System.Drawing.Point(-8, 517);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(400, 44);
            this.pnlOptions.TabIndex = 6;
            this.pnlOptions.Visible = false;
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainMenu.Controls.Add(this.pbLogo);
            this.pnlMainMenu.Controls.Add(this.btnExit);
            this.pnlMainMenu.Controls.Add(this.btnNewGame);
            this.pnlMainMenu.Controls.Add(this.btnHighScores);
            this.pnlMainMenu.Controls.Add(this.pnlHighScores);
            this.pnlMainMenu.Location = new System.Drawing.Point(14, 12);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(358, 499);
            this.pnlMainMenu.TabIndex = 7;
            // 
            // pnlHighScores
            // 
            this.pnlHighScores.Location = new System.Drawing.Point(0, 22);
            this.pnlHighScores.Name = "pnlHighScores";
            this.pnlHighScores.Size = new System.Drawing.Size(354, 474);
            this.pnlHighScores.TabIndex = 5;
            this.pnlHighScores.Visible = false;
            // 
            // pnlScene
            // 
            this.pnlScene.BackColor = System.Drawing.Color.Transparent;
            this.pnlScene.Location = new System.Drawing.Point(-8, 23);
            this.pnlScene.Name = "pnlScene";
            this.pnlScene.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlScene.Size = new System.Drawing.Size(400, 498);
            this.pnlScene.TabIndex = 4;
            this.pnlScene.Visible = false;
            this.pnlScene.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlScene_Paint);
            // 
            // pnlScore
            // 
            this.pnlScore.BackColor = System.Drawing.Color.Gold;
            this.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScore.Controls.Add(this.lblTime);
            this.pnlScore.Controls.Add(this.lblTitle);
            this.pnlScore.Location = new System.Drawing.Point(-8, -1);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(400, 29);
            this.pnlScore.TabIndex = 7;
            this.pnlScore.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(346, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(34, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(19, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 13);
            this.lblTitle.TabIndex = 0;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::StarWarsVP.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlScene);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Game";
            this.Text = "StarWars";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Panel pnlHighScores;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private Game.PanelDoubleBuffered pnlScene;
    
        public class PanelDoubleBuffered : System.Windows.Forms.Panel
        {
            public PanelDoubleBuffered()
                : base()
            {
                this.DoubleBuffered = true;
            }
        }
    }

}

