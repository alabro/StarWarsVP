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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pnlMainMenu = new System.Windows.Forms.Panel();
            this.pnlHighScores = new System.Windows.Forms.Panel();
            this.lblScores = new System.Windows.Forms.Label();
            this.pnlScene = new StarWarsVP.Game.PanelDoubleBuffered();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.pbHeart3 = new System.Windows.Forms.PictureBox();
            this.pbHeart2 = new System.Windows.Forms.PictureBox();
            this.pbHeart1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.pnlMainMenu.SuspendLayout();
            this.pnlHighScores.SuspendLayout();
            this.pnlScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Location = new System.Drawing.Point(0, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(357, 153);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewGame.Image = global::StarWarsVP.Properties.Resources.NewGame;
            this.btnNewGame.Location = new System.Drawing.Point(71, 205);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(216, 66);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.ForeColor = System.Drawing.Color.Transparent;
            this.btnHighScores.Image = global::StarWarsVP.Properties.Resources.HighScores;
            this.btnHighScores.Location = new System.Drawing.Point(71, 292);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(216, 66);
            this.btnHighScores.TabIndex = 2;
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::StarWarsVP.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(71, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 66);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::StarWarsVP.Properties.Resources.Back;
            this.btnBack.Location = new System.Drawing.Point(20, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.Gold;
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOptions.Controls.Add(this.btnRestart);
            this.pnlOptions.Controls.Add(this.btnBack);
            this.pnlOptions.Location = new System.Drawing.Point(-8, 517);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(400, 44);
            this.pnlOptions.TabIndex = 6;
            this.pnlOptions.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.Image = global::StarWarsVP.Properties.Resources.NewGame1;
            this.btnRestart.Location = new System.Drawing.Point(149, 5);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(99, 30);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMainMenu.Controls.Add(this.pnlHighScores);
            this.pnlMainMenu.Controls.Add(this.btnExit);
            this.pnlMainMenu.Controls.Add(this.btnNewGame);
            this.pnlMainMenu.Controls.Add(this.btnHighScores);
            this.pnlMainMenu.Controls.Add(this.pbLogo);
            this.pnlMainMenu.Location = new System.Drawing.Point(14, 12);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.Size = new System.Drawing.Size(358, 499);
            this.pnlMainMenu.TabIndex = 7;
            // 
            // pnlHighScores
            // 
            this.pnlHighScores.Controls.Add(this.listBox1);
            this.pnlHighScores.Controls.Add(this.lblScores);
            this.pnlHighScores.Location = new System.Drawing.Point(0, 22);
            this.pnlHighScores.Name = "pnlHighScores";
            this.pnlHighScores.Size = new System.Drawing.Size(354, 474);
            this.pnlHighScores.TabIndex = 5;
            this.pnlHighScores.Visible = false;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Impact", 12F);
            this.lblScores.ForeColor = System.Drawing.Color.Gold;
            this.lblScores.Location = new System.Drawing.Point(52, 46);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(47, 20);
            this.lblScores.TabIndex = 0;
            this.lblScores.Text = "label1";
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
            this.pnlScore.Controls.Add(this.pbHeart3);
            this.pnlScore.Controls.Add(this.pbHeart2);
            this.pnlScore.Controls.Add(this.pbHeart1);
            this.pnlScore.Controls.Add(this.lblScore);
            this.pnlScore.Controls.Add(this.lblTime);
            this.pnlScore.Controls.Add(this.lblTitle);
            this.pnlScore.Location = new System.Drawing.Point(-8, -1);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(400, 29);
            this.pnlScore.TabIndex = 7;
            this.pnlScore.Visible = false;
            // 
            // pbHeart3
            // 
            this.pbHeart3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHeart3.BackgroundImage")));
            this.pbHeart3.Location = new System.Drawing.Point(363, 4);
            this.pbHeart3.Name = "pbHeart3";
            this.pbHeart3.Size = new System.Drawing.Size(17, 16);
            this.pbHeart3.TabIndex = 5;
            this.pbHeart3.TabStop = false;
            // 
            // pbHeart2
            // 
            this.pbHeart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHeart2.BackgroundImage")));
            this.pbHeart2.Location = new System.Drawing.Point(340, 4);
            this.pbHeart2.Name = "pbHeart2";
            this.pbHeart2.Size = new System.Drawing.Size(17, 16);
            this.pbHeart2.TabIndex = 4;
            this.pbHeart2.TabStop = false;
            // 
            // pbHeart1
            // 
            this.pbHeart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHeart1.BackgroundImage")));
            this.pbHeart1.Location = new System.Drawing.Point(317, 4);
            this.pbHeart1.Name = "pbHeart1";
            this.pbHeart1.Size = new System.Drawing.Size(17, 16);
            this.pbHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHeart1.TabIndex = 3;
            this.pbHeart1.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblScore.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(16, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(62, 20);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Impact", 12F);
            this.lblTime.Location = new System.Drawing.Point(174, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(48, 20);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 290);
            this.listBox1.TabIndex = 1;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.pnlScene);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StarWars";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlMainMenu.ResumeLayout(false);
            this.pnlHighScores.ResumeLayout(false);
            this.pnlHighScores.PerformLayout();
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlMainMenu;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Panel pnlHighScores;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private Game.PanelDoubleBuffered pnlScene;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbHeart3;
        private System.Windows.Forms.PictureBox pbHeart2;
        private System.Windows.Forms.PictureBox pbHeart1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.ListBox listBox1;
    
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

