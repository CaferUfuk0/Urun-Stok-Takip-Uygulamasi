namespace WindowsFormsApp1
{
    partial class UrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkle));
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelBarkod = new DevExpress.XtraEditors.LabelControl();
            this.labelUrunAdi = new DevExpress.XtraEditors.LabelControl();
            this.labelMiktar = new DevExpress.XtraEditors.LabelControl();
            this.labelAlis = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelSatis = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.labelStokID = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(94, 42);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtBarkod.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtBarkod.Size = new System.Drawing.Size(123, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(94, 68);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(123, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(94, 94);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtMiktar.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtMiktar.Size = new System.Drawing.Size(123, 20);
            this.txtMiktar.TabIndex = 3;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(94, 120);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAlisFiyati.Properties.MaskSettings.Set("mask", "c");
            this.txtAlisFiyati.Size = new System.Drawing.Size(123, 20);
            this.txtAlisFiyati.TabIndex = 4;
            // 
            // labelBarkod
            // 
            this.labelBarkod.Location = new System.Drawing.Point(16, 45);
            this.labelBarkod.Name = "labelBarkod";
            this.labelBarkod.Size = new System.Drawing.Size(33, 13);
            this.labelBarkod.TabIndex = 6;
            this.labelBarkod.Text = "Barkod";
            // 
            // labelUrunAdi
            // 
            this.labelUrunAdi.Location = new System.Drawing.Point(16, 71);
            this.labelUrunAdi.Name = "labelUrunAdi";
            this.labelUrunAdi.Size = new System.Drawing.Size(41, 13);
            this.labelUrunAdi.TabIndex = 7;
            this.labelUrunAdi.Text = "Ürün Adı";
            // 
            // labelMiktar
            // 
            this.labelMiktar.Location = new System.Drawing.Point(16, 97);
            this.labelMiktar.Name = "labelMiktar";
            this.labelMiktar.Size = new System.Drawing.Size(29, 13);
            this.labelMiktar.TabIndex = 8;
            this.labelMiktar.Text = "Miktar";
            // 
            // labelAlis
            // 
            this.labelAlis.Location = new System.Drawing.Point(16, 123);
            this.labelAlis.Name = "labelAlis";
            this.labelAlis.Size = new System.Drawing.Size(45, 13);
            this.labelAlis.TabIndex = 9;
            this.labelAlis.Text = "Alış Fiyatı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(119, 176);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Listeye Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // labelSatis
            // 
            this.labelSatis.Location = new System.Drawing.Point(16, 149);
            this.labelSatis.Name = "labelSatis";
            this.labelSatis.Size = new System.Drawing.Size(52, 13);
            this.labelSatis.TabIndex = 11;
            this.labelSatis.Text = "Satış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(94, 146);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtSatisFiyati.Properties.MaskSettings.Set("mask", "c");
            this.txtSatisFiyati.Size = new System.Drawing.Size(123, 20);
            this.txtSatisFiyati.TabIndex = 5;
            // 
            // labelStokID
            // 
            this.labelStokID.Location = new System.Drawing.Point(16, 19);
            this.labelStokID.Name = "labelStokID";
            this.labelStokID.Size = new System.Drawing.Size(11, 13);
            this.labelStokID.TabIndex = 5;
            this.labelStokID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.EditValue = "";
            this.txtID.Location = new System.Drawing.Point(94, 16);
            this.txtID.Name = "txtID";
            this.txtID.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtID.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtID.Size = new System.Drawing.Size(123, 20);
            this.txtID.TabIndex = 0;
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 208);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.labelSatis);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.labelAlis);
            this.Controls.Add(this.labelMiktar);
            this.Controls.Add(this.labelUrunAdi);
            this.Controls.Add(this.labelBarkod);
            this.Controls.Add(this.labelStokID);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.txtID);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("UrunEkle.IconOptions.LargeImage")));
            this.Name = "UrunEkle";
            this.Text = "Ürün Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private DevExpress.XtraEditors.LabelControl labelBarkod;
        private DevExpress.XtraEditors.LabelControl labelUrunAdi;
        private DevExpress.XtraEditors.LabelControl labelMiktar;
        private DevExpress.XtraEditors.LabelControl labelAlis;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.LabelControl labelSatis;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyati;
        private DevExpress.XtraEditors.LabelControl labelStokID;
        private DevExpress.XtraEditors.TextEdit txtID;
    }
}