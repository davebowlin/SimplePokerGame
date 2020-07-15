namespace Poker_Game
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelBet = new System.Windows.Forms.Panel();
            this.buttonPass = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.buttonTwenty = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.panelMoney = new System.Windows.Forms.Panel();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.picTransparent = new System.Windows.Forms.PictureBox();
            this.genericTimer = new System.Windows.Forms.Timer(this.components);
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelBet.SuspendLayout();
            this.panelMoney.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransparent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBet
            // 
            this.panelBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBet.Controls.Add(this.buttonPass);
            this.panelBet.Controls.Add(this.buttonMax);
            this.panelBet.Controls.Add(this.button100);
            this.panelBet.Controls.Add(this.buttonTwenty);
            this.panelBet.Controls.Add(this.buttonFive);
            this.panelBet.Controls.Add(this.buttonOne);
            this.panelBet.Location = new System.Drawing.Point(300, 449);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(472, 100);
            this.panelBet.TabIndex = 3;
            // 
            // buttonPass
            // 
            this.buttonPass.BackColor = System.Drawing.Color.Transparent;
            this.buttonPass.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.buttonPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPass.ForeColor = System.Drawing.Color.Silver;
            this.buttonPass.Location = new System.Drawing.Point(18, 25);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(57, 46);
            this.buttonPass.TabIndex = 14;
            this.buttonPass.Text = "Pass";
            this.buttonPass.UseVisualStyleBackColor = false;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.BackColor = System.Drawing.Color.Transparent;
            this.buttonMax.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonMax.FlatAppearance.BorderSize = 2;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMax.ForeColor = System.Drawing.Color.White;
            this.buttonMax.Location = new System.Drawing.Point(393, 25);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(57, 46);
            this.buttonMax.TabIndex = 13;
            this.buttonMax.Text = "MAX";
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // button100
            // 
            this.button100.BackColor = System.Drawing.Color.Transparent;
            this.button100.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button100.FlatAppearance.BorderSize = 2;
            this.button100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button100.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button100.ForeColor = System.Drawing.Color.White;
            this.button100.Location = new System.Drawing.Point(318, 25);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(57, 46);
            this.button100.TabIndex = 12;
            this.button100.Text = "$100";
            this.button100.UseVisualStyleBackColor = false;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // buttonTwenty
            // 
            this.buttonTwenty.BackColor = System.Drawing.Color.Transparent;
            this.buttonTwenty.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonTwenty.FlatAppearance.BorderSize = 2;
            this.buttonTwenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwenty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwenty.ForeColor = System.Drawing.Color.White;
            this.buttonTwenty.Location = new System.Drawing.Point(243, 25);
            this.buttonTwenty.Name = "buttonTwenty";
            this.buttonTwenty.Size = new System.Drawing.Size(57, 46);
            this.buttonTwenty.TabIndex = 11;
            this.buttonTwenty.Text = "$20";
            this.buttonTwenty.UseVisualStyleBackColor = false;
            this.buttonTwenty.Click += new System.EventHandler(this.buttonTwenty_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.Transparent;
            this.buttonFive.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.buttonFive.FlatAppearance.BorderSize = 2;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.ForeColor = System.Drawing.Color.White;
            this.buttonFive.Location = new System.Drawing.Point(168, 25);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(57, 46);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.Text = "$5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.Transparent;
            this.buttonOne.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonOne.FlatAppearance.BorderSize = 2;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.ForeColor = System.Drawing.Color.White;
            this.buttonOne.Location = new System.Drawing.Point(93, 25);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(57, 46);
            this.buttonOne.TabIndex = 9;
            this.buttonOne.Text = "$1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // panelMoney
            // 
            this.panelMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMoney.Controls.Add(this.labelBet);
            this.panelMoney.Controls.Add(this.labelHouse);
            this.panelMoney.Controls.Add(this.labelPlayer);
            this.panelMoney.Controls.Add(this.label3);
            this.panelMoney.Controls.Add(this.label2);
            this.panelMoney.Controls.Add(this.label1);
            this.panelMoney.Controls.Add(this.buttonNewGame);
            this.panelMoney.Controls.Add(this.buttonShuffle);
            this.panelMoney.Controls.Add(this.buttonDeal);
            this.panelMoney.Location = new System.Drawing.Point(12, 449);
            this.panelMoney.Name = "panelMoney";
            this.panelMoney.Size = new System.Drawing.Size(282, 100);
            this.panelMoney.TabIndex = 4;
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.ForeColor = System.Drawing.Color.White;
            this.labelBet.Location = new System.Drawing.Point(84, 67);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(17, 18);
            this.labelBet.TabIndex = 10;
            this.labelBet.Text = "0";
            this.labelBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.ForeColor = System.Drawing.Color.DimGray;
            this.labelHouse.Location = new System.Drawing.Point(84, 39);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(17, 18);
            this.labelHouse.TabIndex = 9;
            this.labelHouse.Text = "0";
            this.labelHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.ForeColor = System.Drawing.Color.White;
            this.labelPlayer.Location = new System.Drawing.Point(83, 12);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(17, 18);
            this.labelPlayer.TabIndex = 8;
            this.labelPlayer.Text = "0";
            this.labelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bet: $";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "House: $";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player: $";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(183, 25);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 46);
            this.buttonNewGame.TabIndex = 4;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Location = new System.Drawing.Point(183, 25);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(75, 46);
            this.buttonShuffle.TabIndex = 3;
            this.buttonShuffle.Text = "Shuffle";
            this.buttonShuffle.UseVisualStyleBackColor = true;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // buttonDeal
            // 
            this.buttonDeal.Location = new System.Drawing.Point(183, 25);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(75, 46);
            this.buttonDeal.TabIndex = 2;
            this.buttonDeal.Text = "Deal";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelRemaining);
            this.panel1.Controls.Add(this.card2);
            this.panel1.Controls.Add(this.card3);
            this.panel1.Controls.Add(this.card1);
            this.panel1.Controls.Add(this.picTransparent);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 366);
            this.panel1.TabIndex = 9;
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.Transparent;
            this.card2.ErrorImage = null;
            this.card2.Location = new System.Drawing.Point(540, 35);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(166, 281);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 14;
            this.card2.TabStop = false;
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.Transparent;
            this.card3.Location = new System.Drawing.Point(295, 35);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(166, 281);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 13;
            this.card3.TabStop = false;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.Transparent;
            this.card1.Location = new System.Drawing.Point(50, 35);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(166, 281);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 12;
            this.card1.TabStop = false;
            // 
            // picTransparent
            // 
            this.picTransparent.BackColor = System.Drawing.Color.Transparent;
            this.picTransparent.Image = global::Poker_Game.Properties.Resources.transparent;
            this.picTransparent.Location = new System.Drawing.Point(3, 3);
            this.picTransparent.Name = "picTransparent";
            this.picTransparent.Size = new System.Drawing.Size(750, 354);
            this.picTransparent.TabIndex = 0;
            this.picTransparent.TabStop = false;
            // 
            // genericTimer
            // 
            this.genericTimer.Interval = 2000;
            this.genericTimer.Tick += new System.EventHandler(this.genericTimer_Tick);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Peru;
            this.labelStatus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(12, 381);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(760, 65);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Welcome to Poker Game :)";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.ForeColor = System.Drawing.Color.DimGray;
            this.labelRemaining.Location = new System.Drawing.Point(721, 329);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(17, 18);
            this.labelRemaining.TabIndex = 15;
            this.labelRemaining.Text = "0";
            this.labelRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(578, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cards remaining:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMoney);
            this.Controls.Add(this.panelBet);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker Game";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelBet.ResumeLayout(false);
            this.panelMoney.ResumeLayout(false);
            this.panelMoney.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransparent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.Panel panelMoney;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox picTransparent;
        private System.Windows.Forms.Timer genericTimer;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.Button buttonPass;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.Button buttonTwenty;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRemaining;
    }
}

