
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL2_19_Tiket.MasterForm
{
    public partial class Masterbandara : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public Masterbandara()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void Masterbandara_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_tiket.tbl_bandara" + "(nama,kodeiata,kota,negaraid,jumlahterminal,alamat)" +
                "VALUES" + "('" + txtnama.Text + "', '" + txtkode.Text + "'" +
                ", '" + txtkota.Text + "', '" + txtnegara.Text + "'" +
                ", '" + txtterminal.Text + "','" + txtalamat.Text + "')";
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

        private void txtterminal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_tiket.tbl_bandara", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
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
                    String sql = "DELETE FROM db_tiket.tbl_bandara Where id=@id";
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
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "EDIT")
            {
                id.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                txtnama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nama"].Value);
                txtkode.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kodeiata"].Value);
                txtkota.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kota"].Value);
                txtnegara.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["negaraid"].Value);
                txtterminal.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["jumlahterminal"].Value);
                txtalamat.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["alamat"].Value);
                btnsmipan.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
