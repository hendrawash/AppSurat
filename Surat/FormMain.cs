using DevExpress.Xpo;
using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Surat
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        private readonly FastReport.Report _report = new FastReport.Report();

        public FormMain()
        {
            InitializeComponent();
        }

        private void notifyIconSurat_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            XtraFormSettings xtraFormSettings = new XtraFormSettings();
            xtraFormSettings.ShowDialog();
        }

        private void simpleButtonPesan_Click(object sender, EventArgs e)
        {
            var nomer = 1;
            var indexSurat = (DbSurat.IndexSurat)lookUpEditIndexSurat.GetSelectedDataRow();
            var keperluan = memoEditKeperluan.Text.Trim();
            var tanggal = dateEditTanggal.DateTime;

            var allSuratByIndex = from dataSurat in new XPQuery<DbSurat.Surat>(XpoDefault.Session)
                                  where dataSurat.IndexSurat.ID==indexSurat.ID
                                  orderby dataSurat.NoSurat
                                       select dataSurat;
            if(allSuratByIndex.Count() > 0)
            {
                nomer = allSuratByIndex.LastOrDefault().NoSurat + 1;
            }

            DbSurat.Surat surat = new DbSurat.Surat(XpoDefault.Session)
            {
                IndexSurat = indexSurat,
                Tanggal = tanggal,
                Keperluan = keperluan,
                NoSurat = nomer,
                Pemesan = (DbSurat.Pegawai)lookUpEditPemesan.GetSelectedDataRow()
            };
            surat.Save();

            if (File.Exists("PrintSurat.frx"))
            {
                _report.Load("PrintSurat.frx");
            }
            var stringNomer = indexSurat.Index + " / " + nomer + " / " + tanggal.Year;
            _report.SetParameterValue("ParameterNoSurat", stringNomer);
            _report.SetParameterValue("ParameterTanggalSurat", tanggal.ToString("dd/MM/yyyy"));
            _report.SetParameterValue("ParameterkeperluanSurat", keperluan);
            _report.Print();
        }
    }
}
