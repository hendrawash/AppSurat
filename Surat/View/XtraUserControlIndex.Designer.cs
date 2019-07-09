namespace Surat.View
{
    partial class XtraUserControlIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlIndex));
            this.splitContainerControlForm = new DevExpress.XtraEditors.SplitContainerControl();
            this.layoutControlForm = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textEditKeperluan = new DevExpress.XtraEditors.TextEdit();
            this.textEditIndex = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemIndex = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItemKeperluan = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlData = new DevExpress.XtraGrid.GridControl();
            this.xpCollectionData = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKeperluan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndex = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlForm)).BeginInit();
            this.splitContainerControlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlForm)).BeginInit();
            this.layoutControlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditKeperluan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIndex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemKeperluan)).BeginInit();
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
            this.layoutControlForm.Controls.Add(this.textEditKeperluan);
            this.layoutControlForm.Controls.Add(this.textEditIndex);
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
            this.simpleButtonUpdate.Location = new System.Drawing.Point(144, 70);
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
            this.simpleButtonAdd.Location = new System.Drawing.Point(29, 70);
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
            this.simpleButtonDelete.Location = new System.Drawing.Point(259, 70);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(111, 38);
            this.simpleButtonDelete.StyleController = this.layoutControlForm;
            this.simpleButtonDelete.TabIndex = 8;
            this.simpleButtonDelete.Text = "Hapus";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // textEditKeperluan
            // 
            this.textEditKeperluan.Location = new System.Drawing.Point(63, 36);
            this.textEditKeperluan.Name = "textEditKeperluan";
            this.textEditKeperluan.Size = new System.Drawing.Size(307, 20);
            this.textEditKeperluan.StyleController = this.layoutControlForm;
            this.textEditKeperluan.TabIndex = 5;
            // 
            // textEditIndex
            // 
            this.textEditIndex.Location = new System.Drawing.Point(63, 12);
            this.textEditIndex.Name = "textEditIndex";
            this.textEditIndex.Size = new System.Drawing.Size(307, 20);
            this.textEditIndex.StyleController = this.layoutControlForm;
            this.textEditIndex.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemIndex,
            this.emptySpaceItem1,
            this.layoutControlItemKeperluan,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(382, 461);
            this.Root.TextVisible = false;
            // 
            // layoutControlItemIndex
            // 
            this.layoutControlItemIndex.Control = this.textEditIndex;
            this.layoutControlItemIndex.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemIndex.Name = "layoutControlItemIndex";
            this.layoutControlItemIndex.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemIndex.Text = "Index";
            this.layoutControlItemIndex.TextSize = new System.Drawing.Size(48, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 100);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(362, 341);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItemKeperluan
            // 
            this.layoutControlItemKeperluan.Control = this.textEditKeperluan;
            this.layoutControlItemKeperluan.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItemKeperluan.Name = "layoutControlItemKeperluan";
            this.layoutControlItemKeperluan.Size = new System.Drawing.Size(362, 24);
            this.layoutControlItemKeperluan.Text = "Keperluan";
            this.layoutControlItemKeperluan.TextSize = new System.Drawing.Size(48, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 48);
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
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 58);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(17, 42);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButtonDelete;
            this.layoutControlItem5.Location = new System.Drawing.Point(247, 58);
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
            this.layoutControlItem6.Location = new System.Drawing.Point(17, 58);
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
            this.layoutControlItem4.Location = new System.Drawing.Point(132, 58);
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
            this.xpCollectionData.ObjectType = typeof(DbSurat.IndexSurat);
            // 
            // gridViewData
            // 
            this.gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKeperluan,
            this.colIndex});
            this.gridViewData.GridControl = this.gridControlData;
            this.gridViewData.Name = "gridViewData";
            this.gridViewData.OptionsBehavior.Editable = false;
            this.gridViewData.OptionsView.ShowGroupPanel = false;
            this.gridViewData.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewData_CustomDrawCell);
            this.gridViewData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewData_KeyDown);
            this.gridViewData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridViewData_KeyUp);
            this.gridViewData.Click += new System.EventHandler(this.gridViewData_Click);
            // 
            // colKeperluan
            // 
            this.colKeperluan.Caption = "Keperluan";
            this.colKeperluan.FieldName = "Keperluan";
            this.colKeperluan.Name = "colKeperluan";
            this.colKeperluan.Visible = true;
            this.colKeperluan.VisibleIndex = 1;
            // 
            // colIndex
            // 
            this.colIndex.Caption = "Index";
            this.colIndex.FieldName = "Index";
            this.colIndex.Name = "colIndex";
            this.colIndex.Visible = true;
            this.colIndex.VisibleIndex = 0;
            // 
            // XtraUserControlIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControlForm);
            this.Name = "XtraUserControlIndex";
            this.Size = new System.Drawing.Size(723, 461);
            this.Load += new System.EventHandler(this.XtraUserControlIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlForm)).EndInit();
            this.splitContainerControlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlForm)).EndInit();
            this.layoutControlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditKeperluan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIndex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemKeperluan)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEditKeperluan;
        private DevExpress.XtraEditors.TextEdit textEditIndex;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemIndex;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItemKeperluan;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.Xpo.XPCollection xpCollectionData;
        private DevExpress.XtraGrid.Columns.GridColumn colKeperluan;
        private DevExpress.XtraGrid.Columns.GridColumn colIndex;
    }
}
