namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Listpenerbangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listpenerbangan));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 25;
            label1.Text = "List Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-9, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(813, 287);
            dataGridView1.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(11, 9);
            button1.Name = "button1";
            button1.Size = new Size(53, 30);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(611, 188);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // button2
            // 
            button2.Location = new Point(310, 113);
            button2.Name = "button2";
            button2.Size = new Size(190, 33);
            button2.TabIndex = 43;
            button2.Text = "Terapkan Filter ";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 92);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 41;
            label3.Text = "Urutkan Berdasarkan";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(336, 51);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(91, 19);
            checkBox4.TabIndex = 40;
            checkBox4.Text = "18:00 - 24:00";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(229, 51);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(91, 19);
            checkBox3.TabIndex = 39;
            checkBox3.Text = "12:00 - 18:00";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(119, 51);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 19);
            checkBox2.TabIndex = 38;
            checkBox2.Text = "06:00 - 12:00";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(11, 52);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 19);
            checkBox1.TabIndex = 37;
            checkBox1.Text = "00:00 - 06:00";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 36;
            label2.Text = "Waktu Keberangkatan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 53);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 37;
            label4.Text = "Juanda (SUB)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(154, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 18);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(183, 53);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 44;
            label5.Text = "Soekarno -Hatta(CGK)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(346, 53);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 45;
            label6.Text = "Mon, 22 May 2023";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(493, 53);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 46;
            label7.Text = "1 Penumpang";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(460, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 24);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(313, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 24);
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // Listpenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 588);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Listpenerbangan";
            Text = "Listpenerbangan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private ComboBox comboBox1;
        private Label label3;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}