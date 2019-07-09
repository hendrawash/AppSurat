using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DbSurat;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Surat.View
{
    public partial class XtraUserControlPegawai : DevExpress.XtraEditors.XtraUserControl
    {
        private Pegawai pegawai;

        private void GetFromGrid()
        {
            try
            {
                if (gridViewData.SelectedRowsCount != 0)
                {
                    pegawai = (Pegawai)gridViewData.GetRow(gridViewData.FocusedRowHandle);

                    textEditNip.Text = pegawai.Nip;
                    textEditNama.Text = pegawai.Nama;
                    lookUpEditPangkat.EditValue = pegawai.Pangkat.ID;
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {
            textEditNip.Text = string.Empty;
            textEditNama.Text = string.Empty;
            lookUpEditPangkat.EditValue = null;
        }

        public XtraUserControlPegawai()
        {
            InitializeComponent();
        }

        private void XtraUserControlPegawai_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void gridViewData_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.CellValue is string)
            {
                e.DisplayText = e.DisplayText.Trim();
            }
            if (e.Cell is GridCellInfo gridCellInfo) gridCellInfo.CellButtonRect = Rectangle.Empty;
        }

       
        private void gridViewData_Click(object sender, EventArgs e)
        {
            GetFromGrid();
        }

        private void gridViewData_KeyDown(object sender, KeyEventArgs e)
        {
            GetFromGrid();
        }

        private void gridViewData_KeyUp(object sender, KeyEventArgs e)
        {
            GetFromGrid();
        }
        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            Pegawai pegawai = new Pegawai(XpoDefault.Session)
            {
                Nip = textEditNip.Text.Trim(),
                Nama = textEditNama.Text.Trim(),
                Pangkat = (Pangkat)lookUpEditPangkat.GetSelectedDataRow()
            };
            pegawai.Save();
            ClearForm();
            xpCollectionData.Reload();
        }


        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (pegawai != null)
                {
                    pegawai.Nip = textEditNip.Text.Trim();
                    pegawai.Nama = textEditNama.Text.Trim();
                    pegawai.Pangkat = (Pangkat)lookUpEditPangkat.GetSelectedDataRow();
                    ClearForm();
                    xpCollectionData.Reload();
                }
                else
                {
                    throw new Exception("Anda belum memilih data");
                }
            } catch(Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (pegawai != null)
                {
                    if (XtraMessageBox.Show("Apakah anda ingin menghapus data ?", "Notif", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pegawai.Delete();
                        ClearForm();
                        xpCollectionData.Reload();
                    }
                }
                else
                {
                    throw new Exception("Anda belum memilih data");
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
