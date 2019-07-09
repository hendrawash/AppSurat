using DevExpress.XtraEditors;
using Surat.View;

namespace Surat
{
    public partial class XtraFormSettings : XtraForm
    {
        private XtraUserControlPegawai xtraUserControlPegawai;
        private XtraUserControlIndex xtraUserControlIndex;

        public XtraFormSettings()
        {
            InitializeComponent();
        }

        private void navBarControlMenu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControlBody.Controls.Clear();
            switch (e.Link.ItemName)
            {
                case "navBarItemDataIndex":
                    xtraUserControlIndex?.Dispose();
                    xtraUserControlIndex = new XtraUserControlIndex();
                    panelControlBody.Controls.Add(xtraUserControlIndex);
                    break;
                case "navBarItemDataPegawai":
                    xtraUserControlPegawai?.Dispose();
                    xtraUserControlPegawai = new XtraUserControlPegawai();
                    panelControlBody.Controls.Add(xtraUserControlPegawai);                    
                    break;
                default:
                    break;
            }
        }
    }
}