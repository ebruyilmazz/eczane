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
    public partial class FrmHastaKaydi : Form
    {
        public FrmHastaKaydi()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(" provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb ");
        public void guvenceGetir()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Guvenceler", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            cbGuvence.ValueMember = "guvenceNo";
            cbGuvence.DisplayMember = "guvenceAdi";
            cbGuvence.DataSource = tablo;
        }
        private void FrmHastaKaydi_Load(object sender, EventArgs e)
        {
            guvenceGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAd.Text == "" || txtNo.Text == "" || txtAdres.Text =="" || TxtTel.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("insert into Hastalar values(@p1, @p2, @p3, @p4, @p5, @p6)", con);
                con.Open();
                komut.Parameters.AddWithValue("@p1", txtNo.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", txtAdres.Text);
                komut.Parameters.AddWithValue("@p4", TxtTel.Text);
                komut.Parameters.AddWithValue("@p5", cbGuvence.SelectedValue);
                komut.Parameters.AddWithValue("@p6", true);

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Kayıt Başarıyla oluşturuldu");
                else
                    MessageBox.Show("Kayıt Hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);             
                con.Close();
            }

            txtNo.Text = "";
            txtAd.Text = "";
            txtAdres.Text = "";
            TxtTel.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbGuvence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
