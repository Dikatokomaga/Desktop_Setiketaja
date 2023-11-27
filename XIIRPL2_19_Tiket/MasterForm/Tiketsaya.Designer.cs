namespace XIIRPL2_19_Tiket.MasterForm
{
    partial class Tiketsaya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tiketsaya));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 30);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 31;
            label1.Text = "Tiket Saya ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(24, 30);
            button1.Name = "button1";
            button1.Size = new Size(48, 30);
            button1.TabIndex = 30;
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 73);
            label2.Name = "label2";
            label2.Size = new Size(242, 15);
            label2.TabIndex = 32;
            label2.Text = "Semua tiket Anda yang aktif akan ada di sini ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-8, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(813, 321);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Tiketsaya
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 459);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Tiketsaya";
            Text = "Tiketsaya";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}