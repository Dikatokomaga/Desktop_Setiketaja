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
    public partial class Tiketsaya : Form
    {
        public Tiketsaya()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //public void view_data()
        //{
        //    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_perubahanstatusjadwal", koneksi.conn);
        //    DataTable dt = new DataTable();
      //      adapter.Fill(dt);
       //     dataGridView1.DataSource = dt;
       // }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
