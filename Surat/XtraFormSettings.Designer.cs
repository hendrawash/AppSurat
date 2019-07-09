namespace Surat
{
    partial class XtraFormSettings
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
            this.splitContainerControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControlMenu = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupData = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemDataIndex = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDataPegawai = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControlBody = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).BeginInit();
            this.splitContainerControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBody)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControlMain
            // 
            this.splitContainerControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlMain.Name = "splitContainerControlMain";
            this.splitContainerControlMain.Panel1.Controls.Add(this.navBarControlMenu);
            this.splitContainerControlMain.Panel1.Text = "Panel1";
            this.splitContainerControlMain.Panel2.Controls.Add(this.panelControlBody);
            this.splitContainerControlMain.Panel2.Text = "Panel2";
            this.splitContainerControlMain.Size = new System.Drawing.Size(1001, 410);
            this.splitContainerControlMain.SplitterPosition = 181;
            this.splitContainerControlMain.TabIndex = 0;
            // 
            // navBarControlMenu
            // 
            this.navBarControlMenu.ActiveGroup = this.navBarGroupData;
            this.navBarControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControlMenu.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupData});
            this.navBarControlMenu.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemDataIndex,
            this.navBarItemDataPegawai});
            this.navBarControlMenu.Location = new System.Drawing.Point(0, 0);
            this.navBarControlMenu.Name = "navBarControlMenu";
            this.navBarControlMenu.OptionsNavPane.ExpandedWidth = 181;
            this.navBarControlMenu.Size = new System.Drawing.Size(181, 410);
            this.navBarControlMenu.TabIndex = 0;
            this.navBarControlMenu.Text = "navBarControl1";
            this.navBarControlMenu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarControlMenu_LinkClicked);
            // 
            // navBarGroupData
            // 
            this.navBarGroupData.Caption = "Data";
            this.navBarGroupData.Expanded = true;
            this.navBarGroupData.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDataIndex),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDataPegawai)});
            this.navBarGroupData.Name = "navBarGroupData";
            // 
            // navBarItemDataIndex
            // 
            this.navBarItemDataIndex.Caption = "Index";
            this.navBarItemDataIndex.Name = "navBarItemDataIndex";
            // 
            // navBarItemDataPegawai
            // 
            this.navBarItemDataPegawai.Caption = "Pegawai";
            this.navBarItemDataPegawai.Name = "navBarItemDataPegawai";
            // 
            // panelControlBody
            // 
            this.panelControlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlBody.Location = new System.Drawing.Point(0, 0);
            this.panelControlBody.Name = "panelControlBody";
            this.panelControlBody.Size = new System.Drawing.Size(815, 410);
            this.panelControlBody.TabIndex = 0;
            // 
            // XtraFormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 410);
            this.Controls.Add(this.splitContainerControlMain);
            this.Name = "XtraFormSettings";
            this.Text = "XtraFormSettins";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlMain)).EndInit();
            this.splitContainerControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlMain;
        private DevExpress.XtraNavBar.NavBarControl navBarControlMenu;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupData;
        private DevExpress.XtraEditors.PanelControl panelControlBody;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDataIndex;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDataPegawai;
    }
}