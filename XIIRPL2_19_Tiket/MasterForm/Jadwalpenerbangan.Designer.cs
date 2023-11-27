namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Jadwalpenerbangan
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            dari = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            ke = new ComboBox();
            label4 = new Label();
            maskapai = new ComboBox();
            label5 = new Label();
            tanggal = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            harga = new NumericUpDown();
            button2 = new Button();
            button1 = new Button();
            kode = new TextBox();
            durasi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)harga).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(130, 60);
            label2.Name = "label2";
            label2.Size = new Size(297, 17);
            label2.TabIndex = 22;
            label2.Text = "Semua jadwal penerbangan akan muncul disini ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 21);
            label1.Name = "label1";
            label1.Size = new Size(288, 30);
            label1.TabIndex = 21;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { edit, delete });
            dataGridView1.Location = new Point(57, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(782, 229);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // edit
            // 
            edit.HeaderText = "Edit";
            edit.Name = "edit";
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            delete.HeaderText = "Delete";
            delete.Name = "delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            // 
            // dari
            // 
            dari.FormattingEnabled = true;
            dari.Location = new Point(195, 424);
            dari.Name = "dari";
            dari.Size = new Size(234, 23);
            dari.TabIndex = 25;
            dari.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(58, 425);
            label6.Name = "label6";
            label6.Size = new Size(35, 17);
            label6.TabIndex = 24;
            label6.Text = "Dari:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 368);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 23;
            label3.Text = "Kode Penerbangan: ";
            label3.Click += label3_Click;
            // 
            // ke
            // 
            ke.FormattingEnabled = true;
            ke.Location = new Point(195, 470);
            ke.Name = "ke";
            ke.Size = new Size(234, 23);
            ke.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(58, 471);
            label4.Name = "label4";
            label4.Size = new Size(26, 17);
            label4.TabIndex = 27;
            label4.Text = "Ke:";
            label4.Click += label4_Click;
            // 
            // maskapai
            // 
            maskapai.FormattingEnabled = true;
            maskapai.Location = new Point(195, 512);
            maskapai.Name = "maskapai";
            maskapai.Size = new Size(234, 23);
            maskapai.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 513);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 29;
            label5.Text = "Maskapai:";
            // 
            // tanggal
            // 
            tanggal.Location = new Point(626, 368);
            tanggal.Name = "tanggal";
            tanggal.Size = new Size(240, 23);
            tanggal.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(482, 368);
            label7.Name = "label7";
            label7.Size = new Size(62, 17);
            label7.TabIndex = 32;
            label7.Text = "Tanggal: ";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(482, 425);
            label8.Name = "label8";
            label8.Size = new Size(0, 17);
            label8.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(482, 428);
            label9.Name = "label9";
            label9.Size = new Size(138, 17);
            label9.TabIndex = 34;
            label9.Text = "Durasi Penerbangan: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(482, 470);
            label10.Name = "label10";
            label10.Size = new Size(109, 17);
            label10.TabIndex = 35;
            label10.Text = " Harga per Tiket:";
            // 
            // harga
            // 
            harga.Location = new Point(626, 470);
            harga.Name = "harga";
            harga.Size = new Size(234, 23);
            harga.TabIndex = 36;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(672, 581);
            button2.Name = "button2";
            button2.Size = new Size(98, 38);
            button2.TabIndex = 38;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(557, 581);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 37;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // kode
            // 
            kode.Location = new Point(195, 367);
            kode.Multiline = true;
            kode.Name = "kode";
            kode.Size = new Size(234, 34);
            kode.TabIndex = 39;
            // 
            // durasi
            // 
            durasi.Location = new Point(626, 427);
            durasi.Multiline = true;
            durasi.Name = "durasi";
            durasi.Size = new Size(234, 32);
            durasi.TabIndex = 41;
            // 
            // Jadwalpenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 631);
            Controls.Add(durasi);
            Controls.Add(kode);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(harga);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tanggal);
            Controls.Add(maskapai);
            Controls.Add(label5);
            Controls.Add(ke);
            Controls.Add(label4);
            Controls.Add(dari);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Jadwalpenerbangan";
            Text = "Jadwalpenerbangan";
            Load += Jadwalpenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)harga).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox dari;
        private Label label6;
        private Label label3;
        private ComboBox ke;
        private Label label4;
        private ComboBox maskapai;
        private Label label5;
        private DateTimePicker tanggal;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown harga;
        private Button button2;
        private Button button1;
        private TextBox kode;
        private TextBox durasi;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}