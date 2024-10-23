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
    public partial class FrmGuvenceKaydi : Form
    {
        public FrmGuvenceKaydi()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(" provider = microsoft.ace.oledb.12.0; data source = EczaneDB.accdb ");
        private void button1_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "")
            {
                MessageBox.Show("Lütfen güvence adını giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("insert into Guvenceler (guvenceAdi, durum) values(@p1, @p2)", con);
                con.Open();
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", true);

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                    MessageBox.Show("Kayıt Başarıyla oluşturuldu");
                else
                    MessageBox.Show("Kayıt Hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con.Close();
            }

            txtAd.Text = "";

        }
    }
}
