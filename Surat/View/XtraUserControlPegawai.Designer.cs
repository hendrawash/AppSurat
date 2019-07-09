namespace Surat.View
{
    partial class XtraUserControlPegawai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlPegawai));
            this.splitContainerControlForm = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControlForm = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditPangkat = new DevExpress.XtraEditors.LookUpEdit();
            this.xpCollectionPangkat = new DevExpress.Xpo.XPCollection(this.components);
            this.textEditNama = new DevExpress.XtraEditors.TextEdit();
            this.textEditNip = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemNip = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemNama = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemPangkat = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionData = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlForm)).BeginInit();
            this.splitContainerControlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlForm)).BeginInit();
            this.layoutControlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPangkat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionPangkat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPangkat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControlForm
            // 
            this.splitContainerControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlForm.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlForm.Name = "splitContainerControlForm";
            this.splitContainerControlForm.Panel1.Controls.Add(this.layoutControlForm);
            this.splitContainerControlForm.Panel1.Text = "Panel1";
            this.splitContainerControlForm.Panel2.Controls.Add(this.gridControlData);
            this.splitContainerControlForm.Panel2.Text = "Panel2";
            this.splitContainerControlForm.Size = new System.Drawing.Size(723, 461);
            this.splitContainerControlForm.SplitterPosition = 382;
            this.splitContainerControlForm.TabIndex = 0;
            // 
            // layoutControlForm
            // 
            this.layoutControlForm.Controls.Add(this.simpleButtonUpdate);
            this.layoutControlForm.Controls.Add(this.simpleButtonAdd);
            this.layoutControlForm.Controls.Add(this.simpleButtonDelete);
            this.layoutControlForm.Controls.Add(this.lookUpEditPangkat);
            this.layoutControlForm.Controls.Add(this.textEditNama);
            this.layoutControlForm.Controls.Add(this.textEditNip);
            this.layoutControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlForm.Location = new System.Drawing.Point(0, 0);
            this.layoutControlForm.Name = "layoutControlForm";
            this.layoutControlForm.Root = this.Root;
            this.layoutControlForm.Size = new System.Drawing.Size(382, 461);
            this.layoutControlForm.TabIndex = 0;
            this.layoutControlForm.Text = "layoutControl1";
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonUpdate.ImageOptions.Image")));
            this.simpleButtonUpdate.Location = new System.Drawing.Point(144, 94);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(111, 38);
            this.simpleButtonUpdate.StyleController = this.layoutControlForm;
            this.simpleButtonUpdate.TabIndex = 10;
            this.simpleButtonUpdate.Text = "Ubah";
            this.simpleButtonUpdate.Click += new System.EventHandler(this.simpleButtonUpdate_Click);
            // 
            // simpleButtonAdd
            // 
            this.simpleButtonAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAdd.ImageOptions.Image")));
            this.simpleButtonAdd.Location = new System.Drawing.Point(29, 94);
            this.simpleButtonAdd.Name = "simpleButtonAdd";
            this.simpleButtonAdd.Size = new System.Drawing.Size(111, 38);
            this.simpleButtonAdd.StyleController = this.layoutControlForm;
            this.simpleButtonAdd.TabIndex = 9;
            this.simpleButtonAdd.Text = "Tambah";
            this.simpleButtonAdd.Click += new System.EventHandler(this.simpleButtonAdd_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDelete.ImageOptions.Image")));
            this.simpleButtonDelete.Location = new System.Drawing.Point(259, 94);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(111, 38);
            this.simpleButtonDelete.StyleController = this.layoutControlForm;
            this.simpleButtonDelete.TabIndex = 8;
            this.simpleButtonDelete.Text = "Hapus";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // lookUpEditPangkat
            // 
            this.lookUpEditPangkat.Location = new System.Drawing.Point(54, 60);
            this.lookUpEditPangkat.Name = "lookUpEditPangkat";
            this.lookUpEditPangkat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPangkat.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Golongan", "Golongan", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PangkatValue", "Pangkat Value", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEditPangkat.Properties.DataSource = this.xpCollectionPangkat;
            this.lookUpEditPangkat.Properties.DisplayMember = "Golongan";
            this.lookUpEditPangkat.Properties.ValueMember = "ID";
            this.lookUpEditPangkat.Size = new System.Drawing.Size(316, 20);
            this.lookUpEditPangkat.StyleController = this.layoutControlForm;
            this.lookUpEditPangkat.TabIndex = 6;
            // 
            // xpCollectionPangkat
            // 
            this.xpCollectionPangkat.ObjectType = typeof(DbSurat.Pangkat);
            // 
            // textEditNama
            // 
            this.textEditNama.Location = new System.Drawing.Point(54, 36);
            this.textEditNama.Name = "textEditNama";
            this.textEditNama.Size = new System.Drawing.Size(316, 20);
            this.textEditNama.StyleController = this.layoutControlForm;
            this.textEditNama.TabIndex = 5;
            // 
            // textEditNip
            // 
            this.textEditNip.Location = new System.Drawing.Point(54, 12);
            this.textEditNip.Name = "textEditNip";
            this.textEditNip.Size = new System.Drawing.Size(316, 20);
            this.textEditNip.StyleController = this.layoutControlForm;
            this.textEditNip.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemNip,
            this.emptySpaceItem1,
            this.layoutControlItemNama,
            this.layoutControlItemPangkat,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(382, 461);
            this.Root.TextVisible = false;
            // 
            // layoutControlItemNip
            // 
            this.layoutControlItemNip.Control = this.textEditNip;
            this.layoutControlItemNip.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemNip.Name = "layoutControlItemNip";
            this.layoutControlItemNip.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemNip.Text = "N I P";
            this.layoutControlItemNip.TextSize = new System.Drawing.Size(39, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 124);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(362, 317);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemNama
            // 
            this.layoutControlItemNama.Control = this.textEditNama;
            this.layoutControlItemNama.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemNama.Name = "layoutControlItemNama";
            this.layoutControlItemNama.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemNama.Text = "Nama";
            this.layoutControlItemNama.TextSize = new System.Drawing.Size(39, 13);
            // 
            // layoutControlItemPangkat
            // 
            this.layoutControlItemPangkat.Control = this.lookUpEditPangkat;
            this.layoutControlItemPangkat.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItemPangkat.Name = "layoutControlItemPangkat";
            this.layoutControlItemPangkat.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemPangkat.Text = "Pangkat";
            this.layoutControlItemPangkat.TextSize = new System.Drawing.Size(39, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(362, 10);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 82);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(17, 42);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonDelete;
            this.layoutControlItem5.Location = new System.Drawing.Point(247, 82);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(115, 42);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButtonAdd;
            this.layoutControlItem6.Location = new System.Drawing.Point(17, 82);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(115, 42);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButtonUpdate;
            this.layoutControlItem4.Location = new System.Drawing.Point(132, 82);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(115, 42);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // gridControlData
            // 
            this.gridControlData.DataSource = this.xpCollectionData;
            this.gridControlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlData.Location = new System.Drawing.Point(0, 0);
            this.gridControlData.MainView = this.gridViewData;
            this.gridControlData.Name = "gridControlData";
            this.gridControlData.Size = new System.Drawing.Size(336, 461);
            this.gridControlData.TabIndex = 0;
            this.gridControlData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewData});
            // 
            // xpCollectionData
            // 
            this.xpCollectionData.ObjectType = typeof(DbSurat.Pegawai);
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNama,
            this.colNip,
            this.gridColumn2});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewData_CustomDrawCell);
            this.gridViewData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewData_KeyDown);
            this.gridViewData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewData_KeyUp);
            this.gridViewData.Click += new System.EventHandler(this.gridViewData_Click);
            // 
            // colNama
            // 
            this.colNama.FieldName = "Nama";
            this.colNama.Name = "colNama";
            this.colNama.Visible = true;
            this.colNama.VisibleIndex = 0;
            // 
            // colNip
            // 
            this.colNip.FieldName = "Nip";
            this.colNip.Name = "colNip";
            this.colNip.Visible = true;
            this.colNip.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Pangkat/Golongan";
            this.gridColumn2.FieldName = "Pangkat.PangkatValue";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // XtraUserControlPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControlForm);
            this.Name = "XtraUserControlPegawai";
            this.Size = new System.Drawing.Size(723, 461);
            this.Load += new System.EventHandler(this.XtraUserControlPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlForm)).EndInit();
            this.splitContainerControlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlForm)).EndInit();
            this.layoutControlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPangkat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionPangkat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemNama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemPangkat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlForm;
        private DevExpress.XtraGrid.GridControl gridControlData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraLayout.LayoutControl layoutControlForm;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPangkat;
        private DevExpress.XtraEditors.TextEdit textEditNama;
        private DevExpress.XtraEditors.TextEdit textEditNip;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemNip;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemNama;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemPangkat;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Xpo.XPCollection xpCollectionData;
        private DevExpress.Xpo.XPCollection xpCollectionPangkat;
        private DevExpress.XtraGrid.Columns.GridColumn colNama;
        private DevExpress.XtraGrid.Columns.GridColumn colNip;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}
