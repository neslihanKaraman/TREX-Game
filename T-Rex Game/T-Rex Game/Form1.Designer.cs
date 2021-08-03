
namespace T_Rex_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kaktüs2 = new System.Windows.Forms.PictureBox();
            this.kaktüs1 = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.arkaPlan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktüs2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktüs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(783, 43);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(105, 20);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "Score: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(992, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "HI: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 27;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1183, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kaktüs2
            // 
            this.kaktüs2.Image = global::T_Rex_Game.Properties.Resources.engel2;
            this.kaktüs2.Location = new System.Drawing.Point(728, 339);
            this.kaktüs2.Name = "kaktüs2";
            this.kaktüs2.Size = new System.Drawing.Size(32, 33);
            this.kaktüs2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kaktüs2.TabIndex = 3;
            this.kaktüs2.TabStop = false;
            this.kaktüs2.Tag = "engel";
            // 
            // kaktüs1
            // 
            this.kaktüs1.Image = global::T_Rex_Game.Properties.Resources.engel1;
            this.kaktüs1.Location = new System.Drawing.Point(504, 326);
            this.kaktüs1.Name = "kaktüs1";
            this.kaktüs1.Size = new System.Drawing.Size(23, 46);
            this.kaktüs1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kaktüs1.TabIndex = 2;
            this.kaktüs1.TabStop = false;
            this.kaktüs1.Tag = "engel";
            // 
            // trex
            // 
            this.trex.Image = global::T_Rex_Game.Properties.Resources.blue_trex;
            this.trex.Location = new System.Drawing.Point(84, 328);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(40, 43);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            // 
            // arkaPlan
            // 
            this.arkaPlan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.arkaPlan.Image = global::T_Rex_Game.Properties.Resources.beyaz_arkaPlan;
            this.arkaPlan.Location = new System.Drawing.Point(-1, -2);
            this.arkaPlan.Name = "arkaPlan";
            this.arkaPlan.Size = new System.Drawing.Size(1183, 451);
            this.arkaPlan.TabIndex = 4;
            this.arkaPlan.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1182, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kaktüs2);
            this.Controls.Add(this.kaktüs1);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.arkaPlan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Rex Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktüs2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaktüs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkaPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox trex;
        private System.Windows.Forms.PictureBox kaktüs1;
        private System.Windows.Forms.PictureBox kaktüs2;
        private System.Windows.Forms.PictureBox arkaPlan;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer gameTimer;
    }
}

