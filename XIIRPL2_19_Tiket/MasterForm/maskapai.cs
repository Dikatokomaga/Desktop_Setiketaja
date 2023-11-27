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
    public partial class maskapai : Form
    {

        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;

        public maskapai()
        {
            InitializeComponent();
        }

        private void maskapai_Load(object sender, EventArgs e)
        {
            view_data();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_tiket.tbl_maskapai" + "(nama,perusahaan,jumlah_kru,deskripsi)" +
                "VALUES" + "('" + txtnama.Text + "', '" + txtperusahaan.Text + "'" +
                ", '" + txtjumlahkru.Text + "','" + txtdesk.Text + "')";
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

        private void txtnama_TextChanged(object sender, EventArgs e)
        {

        }

        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_tiket.tbl_maskapai", koneksi.conn);
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
                    String sql = "DELETE FROM db_tiket.tbl_maskapai Where id=@id";
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
    }
}
