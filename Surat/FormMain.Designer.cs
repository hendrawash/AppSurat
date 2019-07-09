namespace Surat
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.layoutControlForm = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.notifyIconSurat = new System.Windows.Forms.NotifyIcon(this.components);
            this.lookUpEditIndexSurat = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItemIndexSurat = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateEditTanggal = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItemTanggal = new DevExpress.XtraLayout.LayoutControlItem();
            this.memoEditKeperluan = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlItemKeperluan = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookUpEditPemesan = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItemPemesan = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonPesan = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpCollectionPemesan = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollectionIndexSurat = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlForm)).BeginInit();
            this.layoutControlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditIndexSurat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIndexSurat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTanggal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTanggal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTanggal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditKeperluan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemKeperluan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPemesan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPemesan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionPemesan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionIndexSurat)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlForm
            // 
            this.layoutControlForm.Controls.Add(this.simpleButtonPesan);
            this.layoutControlForm.Controls.Add(this.lookUpEditPemesan);
            this.layoutControlForm.Controls.Add(this.memoEditKeperluan);
            this.layoutControlForm.Controls.Add(this.dateEditTanggal);
            this.layoutControlForm.Controls.Add(this.lookUpEditIndexSurat);
            this.layoutControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlForm.Location = new System.Drawing.Point(0, 0);
            this.layoutControlForm.Name = "layoutControlForm";
            this.layoutControlForm.Root = this.Root;
            this.layoutControlForm.Size = new System.Drawing.Size(463, 192);
            this.layoutControlForm.TabIndex = 0;
            this.layoutControlForm.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemIndexSurat,
            this.layoutControlItemTanggal,
            this.layoutControlItemKeperluan,
            this.layoutControlItemPemesan,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(463, 192);
            this.Root.TextVisible = false;
            // 
            // notifyIconSurat
            // 
            this.notifyIconSurat.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSurat.Icon")));
            this.notifyIconSurat.Text = "Surat";
            this.notifyIconSurat.Visible = true;
            this.notifyIconSurat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSurat_MouseDoubleClick);
            // 
            // lookUpEditIndexSurat
            // 
            this.lookUpEditIndexSurat.Location = new System.Drawing.Point(72, 12);
            this.lookUpEditIndexSurat.Name = "lookUpEditIndexSurat";
            this.lookUpEditIndexSurat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditIndexSurat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Index", "Index", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Keperluan", "Keperluan", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditIndexSurat.Properties.DataSource = this.xpCollectionIndexSurat;
            this.lookUpEditIndexSurat.Properties.DisplayMember = "Index";
            this.lookUpEditIndexSurat.Properties.ValueMember = "ID";
            this.lookUpEditIndexSurat.Size = new System.Drawing.Size(261, 20);
            this.lookUpEditIndexSurat.StyleController = this.layoutControlForm;
            this.lookUpEditIndexSurat.TabIndex = 4;
            // 
            // layoutControlItemIndexSurat
            // 
            this.layoutControlItemIndexSurat.Control = this.lookUpEditIndexSurat;
            this.layoutControlItemIndexSurat.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemIndexSurat.Name = "layoutControlItemIndexSurat";
            this.layoutControlItemIndexSurat.Size = new System.Drawing.Size(325, 24);
            this.layoutControlItemIndexSurat.Text = "Index Surat";
            this.layoutControlItemIndexSurat.TextSize = new System.Drawing.Size(57, 13);
            // 
            // dateEditTanggal
            // 
            this.dateEditTanggal.EditValue = null;
            this.dateEditTanggal.Location = new System.Drawing.Point(72, 36);
            this.dateEditTanggal.Name = "dateEditTanggal";
            this.dateEditTanggal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTanggal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTanggal.Size = new System.Drawing.Size(261, 20);
            this.dateEditTanggal.StyleController = this.layoutControlForm;
            this.dateEditTanggal.TabIndex = 5;
            // 
            // layoutControlItemTanggal
            // 
            this.layoutControlItemTanggal.Control = this.dateEditTanggal;
            this.layoutControlItemTanggal.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemTanggal.Name = "layoutControlItemTanggal";
            this.layoutControlItemTanggal.Size = new System.Drawing.Size(325, 24);
            this.layoutControlItemTanggal.Text = "Tanggal";
            this.layoutControlItemTanggal.TextSize = new System.Drawing.Size(57, 13);
            // 
            // memoEditKeperluan
            // 
            this.memoEditKeperluan.Location = new System.Drawing.Point(72, 60);
            this.memoEditKeperluan.Name = "memoEditKeperluan";
            this.memoEditKeperluan.Size = new System.Drawing.Size(261, 96);
            this.memoEditKeperluan.StyleController = this.layoutControlForm;
            this.memoEditKeperluan.TabIndex = 6;
            // 
            // layoutControlItemKeperluan
            // 
            this.layoutControlItemKeperluan.Control = this.memoEditKeperluan;
            this.layoutControlItemKeperluan.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemKeperluan.Name = "layoutControlItemKeperluan";
            this.layoutControlItemKeperluan.Size = new System.Drawing.Size(325, 100);
            this.layoutControlItemKeperluan.Text = "Keperluan";
            this.layoutControlItemKeperluan.TextSize = new System.Drawing.Size(57, 13);
            // 
            // lookUpEditPemesan
            // 
            this.lookUpEditPemesan.Location = new System.Drawing.Point(72, 160);
            this.lookUpEditPemesan.Name = "lookUpEditPemesan";
            this.lookUpEditPemesan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPemesan.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nip", "Nip", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditPemesan.Properties.DataSource = this.xpCollectionPemesan;
            this.lookUpEditPemesan.Properties.DisplayMember = "Nama";
            this.lookUpEditPemesan.Properties.ValueMember = "ID";
            this.lookUpEditPemesan.Size = new System.Drawing.Size(261, 20);
            this.lookUpEditPemesan.StyleController = this.layoutControlForm;
            this.lookUpEditPemesan.TabIndex = 7;
            // 
            // layoutControlItemPemesan
            // 
            this.layoutControlItemPemesan.Control = this.lookUpEditPemesan;
            this.layoutControlItemPemesan.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItemPemesan.Name = "layoutControlItemPemesan";
            this.layoutControlItemPemesan.Size = new System.Drawing.Size(325, 24);
            this.layoutControlItemPemesan.Text = "Pemesan";
            this.layoutControlItemPemesan.TextSize = new System.Drawing.Size(57, 13);
            // 
            // simpleButtonPesan
            // 
            this.simpleButtonPesan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButtonPesan.Location = new System.Drawing.Point(337, 12);
            this.simpleButtonPesan.Name = "simpleButtonPesan";
            this.simpleButtonPesan.Size = new System.Drawing.Size(114, 38);
            this.simpleButtonPesan.StyleController = this.layoutControlForm;
            this.simpleButtonPesan.TabIndex = 8;
            this.simpleButtonPesan.Text = "Pesan";
            this.simpleButtonPesan.Click += new System.EventHandler(this.simpleButtonPesan_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonPesan;
            this.layoutControlItem5.Location = new System.Drawing.Point(325, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(118, 172);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // xpCollectionPemesan
            // 
            this.xpCollectionPemesan.ObjectType = typeof(DbSurat.Pegawai);
            // 
            // xpCollectionIndexSurat
            // 
            this.xpCollectionIndexSurat.ObjectType = typeof(DbSurat.IndexSurat);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 192);
            this.Controls.Add(this.layoutControlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Surat";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlForm)).EndInit();
            this.layoutControlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditIndexSurat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIndexSurat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTanggal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTanggal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemTanggal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditKeperluan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemKeperluan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPemesan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPemesan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionPemesan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionIndexSurat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlForm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.NotifyIcon notifyIconSurat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPesan;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPemesan;
        private DevExpress.XtraEditors.MemoEdit memoEditKeperluan;
        private DevExpress.XtraEditors.DateEdit dateEditTanggal;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditIndexSurat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemIndexSurat;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemTanggal;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemKeperluan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPemesan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Xpo.XPCollection xpCollectionIndexSurat;
        private DevExpress.Xpo.XPCollection xpCollectionPemesan;
    }
}

