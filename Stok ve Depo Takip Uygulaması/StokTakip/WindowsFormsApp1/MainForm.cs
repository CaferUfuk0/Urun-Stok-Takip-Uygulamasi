using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const string connectionString = "Data Source =.; Initial Catalog = StokTakip; Integrated Security = True;";
        SqlConnection baglanti = new SqlConnection(@"Data Source =.; Initial Catalog = StokTakip; Integrated Security = True;");
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from StokListesi", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void btnUrunEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.RibbonFormReference = this;
            urunEkle.ShowDialog();
        }

        private void btnUrunSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();

            if (selectedRows.Length > 0)
            {
                DialogResult result = XtraMessageBox.Show("Seçili ürünleri silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        foreach (int rowHandle in selectedRows)
                        {
                            DataRow selectedRow = gridView1.GetDataRow(rowHandle);
                            int stokID = Convert.ToInt32(selectedRow["StokID"]);

                            string sqlQuery = "delete from StokListesi where StokID = @StokID";

                            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                            {
                                command.Parameters.AddWithValue("@StokID", stokID);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                    gridView1.DeleteSelectedRows();

                    XtraMessageBox.Show("Seçili ürünler başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Lütfen bir veya daha fazla ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {          
            XtraReport1 report = new XtraReport1();  
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.Print();
        }
    }
}