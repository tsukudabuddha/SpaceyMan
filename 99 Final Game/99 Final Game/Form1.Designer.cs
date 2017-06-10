namespace _99_Final_Game
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
            this.person = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rock = new System.Windows.Forms.PictureBox();
            this.rock1 = new System.Windows.Forms.PictureBox();
            this.rock2 = new System.Windows.Forms.PictureBox();
            this.rock3 = new System.Windows.Forms.PictureBox();
            this.rock4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).BeginInit();
            this.SuspendLayout();
            // 
            // person
            // 
            this.person.Image = ((System.Drawing.Image)(resources.GetObject("person.Image")));
            this.person.Location = new System.Drawing.Point(26, 394);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(36, 69);
            this.person.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.person.TabIndex = 0;
            this.person.TabStop = false;
            this.person.Click += new System.EventHandler(this.person_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rock
            // 
            this.rock.Image = ((System.Drawing.Image)(resources.GetObject("rock.Image")));
            this.rock.Location = new System.Drawing.Point(536, 12);
            this.rock.Margin = new System.Windows.Forms.Padding(0);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(82, 82);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 1;
            this.rock.TabStop = false;
            // 
            // rock1
            // 
            this.rock1.Image = ((System.Drawing.Image)(resources.GetObject("rock1.Image")));
            this.rock1.Location = new System.Drawing.Point(536, 103);
            this.rock1.Name = "rock1";
            this.rock1.Size = new System.Drawing.Size(82, 82);
            this.rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock1.TabIndex = 2;
            this.rock1.TabStop = false;
            // 
            // rock2
            // 
            this.rock2.Image = ((System.Drawing.Image)(resources.GetObject("rock2.Image")));
            this.rock2.Location = new System.Drawing.Point(536, 200);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(82, 82);
            this.rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock2.TabIndex = 3;
            this.rock2.TabStop = false;
            // 
            // rock3
            // 
            this.rock3.Image = ((System.Drawing.Image)(resources.GetObject("rock3.Image")));
            this.rock3.Location = new System.Drawing.Point(536, 297);
            this.rock3.Name = "rock3";
            this.rock3.Size = new System.Drawing.Size(82, 82);
            this.rock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock3.TabIndex = 4;
            this.rock3.TabStop = false;
            // 
            // rock4
            // 
            this.rock4.Image = ((System.Drawing.Image)(resources.GetObject("rock4.Image")));
            this.rock4.Location = new System.Drawing.Point(536, 394);
            this.rock4.Name = "rock4";
            this.rock4.Size = new System.Drawing.Size(82, 82);
            this.rock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock4.TabIndex = 5;
            this.rock4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(2, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score: 0";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 2);
            this.progressBar1.Maximum = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(639, 10);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(648, 490);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rock4);
            this.Controls.Add(this.rock3);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.person);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Round 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.person)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox person;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox rock1;
        private System.Windows.Forms.PictureBox rock2;
        private System.Windows.Forms.PictureBox rock3;
        private System.Windows.Forms.PictureBox rock4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

