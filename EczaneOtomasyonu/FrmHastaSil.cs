using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace EczaneOtomasyonu
{
    public partial class FrmHastaSil : Form
    {
        public FrmHastaSil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(" provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb ");
        void listele()
        {
            OleDbCommand komut = new OleDbCommand("select * from Hastalar where durum = true", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        private void FrmHastaSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Hastalar where durum = true and TcNo = '" + txtTc.Text + "'", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("update Hastalar set durum = false where TcNo =@p1", con);
            con.Open();
            komut.Parameters.AddWithValue("@p1", txtTc.Text);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show(txtTc.Text + "numaralı kayıt silindi");
            }
            else
                MessageBox.Show("Silme işlemi başarısız ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();

            listele();
        }

        private void txtTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
