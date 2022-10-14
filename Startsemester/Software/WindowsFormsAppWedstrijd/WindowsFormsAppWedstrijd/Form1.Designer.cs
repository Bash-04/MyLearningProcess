namespace WindowsFormsAppWedstrijd
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pbMainDeck = new System.Windows.Forms.PictureBox();
            this.pbDealtCards = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDealtCards = new System.Windows.Forms.Label();
            this.lblMainDeck = new System.Windows.Forms.Label();
            this.pbFirstDealerCard = new System.Windows.Forms.PictureBox();
            this.pbSecondDealerCard = new System.Windows.Forms.PictureBox();
            this.pbFirstPlayerCard = new System.Windows.Forms.PictureBox();
            this.pbSecondPlayerCard = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbDealer = new System.Windows.Forms.ListBox();
            this.lbPlayer = new System.Windows.Forms.ListBox();
            this.btnrestart = new System.Windows.Forms.Button();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealtCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstDealerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondDealerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstPlayerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondPlayerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEALER";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(241, 416);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(81, 22);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "PLAYER";
            // 
            // pbMainDeck
            // 
            this.pbMainDeck.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pbMainDeck.Location = new System.Drawing.Point(12, 28);
            this.pbMainDeck.Name = "pbMainDeck";
            this.pbMainDeck.Size = new System.Drawing.Size(120, 171);
            this.pbMainDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainDeck.TabIndex = 2;
            this.pbMainDeck.TabStop = false;
            // 
            // pbDealtCards
            // 
            this.pbDealtCards.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pbDealtCards.Location = new System.Drawing.Point(12, 251);
            this.pbDealtCards.Name = "pbDealtCards";
            this.pbDealtCards.Size = new System.Drawing.Size(120, 171);
            this.pbDealtCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDealtCards.TabIndex = 3;
            this.pbDealtCards.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Main Deck";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dealt Cards";
            // 
            // lblDealtCards
            // 
            this.lblDealtCards.AutoSize = true;
            this.lblDealtCards.Location = new System.Drawing.Point(52, 425);
            this.lblDealtCards.Name = "lblDealtCards";
            this.lblDealtCards.Size = new System.Drawing.Size(38, 16);
            this.lblDealtCards.TabIndex = 6;
            this.lblDealtCards.Text = "0 / 52";
            // 
            // lblMainDeck
            // 
            this.lblMainDeck.AutoSize = true;
            this.lblMainDeck.Location = new System.Drawing.Point(52, 202);
            this.lblMainDeck.Name = "lblMainDeck";
            this.lblMainDeck.Size = new System.Drawing.Size(45, 16);
            this.lblMainDeck.TabIndex = 7;
            this.lblMainDeck.Text = "52 / 52";
            // 
            // pbFirstDealerCard
            // 
            this.pbFirstDealerCard.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pbFirstDealerCard.Location = new System.Drawing.Point(177, 62);
            this.pbFirstDealerCard.Name = "pbFirstDealerCard";
            this.pbFirstDealerCard.Size = new System.Drawing.Size(96, 137);
            this.pbFirstDealerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstDealerCard.TabIndex = 8;
            this.pbFirstDealerCard.TabStop = false;
            // 
            // pbSecondDealerCard
            // 
            this.pbSecondDealerCard.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pbSecondDealerCard.Location = new System.Drawing.Point(207, 62);
            this.pbSecondDealerCard.Name = "pbSecondDealerCard";
            this.pbSecondDealerCard.Size = new System.Drawing.Size(96, 137);
            this.pbSecondDealerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecondDealerCard.TabIndex = 9;
            this.pbSecondDealerCard.TabStop = false;
            // 
            // pbFirstPlayerCard
            // 
            this.pbFirstPlayerCard.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pbFirstPlayerCard.Location = new System.Drawing.Point(177, 251);
            this.pbFirstPlayerCard.Name = "pbFirstPlayerCard";
            this.pbFirstPlayerCard.Size = new System.Drawing.Size(96, 137);
            this.pbFirstPlayerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirstPlayerCard.TabIndex = 10;
            this.pbFirstPlayerCard.TabStop = false;
            // 
            // pbSecondPlayerCard
            // 
            this.pbSecondPlayerCard.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pbSecondPlayerCard.Location = new System.Drawing.Point(207, 251);
            this.pbSecondPlayerCard.Name = "pbSecondPlayerCard";
            this.pbSecondPlayerCard.Size = new System.Drawing.Size(96, 137);
            this.pbSecondPlayerCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSecondPlayerCard.TabIndex = 11;
            this.pbSecondPlayerCard.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(800, 450);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbDealer
            // 
            this.lbDealer.FormattingEnabled = true;
            this.lbDealer.ItemHeight = 16;
            this.lbDealer.Location = new System.Drawing.Point(440, 62);
            this.lbDealer.Name = "lbDealer";
            this.lbDealer.Size = new System.Drawing.Size(120, 84);
            this.lbDealer.TabIndex = 13;
            this.lbDealer.SelectedIndexChanged += new System.EventHandler(this.lbDealer_SelectedIndexChanged);
            // 
            // lbPlayer
            // 
            this.lbPlayer.FormattingEnabled = true;
            this.lbPlayer.ItemHeight = 16;
            this.lbPlayer.Location = new System.Drawing.Point(440, 304);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(120, 84);
            this.lbPlayer.TabIndex = 14;
            this.lbPlayer.SelectedIndexChanged += new System.EventHandler(this.lbPlayer_SelectedIndexChanged);
            // 
            // btnrestart
            // 
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.Location = new System.Drawing.Point(609, 62);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(140, 36);
            this.btnrestart.TabIndex = 15;
            this.btnrestart.Text = "RESTART";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.Location = new System.Drawing.Point(437, 149);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(123, 23);
            this.lblDealerTotal.TabIndex = 16;
            this.lblDealerTotal.Text = "Total: ";
            this.lblDealerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDealerTotal.Click += new System.EventHandler(this.lblDealerTotal_Click);
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.Location = new System.Drawing.Point(437, 391);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(123, 23);
            this.lblPlayerTotal.TabIndex = 17;
            this.lblPlayerTotal.Text = "Total: ";
            this.lblPlayerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlayerTotal.Click += new System.EventHandler(this.lblPlayerTotal_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(609, 278);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(140, 36);
            this.btnHit.TabIndex = 18;
            this.btnHit.Text = "HIT";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(609, 328);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(140, 36);
            this.btnDouble.TabIndex = 19;
            this.btnDouble.Text = "DOUBLE";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(609, 378);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(140, 36);
            this.btnSplit.TabIndex = 20;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(609, 228);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(140, 36);
            this.btnStand.TabIndex = 21;
            this.btnStand.Text = "STAND";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pictureBox1.Location = new System.Drawing.Point(237, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pictureBox2.Location = new System.Drawing.Point(237, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pictureBox3.Location = new System.Drawing.Point(267, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(96, 137);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pictureBox4.Location = new System.Drawing.Point(267, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 137);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pictureBox5.Location = new System.Drawing.Point(297, 251);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(96, 137);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsAppWedstrijd.Properties.Resources._7213e1a55a3c0c73d5864e14ba1aa7dc;
            this.pictureBox6.Location = new System.Drawing.Point(297, 62);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(96, 137);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.lbDealer);
            this.Controls.Add(this.pbSecondPlayerCard);
            this.Controls.Add(this.pbFirstPlayerCard);
            this.Controls.Add(this.pbSecondDealerCard);
            this.Controls.Add(this.pbFirstDealerCard);
            this.Controls.Add(this.lblMainDeck);
            this.Controls.Add(this.lblDealtCards);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbDealtCards);
            this.Controls.Add(this.pbMainDeck);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMainDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDealtCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstDealerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondDealerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirstPlayerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecondPlayerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox pbMainDeck;
        private System.Windows.Forms.PictureBox pbDealtCards;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDealtCards;
        private System.Windows.Forms.Label lblMainDeck;
        private System.Windows.Forms.PictureBox pbFirstDealerCard;
        private System.Windows.Forms.PictureBox pbSecondDealerCard;
        private System.Windows.Forms.PictureBox pbFirstPlayerCard;
        private System.Windows.Forms.PictureBox pbSecondPlayerCard;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbDealer;
        private System.Windows.Forms.ListBox lbPlayer;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

