using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DbSurat;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Surat.View
{
    public partial class XtraUserControlIndex : XtraUserControl
    {
        private IndexSurat indexSurat;

        private void GetFromGrid()
        {
            try
            {
                if (gridViewData.SelectedRowsCount != 0)
                {
                    indexSurat = (IndexSurat)gridViewData.GetRow(gridViewData.FocusedRowHandle);

                    textEditIndex.Text = indexSurat.Index;
                    textEditKeperluan.Text = indexSurat.Keperluan;                    
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearForm()
        {
            textEditIndex.Text = string.Empty;
            textEditKeperluan.Text = string.Empty;            
        }

        public XtraUserControlIndex()
        {
            InitializeComponent();
        }

        private void XtraUserControlIndex_Load(object sender, EventArgs e)
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
            IndexSurat indexSurat = new IndexSurat(XpoDefault.Session)
            {
                Index = textEditIndex.Text.Trim(),
                Keperluan = textEditKeperluan.Text.Trim(),                
            };
            indexSurat.Save();
            ClearForm();
            xpCollectionData.Reload();
        }


        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexSurat != null)
                {
                    indexSurat.Index = textEditIndex.Text.Trim();
                    indexSurat.Keperluan = textEditKeperluan.Text.Trim();
                    indexSurat.Save();
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
                if (indexSurat!= null)
                {
                    if (XtraMessageBox.Show("Apakah anda ingin menghapus data ?", "Notif", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        indexSurat.Delete();
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
