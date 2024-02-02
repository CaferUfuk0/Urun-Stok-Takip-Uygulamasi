using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UrunEkle : DevExpress.XtraEditors.XtraForm
    {
        private const string connectionString = "Data Source =.; Initial Catalog = StokTakip; Integrated Security = True;";

        public MainForm RibbonFormReference { get; set; }

        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) ||
            string.IsNullOrEmpty(txtBarkod.Text) ||
            string.IsNullOrEmpty(txtUrunAdi.Text) ||
            string.IsNullOrEmpty(txtMiktar.Text) ||
            string.IsNullOrEmpty(txtAlisFiyati.Text) ||
            string.IsNullOrEmpty(txtSatisFiyati.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun.");
            }
            else
            {
                int stokID = Convert.ToInt32(txtID.Text);
                string barkod = txtBarkod.Text;
                string stokAd = txtUrunAdi.Text;
                int miktar = Convert.ToInt32(txtMiktar.Text);
                decimal alisFiyati = Convert.ToDecimal(txtAlisFiyati.Text);
                decimal satisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO StokListesi (StokID, Barkod, StokAd, Miktar, AlisFiyat, SatisFiyat, Kar_Zarar) " +
                                      "VALUES (@StokID, @Barkod, @StokAd, @Miktar, @AlisFiyat, @SatisFiyat, @Kar_Zarar)";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StokID", stokID);
                        command.Parameters.AddWithValue("@Barkod", barkod);
                        command.Parameters.AddWithValue("@StokAd", stokAd);
                        command.Parameters.AddWithValue("@Miktar", miktar);
                        command.Parameters.AddWithValue("@AlisFiyat", alisFiyati);
                        command.Parameters.AddWithValue("@SatisFiyat", satisFiyati);
                        command.Parameters.AddWithValue("@Kar_Zarar", (satisFiyati - alisFiyati) * miktar);


                        command.ExecuteNonQuery();
                        if (RibbonFormReference != null)
                        {
                            RibbonFormReference.Listele();
                        }
                    }
                    XtraMessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
  
