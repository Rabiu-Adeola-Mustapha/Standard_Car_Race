namespace Standard_Car_Race
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ai2 = new System.Windows.Forms.PictureBox();
            this.Ai1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ai2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.Explosion);
            this.panel1.Controls.Add(this.Ai2);
            this.panel1.Controls.Add(this.Ai1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 407);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.panel1_PreviewKeyDown);
            // 
            // Ai2
            // 
            this.Ai2.Image = global::Standard_Car_Race.Properties.Resources.ambulance;
            this.Ai2.Location = new System.Drawing.Point(345, 12);
            this.Ai2.Name = "Ai2";
            this.Ai2.Size = new System.Drawing.Size(36, 75);
            this.Ai2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai2.TabIndex = 14;
            this.Ai2.TabStop = false;
            this.Ai2.Tag = "CarRight";
            // 
            // Ai1
            // 
            this.Ai1.Image = global::Standard_Car_Race.Properties.Resources.CarRed;
            this.Ai1.Location = new System.Drawing.Point(46, 12);
            this.Ai1.Name = "Ai1";
            this.Ai1.Size = new System.Drawing.Size(33, 64);
            this.Ai1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai1.TabIndex = 13;
            this.Ai1.TabStop = false;
            this.Ai1.Tag = "CarLeft";
            this.Ai1.Click += new System.EventHandler(this.Ai1_Click);
            // 
            // player
            // 
            this.player.Image = global::Standard_Car_Race.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(134, 299);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(33, 66);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 12;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            this.player.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.player_PreviewKeyDown);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.White;
            this.pictureBox9.Location = new System.Drawing.Point(3, -1);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(10, 411);
            this.pictureBox9.TabIndex = 11;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(419, -1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 414);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(213, 319);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 87);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "MiddleRoadTrack";
            this.pictureBox4.Move += new System.EventHandler(this.pictureBox4_Move);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(213, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 78);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "MiddleRoadTrack";
            this.pictureBox3.Move += new System.EventHandler(this.pictureBox4_Move);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(213, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(6, 76);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "MiddleRoadTrack";
            this.pictureBox2.Move += new System.EventHandler(this.pictureBox4_Move);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(213, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "MiddleRoadTrack";
            this.pictureBox1.Move += new System.EventHandler(this.pictureBox4_Move);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(164, 436);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(-12, 409);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(434, 24);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Explosion
            // 
            this.Explosion.Image = global::Standard_Car_Race.Properties.Resources.explosion;
            this.Explosion.Location = new System.Drawing.Point(46, 182);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(64, 64);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Explosion.TabIndex = 15;
            this.Explosion.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::Standard_Car_Race.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(163, 173);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(124, 59);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 16;
            this.award.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ai2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Ai2;
        private System.Windows.Forms.PictureBox Ai1;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox award;
    }
}

