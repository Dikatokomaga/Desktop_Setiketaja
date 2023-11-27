namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Kodepromo
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
            label8 = new Label();
            txtdesk = new TextBox();
            label7 = new Label();
            txtpromo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtberlaku = new DateTimePicker();
            txtpresen = new NumericUpDown();
            txtmax = new NumericUpDown();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtpresen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtmax).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(107, 72);
            label2.Name = "label2";
            label2.Size = new Size(331, 17);
            label2.TabIndex = 25;
            label2.Text = "Semua kode promo yang tersedia akan muncul disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 33);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 24;
            label1.Text = "Master Kode Promo";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { edit, delete });
            dataGridView1.Location = new Point(34, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(847, 229);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(551, 368);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 32;
            label8.Text = "Deskripsi: ";
            // 
            // txtdesk
            // 
            txtdesk.Location = new Point(626, 368);
            txtdesk.Multiline = true;
            txtdesk.Name = "txtdesk";
            txtdesk.Size = new Size(255, 111);
            txtdesk.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(71, 495);
            label7.Name = "label7";
            label7.Size = new Size(126, 17);
            label7.TabIndex = 30;
            label7.Text = "Presentase Diskon: ";
            label7.Click += label7_Click;
            // 
            // txtpromo
            // 
            txtpromo.Location = new Point(204, 368);
            txtpromo.Multiline = true;
            txtpromo.Name = "txtpromo";
            txtpromo.Size = new Size(240, 34);
            txtpromo.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 369);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 28;
            label3.Text = "Kode Promo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 440);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 35;
            label4.Text = "Berlaku sampai: ";
            label4.Click += label4_Click;
            // 
            // txtberlaku
            // 
            txtberlaku.Location = new Point(204, 440);
            txtberlaku.Name = "txtberlaku";
            txtberlaku.Size = new Size(240, 23);
            txtberlaku.TabIndex = 34;
            // 
            // txtpresen
            // 
            txtpresen.Location = new Point(204, 495);
            txtpresen.Name = "txtpresen";
            txtpresen.Size = new Size(240, 23);
            txtpresen.TabIndex = 33;
            txtpresen.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtmax
            // 
            txtmax.Location = new Point(204, 553);
            txtmax.Name = "txtmax";
            txtmax.Size = new Size(240, 23);
            txtmax.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(71, 553);
            label5.Name = "label5";
            label5.Size = new Size(127, 17);
            label5.TabIndex = 37;
            label5.Text = "Maxsimum Diskon: ";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(753, 511);
            button2.Name = "button2";
            button2.Size = new Size(98, 38);
            button2.TabIndex = 40;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(638, 511);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 39;
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
            // Kodepromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 603);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(txtmax);
            Controls.Add(label4);
            Controls.Add(txtberlaku);
            Controls.Add(txtpresen);
            Controls.Add(label8);
            Controls.Add(txtdesk);
            Controls.Add(label7);
            Controls.Add(txtpromo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Kodepromo";
            Text = "Kodepromo";
            Load += Kodepromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtpresen).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtmax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox txtdesk;
        private Label label7;
        private TextBox txtpromo;
        private Label label3;
        private Label label4;
        private DateTimePicker txtberlaku;
        private NumericUpDown txtpresen;
        private NumericUpDown txtmax;
        private Label label5;
        private Button button2;
        private Button button1;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}