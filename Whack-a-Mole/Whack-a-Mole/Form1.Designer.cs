namespace Whack_a_Mole
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
            this.m1 = new System.Windows.Forms.PictureBox();
            this.m2 = new System.Windows.Forms.PictureBox();
            this.m3 = new System.Windows.Forms.PictureBox();
            this.m8 = new System.Windows.Forms.PictureBox();
            this.m9 = new System.Windows.Forms.PictureBox();
            this.m10 = new System.Windows.Forms.PictureBox();
            this.m4 = new System.Windows.Forms.PictureBox();
            this.m5 = new System.Windows.Forms.PictureBox();
            this.m6 = new System.Windows.Forms.PictureBox();
            this.m7 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMissed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m7)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m1
            // 
            this.m1.BackColor = System.Drawing.Color.Transparent;
            this.m1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m1.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m1.Location = new System.Drawing.Point(171, 96);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(104, 84);
            this.m1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m1.TabIndex = 0;
            this.m1.TabStop = false;
            this.m1.Click += new System.EventHandler(this.moleClick);
            // 
            // m2
            // 
            this.m2.BackColor = System.Drawing.Color.Transparent;
            this.m2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m2.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m2.Location = new System.Drawing.Point(422, 96);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(104, 84);
            this.m2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m2.TabIndex = 1;
            this.m2.TabStop = false;
            this.m2.Click += new System.EventHandler(this.moleClick);
            // 
            // m3
            // 
            this.m3.BackColor = System.Drawing.Color.Transparent;
            this.m3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m3.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m3.Location = new System.Drawing.Point(672, 96);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(104, 84);
            this.m3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m3.TabIndex = 2;
            this.m3.TabStop = false;
            this.m3.Click += new System.EventHandler(this.moleClick);
            // 
            // m8
            // 
            this.m8.BackColor = System.Drawing.Color.Transparent;
            this.m8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m8.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m8.Location = new System.Drawing.Point(130, 350);
            this.m8.Name = "m8";
            this.m8.Size = new System.Drawing.Size(163, 161);
            this.m8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m8.TabIndex = 3;
            this.m8.TabStop = false;
            this.m8.Click += new System.EventHandler(this.moleClick);
            // 
            // m9
            // 
            this.m9.BackColor = System.Drawing.Color.Transparent;
            this.m9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m9.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m9.Location = new System.Drawing.Point(393, 350);
            this.m9.Name = "m9";
            this.m9.Size = new System.Drawing.Size(163, 161);
            this.m9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m9.TabIndex = 4;
            this.m9.TabStop = false;
            this.m9.Click += new System.EventHandler(this.moleClick);
            // 
            // m10
            // 
            this.m10.BackColor = System.Drawing.Color.Transparent;
            this.m10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m10.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m10.Location = new System.Drawing.Point(648, 350);
            this.m10.Name = "m10";
            this.m10.Size = new System.Drawing.Size(163, 161);
            this.m10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m10.TabIndex = 5;
            this.m10.TabStop = false;
            this.m10.Click += new System.EventHandler(this.moleClick);
            // 
            // m4
            // 
            this.m4.BackColor = System.Drawing.Color.Transparent;
            this.m4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m4.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m4.Location = new System.Drawing.Point(106, 195);
            this.m4.Name = "m4";
            this.m4.Size = new System.Drawing.Size(125, 115);
            this.m4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m4.TabIndex = 6;
            this.m4.TabStop = false;
            this.m4.Click += new System.EventHandler(this.moleClick);
            // 
            // m5
            // 
            this.m5.BackColor = System.Drawing.Color.Transparent;
            this.m5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m5.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m5.Location = new System.Drawing.Point(308, 195);
            this.m5.Name = "m5";
            this.m5.Size = new System.Drawing.Size(125, 115);
            this.m5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m5.TabIndex = 7;
            this.m5.TabStop = false;
            this.m5.Click += new System.EventHandler(this.moleClick);
            // 
            // m6
            // 
            this.m6.BackColor = System.Drawing.Color.Transparent;
            this.m6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m6.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m6.Location = new System.Drawing.Point(512, 195);
            this.m6.Name = "m6";
            this.m6.Size = new System.Drawing.Size(125, 115);
            this.m6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m6.TabIndex = 8;
            this.m6.TabStop = false;
            this.m6.Click += new System.EventHandler(this.moleClick);
            // 
            // m7
            // 
            this.m7.BackColor = System.Drawing.Color.Transparent;
            this.m7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m7.Image = global::Whack_a_Mole.Properties.Resources.mole;
            this.m7.Location = new System.Drawing.Point(716, 195);
            this.m7.Name = "m7";
            this.m7.Size = new System.Drawing.Size(125, 115);
            this.m7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m7.TabIndex = 9;
            this.m7.TabStop = false;
            this.m7.Click += new System.EventHandler(this.moleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblMissed);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblHit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 640);
            this.panel1.TabIndex = 10;
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissed.ForeColor = System.Drawing.Color.White;
            this.lblMissed.Location = new System.Drawing.Point(553, 527);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(53, 52);
            this.lblMissed.TabIndex = 5;
            this.lblMissed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 52);
            this.label4.TabIndex = 4;
            this.label4.Text = "Missed:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(795, 527);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 52);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(639, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHit.ForeColor = System.Drawing.Color.White;
            this.lblHit.Location = new System.Drawing.Point(264, 527);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(53, 52);
            this.lblHit.TabIndex = 1;
            this.lblHit.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Whacked:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 58);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblExit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 58);
            this.panel2.TabIndex = 7;
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblExit.Font = new System.Drawing.Font("Moire", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(500, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(438, 58);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Whack_a_Mole.Properties.Resources.scene;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 640);
            this.Controls.Add(this.m7);
            this.Controls.Add(this.m6);
            this.Controls.Add(this.m5);
            this.Controls.Add(this.m4);
            this.Controls.Add(this.m10);
            this.Controls.Add(this.m9);
            this.Controls.Add(this.m8);
            this.Controls.Add(this.m3);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(982, 687);
            this.MinimumSize = new System.Drawing.Size(982, 687);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whack-a-Mole";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m1;
        private System.Windows.Forms.PictureBox m2;
        private System.Windows.Forms.PictureBox m3;
        private System.Windows.Forms.PictureBox m8;
        private System.Windows.Forms.PictureBox m9;
        private System.Windows.Forms.PictureBox m10;
        private System.Windows.Forms.PictureBox m4;
        private System.Windows.Forms.PictureBox m5;
        private System.Windows.Forms.PictureBox m6;
        private System.Windows.Forms.PictureBox m7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExit;
    }
}

