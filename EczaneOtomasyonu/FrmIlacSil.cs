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
    public partial class FrmIlacSil : Form
    {
        public FrmIlacSil()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(" provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb ");
        public void listele()
        {

            OleDbCommand komut = new OleDbCommand("select * from Ilaclar where durum =true ", con);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void FrmIlacSil_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from Ilaclar where durum = true and barkodNo = @p1", con);
            komut.Parameters.AddWithValue("@p1", int.Parse(txtTc.Text));
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            con.Open();
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("update Ilaclar set durum= false where barkodNo =@p1", con);
            komut.Parameters.AddWithValue("@p1", txtTc.Text);
            con.Open();
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show(txtTc.Text + " numaralı kayıt silindi");
            }
            else
                MessageBox.Show("Silme işlemi başarısız ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            con.Close();

            listele();
        }
    }
}
