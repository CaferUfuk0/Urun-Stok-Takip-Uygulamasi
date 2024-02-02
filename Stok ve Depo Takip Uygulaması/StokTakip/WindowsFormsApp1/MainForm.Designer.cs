namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SatisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kar_Zarar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.btnRapor = new DevExpress.XtraBars.BarButtonItem();
            this.btnHesapMakinesi = new DevExpress.XtraBars.BarButtonItem();
            this.switchKoyuTema = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonGiris = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, 122);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(741, 361);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StokID,
            this.Barkod,
            this.StokAd,
            this.Miktar,
            this.AlisFiyat,
            this.SatisFiyat,
            this.Kar_Zarar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // StokID
            // 
            this.StokID.Caption = "Stok ID";
            this.StokID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.StokID.FieldName = "StokID";
            this.StokID.Name = "StokID";
            this.StokID.Visible = true;
            this.StokID.VisibleIndex = 1;
            // 
            // Barkod
            // 
            this.Barkod.Caption = "Barkod";
            this.Barkod.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Barkod.FieldName = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.Visible = true;
            this.Barkod.VisibleIndex = 2;
            // 
            // StokAd
            // 
            this.StokAd.Caption = "Ürün Adı";
            this.StokAd.FieldName = "StokAd";
            this.StokAd.Name = "StokAd";
            this.StokAd.Visible = true;
            this.StokAd.VisibleIndex = 3;
            // 
            // Miktar
            // 
            this.Miktar.Caption = "Miktar";
            this.Miktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Miktar.FieldName = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.Visible = true;
            this.Miktar.VisibleIndex = 4;
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.Caption = "Alış Fiyatı";
            this.AlisFiyat.DisplayFormat.FormatString = "{0:C2}";
            this.AlisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.AlisFiyat.FieldName = "AlisFiyat";
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.Visible = true;
            this.AlisFiyat.VisibleIndex = 5;
            // 
            // SatisFiyat
            // 
            this.SatisFiyat.Caption = "Satış Fiyatı";
            this.SatisFiyat.DisplayFormat.FormatString = "{0:C2}";
            this.SatisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SatisFiyat.FieldName = "SatisFiyat";
            this.SatisFiyat.Name = "SatisFiyat";
            this.SatisFiyat.Visible = true;
            this.SatisFiyat.VisibleIndex = 6;
            // 
            // Kar_Zarar
            // 
            this.Kar_Zarar.Caption = "Kar - Zarar";
            this.Kar_Zarar.DisplayFormat.FormatString = "{0:C2}";
            this.Kar_Zarar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Kar_Zarar.FieldName = "Kar_Zarar";
            this.Kar_Zarar.Name = "Kar_Zarar";
            this.Kar_Zarar.Visible = true;
            this.Kar_Zarar.VisibleIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ribbonControl1);
            this.panelControl1.Location = new System.Drawing.Point(-1, -3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(741, 127);
            this.panelControl1.TabIndex = 10;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnUrunler,
            this.btnUrunEkle,
            this.btnUrunSil,
            this.btnHareketler,
            this.btnRapor,
            this.btnHesapMakinesi,
            this.switchKoyuTema,
            this.barButtonItem1,
            this.barToggleSwitchItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(2, 2);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonGiris});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(737, 133);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "Ürünler";
            this.btnUrunler.Id = 1;
            this.btnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.Image")));
            this.btnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunler.ImageOptions.LargeImage")));
            this.btnUrunler.Name = "btnUrunler";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Caption = "Ürün Ekle";
            this.btnUrunEkle.Id = 2;
            this.btnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.ImageOptions.Image")));
            this.btnUrunEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.ImageOptions.LargeImage")));
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunEkle_ItemClick);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Caption = "Ürün Sil";
            this.btnUrunSil.Id = 3;
            this.btnUrunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.ImageOptions.Image")));
            this.btnUrunSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.ImageOptions.LargeImage")));
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunSil_ItemClick);
            // 
            // btnHareketler
            // 
            this.btnHareketler.Caption = "Hareketler";
            this.btnHareketler.Id = 4;
            this.btnHareketler.Name = "btnHareketler";
            // 
            // btnRapor
            // 
            this.btnRapor.Caption = "Rapor Görüntüle";
            this.btnRapor.Id = 5;
            this.btnRapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRapor.ImageOptions.Image")));
            this.btnRapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRapor.ImageOptions.LargeImage")));
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRapor_ItemClick);
            // 
            // btnHesapMakinesi
            // 
            this.btnHesapMakinesi.Caption = "Hesap Makinesi";
            this.btnHesapMakinesi.Id = 6;
            this.btnHesapMakinesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapMakinesi.ImageOptions.Image")));
            this.btnHesapMakinesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHesapMakinesi.ImageOptions.LargeImage")));
            this.btnHesapMakinesi.Name = "btnHesapMakinesi";
            this.btnHesapMakinesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHesapMakinesi_ItemClick);
            // 
            // switchKoyuTema
            // 
            this.switchKoyuTema.Caption = "Koyu Tema";
            this.switchKoyuTema.Id = 8;
            this.switchKoyuTema.Name = "switchKoyuTema";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Hareketler";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "Koyu Mod";
            this.barToggleSwitchItem1.Id = 10;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Rapor Yazdır";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonGiris
            // 
            this.ribbonGiris.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonGiris.Name = "ribbonGiris";
            this.ribbonGiris.Text = "Giriş";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUrunEkle);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUrunSil);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRapor);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHesapMakinesi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barToggleSwitchItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 482);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 514);
            this.MinimumSize = new System.Drawing.Size(740, 514);
            this.Name = "MainForm";
            this.Text = "Stok ve Depo Takip Uygulaması";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn StokID;
        private DevExpress.XtraGrid.Columns.GridColumn Barkod;
        private DevExpress.XtraGrid.Columns.GridColumn StokAd;
        private DevExpress.XtraGrid.Columns.GridColumn Miktar;
        private DevExpress.XtraGrid.Columns.GridColumn AlisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn SatisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn Kar_Zarar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnUrunEkle;
        private DevExpress.XtraBars.BarButtonItem btnUrunSil;
        private DevExpress.XtraBars.BarButtonItem btnHareketler;
        private DevExpress.XtraBars.BarButtonItem btnRapor;
        private DevExpress.XtraBars.BarButtonItem btnHesapMakinesi;
        private DevExpress.XtraBars.BarToggleSwitchItem switchKoyuTema;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonGiris;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}