using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL2_19_Tiket.MasterForm
{
    public partial class Jadwalpenerbangan : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public Jadwalpenerbangan()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_tiket.tbl_jadwalpenerbangan", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_tiket.tbl_jadwalpenerbangan" + "(kode,bandarakeberangkatan,bandaratujuan,maskapaiid,waktukeberangkatan,durasipenerbangan,hargapertiket)" +
                "VALUES" + "('" + kode.Text + "', '" + dari.Text + "'" +
                ", '" + ke.Text + "', '" + maskapai.Text + "'" +
                ", '" + tanggal.Text + "','" + durasi.Text + "','" + harga.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan");
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //db_tiket.tbl_bandara
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    koneksi.conn.Open();
                    String sql = "DELETE FROM db_tiket.tbl_jadwalpenerbangan Where id=@id";
                    cmd = new NpgsqlCommand(sql, koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Di hapus");
                        view_data();

                    }
                    else
                    {
                        MessageBox.Show("Gagal Cik");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    koneksi.conn.Close();
                }
            }
        }

        private void Jadwalpenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
        }
    }
}
