namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            panel1 = new Panel();
            button6 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(button6);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 68);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Info;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-2, -2);
            button6.Name = "button6";
            button6.Size = new Size(224, 77);
            button6.TabIndex = 3;
            button6.Text = "Dashboard";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(2, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 526);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 436);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 32);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.Location = new Point(57, 445);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Logout";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.InfoText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 286);
            button5.Name = "button5";
            button5.Size = new Size(219, 61);
            button5.TabIndex = 6;
            button5.Text = "Ubah Status Penerbangan ";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.InfoText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 219);
            button4.Name = "button4";
            button4.Size = new Size(219, 61);
            button4.TabIndex = 5;
            button4.Text = "Master Kode Promo  ";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.InfoText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 152);
            button3.Name = "button3";
            button3.Size = new Size(219, 61);
            button3.TabIndex = 4;
            button3.Text = " Jadwal Penerbangan ";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.InfoText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 81);
            button2.Name = "button2";
            button2.Size = new Size(219, 61);
            button2.TabIndex = 3;
            button2.Text = " Master Maskapai";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.InfoText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 14);
            button1.Name = "button1";
            button1.Size = new Size(219, 61);
            button1.TabIndex = 2;
            button1.Text = "Master Bandara ";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(802, 593);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}