namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Detailpenumpang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detailpenumpang));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            label10 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            pictureBox4 = new PictureBox();
            label13 = new Label();
            label15 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(28, 46);
            button1.Name = "button1";
            button1.Size = new Size(48, 30);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 46);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 29;
            label1.Text = "Detail Penumpang";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 86);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 30;
            label2.Text = "Mohon diisi data semua penumpang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 147);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 31;
            label3.Text = "Penumpang #1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 191);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 32;
            label4.Text = "Titel";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(243, 23);
            comboBox1.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 249);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 34;
            label5.Text = "Nama Lengkap";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 23);
            textBox1.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(121, 284);
            label6.Name = "label6";
            label6.Size = new Size(344, 15);
            label6.TabIndex = 36;
            label6.Text = "Isi sesuai dengan KTP/PASPOR/SIM(Tanpa tanda baca dan gelar)";
            // 
            // panel1
            // 
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(530, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 545);
            panel1.TabIndex = 37;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(13, 478);
            button3.Name = "button3";
            button3.Size = new Size(335, 33);
            button3.TabIndex = 50;
            button3.Text = "Konfirmasi Pembayaran ";
            button3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(8, 437);
            label10.Name = "label10";
            label10.Size = new Size(135, 20);
            label10.TabIndex = 49;
            label10.Text = "Total Pembayaran";
            // 
            // button2
            // 
            button2.Location = new Point(253, 348);
            button2.Name = "button2";
            button2.Size = new Size(82, 33);
            button2.TabIndex = 48;
            button2.Text = "Pakai";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 354);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 23);
            textBox2.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 319);
            label9.Name = "label9";
            label9.Size = new Size(84, 17);
            label9.TabIndex = 46;
            label9.Text = "Kode Promo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 131);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 45;
            label8.Text = "Detail Penerbangan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 30);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 44;
            label7.Text = "Penerbangan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 33);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 33);
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(204, 429);
            label11.Name = "label11";
            label11.Size = new Size(130, 30);
            label11.TabIndex = 54;
            label11.Text = "IDR 685.000";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(121, 59);
            label12.Name = "label12";
            label12.Size = new Size(124, 15);
            label12.TabIndex = 57;
            label12.Text = "Soekarno -Hatta(CGK)";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(92, 59);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 18);
            pictureBox4.TabIndex = 56;
            pictureBox4.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(8, 59);
            label13.Name = "label13";
            label13.Size = new Size(78, 15);
            label13.TabIndex = 55;
            label13.Text = "Juanda (SUB)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(8, 87);
            label15.Name = "label15";
            label15.Size = new Size(98, 15);
            label15.TabIndex = 58;
            label15.Text = "Pelita Air Service ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(61, 163);
            label14.Name = "label14";
            label14.Size = new Size(109, 15);
            label14.TabIndex = 59;
            label14.Text = "Mon, 22 May 2023";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(64, 215);
            label16.Name = "label16";
            label16.Size = new Size(71, 15);
            label16.TabIndex = 60;
            label16.Text = "19:50-21:15 ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(64, 258);
            label17.Name = "label17";
            label17.Size = new Size(80, 15);
            label17.TabIndex = 61;
            label17.Text = "1 Penumpang";
            // 
            // Detailpenumpang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(898, 547);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Detailpenumpang";
            Text = "Detailpenumpang";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private Panel panel1;
        private Button button3;
        private Label label8;
        private Label label10;
        private Label label7;
        private Button button2;
        private Label label9;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox4;
        private Label label13;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label17;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}