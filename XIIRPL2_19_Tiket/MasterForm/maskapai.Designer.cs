namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class maskapai
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
            txtjumlahkru = new NumericUpDown();
            label8 = new Label();
            txtdesk = new TextBox();
            label7 = new Label();
            txtnama = new TextBox();
            txtperusahaan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)txtjumlahkru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtjumlahkru
            // 
            txtjumlahkru.Location = new Point(170, 470);
            txtjumlahkru.Name = "txtjumlahkru";
            txtjumlahkru.Size = new Size(234, 23);
            txtjumlahkru.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(458, 354);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 26;
            label8.Text = "Deskripsi: ";
            label8.Click += label8_Click;
            // 
            // txtdesk
            // 
            txtdesk.Location = new Point(533, 354);
            txtdesk.Multiline = true;
            txtdesk.Name = "txtdesk";
            txtdesk.Size = new Size(255, 133);
            txtdesk.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(78, 470);
            label7.Name = "label7";
            label7.Size = new Size(83, 17);
            label7.TabIndex = 24;
            label7.Text = "Jumlah Kru: ";
            // 
            // txtnama
            // 
            txtnama.Location = new Point(170, 354);
            txtnama.Multiline = true;
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(234, 34);
            txtnama.TabIndex = 23;
            txtnama.TextChanged += txtnama_TextChanged;
            // 
            // txtperusahaan
            // 
            txtperusahaan.Location = new Point(170, 413);
            txtperusahaan.Multiline = true;
            txtperusahaan.Name = "txtperusahaan";
            txtperusahaan.Size = new Size(234, 34);
            txtperusahaan.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(78, 414);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 21;
            label4.Text = "Perusahaan: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(78, 355);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 20;
            label3.Text = "Nama: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(149, 57);
            label2.Name = "label2";
            label2.Size = new Size(318, 17);
            label2.TabIndex = 19;
            label2.Text = "Semua Bandara yang terdaftar akan muncul kesini ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 18);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 18;
            label1.Text = "Master Maskapai";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { edit, delete });
            dataGridView1.Location = new Point(76, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(634, 219);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(672, 515);
            button2.Name = "button2";
            button2.Size = new Size(98, 38);
            button2.TabIndex = 29;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(557, 515);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 28;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
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
            // maskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtjumlahkru);
            Controls.Add(label8);
            Controls.Add(txtdesk);
            Controls.Add(label7);
            Controls.Add(txtnama);
            Controls.Add(txtperusahaan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "maskapai";
            Text = "maskapai";
            Load += maskapai_Load;
            ((System.ComponentModel.ISupportInitialize)txtjumlahkru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown txtjumlahkru;
        private Label label8;
        private TextBox txtdesk;
        private Label label7;
        private TextBox txtnama;
        private TextBox txtperusahaan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}