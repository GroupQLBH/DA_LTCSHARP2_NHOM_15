using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyBanHang_BLL;
namespace QuanLyBanHang
{
    public partial class FrmThongKe : UserControl
    {
        ThongKeBLL ThongKeBLL_CT = new ThongKeBLL();
        public FrmThongKe()
        {
            InitializeComponent();

        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            for (int i = 1; i <= 12; i++)
            {
                double TongTien = 0;
                foreach (DonHang dh in ThongKeBLL_CT.DonHangTheoThangTrongNam(i))
                {
                    TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangTheoThangTrongNam(i));
                }
                ChartThongKe.Series["Data"].Points.Add(TongTien);
                ChartThongKe.Series["Data"].Points[i - 1].Color = Color.Red;
                ChartThongKe.Series["Data"].Points[i - 1].AxisLabel = "Tháng " + (i).ToString();
                ChartThongKe.Series["Data"].Points[i - 1].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
                ChartThongKe.Series["Data"].Points[i - 1].LabelForeColor = Color.DarkBlue;
                ChartThongKe.Series["Data"].Points[i - 1].Font = new Font("Arial", 8, FontStyle.Bold);
            }
            pnlThongKe.Controls.Add(ChartThongKe);
            
        }

        private void btnTKThangNamHienTai_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            for (int i = 1; i <= 12; i++)
            {
                double TongTien = 0;
                foreach (DonHang dh in ThongKeBLL_CT.DonHangTheoThangTrongNam(i))
                {
                    TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangTheoThangTrongNam(i));
                }
                ChartThongKe.Series["Data"].Points.Add(TongTien);
                ChartThongKe.Series["Data"].Points[i - 1].Color = Color.Red;
                ChartThongKe.Series["Data"].Points[i - 1].AxisLabel = "Tháng " + (i).ToString();
                ChartThongKe.Series["Data"].Points[i - 1].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
                ChartThongKe.Series["Data"].Points[i - 1].LabelForeColor = Color.DarkBlue;
                ChartThongKe.Series["Data"].Points[i - 1].Font = new Font("Arial", 8, FontStyle.Bold);

            }
            pnlThongKe.Controls.Add(ChartThongKe);
        }

        private void btnTKNamHienTai_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            double TongTien = 0;
            foreach (DonHang dh in ThongKeBLL_CT.DonHangTheoNam(DateTime.Now.Year))
            {
               TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangTheoNam(DateTime.Now.Year));
            }
            ChartThongKe.Series["Data"].Points.Add(TongTien);
            ChartThongKe.Series["Data"].Points[0].Color = Color.Red;
            ChartThongKe.Series["Data"].Points[0].AxisLabel = "Năm " + DateTime.Now.Year.ToString();
            ChartThongKe.Series["Data"].Points[0].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
            ChartThongKe.Series["Data"].Points[0].LabelForeColor = Color.DarkBlue;
            ChartThongKe.Series["Data"].Points[0].Font = new Font("Arial", 8, FontStyle.Bold);
            pnlThongKe.Controls.Add(ChartThongKe);

        }

        private void btnTKCacNgayThangHienTai_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            for (int i = 1; i <= ThongKeBLL_CT.GetDaysInMonth(DateTime.Now.Month,DateTime.Now.Year); i++)
            {
                double TongTien = 0;
                foreach (DonHang dh in ThongKeBLL_CT.DonHangTheoNgayThangTrongNam(i, DateTime.Now.Month, DateTime.Now.Year))
                {
                    TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangTheoNgayThangTrongNam(i, DateTime.Now.Month, DateTime.Now.Year));
                }
                ChartThongKe.Series["Data"].Points.Add(TongTien);
                ChartThongKe.Series["Data"].Points[i - 1].Color = Color.Red;
                ChartThongKe.Series["Data"].Points[i - 1].AxisLabel = "Ngày " + (i).ToString();
                ChartThongKe.Series["Data"].Points[i - 1].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
                ChartThongKe.Series["Data"].Points[i - 1].LabelForeColor = Color.DarkBlue;
                ChartThongKe.Series["Data"].Points[i - 1].Font = new Font("Arial", 8, FontStyle.Bold);
            }
            pnlThongKe.Controls.Add(ChartThongKe);
        }

        private void btnTKNam_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            double TongTien = 0;
            foreach (DonHang dh in ThongKeBLL_CT.DonHangTheoNam(dTNgay.Value.Year))
            {
                TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangTheoNam(dTNgay.Value.Year));
            }
            ChartThongKe.Series["Data"].Points.Add(TongTien);
            ChartThongKe.Series["Data"].Points[0].Color = Color.Red;
            ChartThongKe.Series["Data"].Points[0].AxisLabel = "Năm " + DateTime.Now.Year.ToString();
            ChartThongKe.Series["Data"].Points[0].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
            ChartThongKe.Series["Data"].Points[0].LabelForeColor = Color.DarkBlue;
            ChartThongKe.Series["Data"].Points[0].Font = new Font("Arial", 8, FontStyle.Bold);
            pnlThongKe.Controls.Add(ChartThongKe);
        }

        private void btnTKThang_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            for (int i = 1; i <= 12; i++)
            {
                double TongTien = 0;
                foreach (DonHang dh in ThongKeBLL_CT.DonHangTheoThangTrongNam(i, dTNgay.Value.Year))
                {
                    TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangTheoThangTrongNam(i, dTNgay.Value.Year));
                }
                ChartThongKe.Series["Data"].Points.Add(TongTien);
                ChartThongKe.Series["Data"].Points[i - 1].Color = Color.Red;
                ChartThongKe.Series["Data"].Points[i - 1].AxisLabel = "Tháng " + (i).ToString();
                ChartThongKe.Series["Data"].Points[i - 1].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
                ChartThongKe.Series["Data"].Points[i - 1].LabelForeColor = Color.DarkBlue;
                ChartThongKe.Series["Data"].Points[i - 1].Font = new Font("Arial", 8, FontStyle.Bold);
            }
            pnlThongKe.Controls.Add(ChartThongKe);
        }

        private void btnTKNgay_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            for (int i = 1; i <= ThongKeBLL_CT.GetDaysInMonth(dTNgay.Value.Month, dTNgay.Value.Year); i++)
            {
                double TongTien = 0;
                foreach (DonHang dh in ThongKeBLL_CT.DonHangTheoNgayThangTrongNam(i, dTNgay.Value.Month, dTNgay.Value.Year))
                {
                    TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangTheoNgayThangTrongNam(i, dTNgay.Value.Month, dTNgay.Value.Year));
                }
                ChartThongKe.Series["Data"].Points.Add(TongTien);
                ChartThongKe.Series["Data"].Points[i - 1].Color = Color.Red;
                ChartThongKe.Series["Data"].Points[i - 1].AxisLabel = "Ngày " + (i).ToString();
                ChartThongKe.Series["Data"].Points[i - 1].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
                ChartThongKe.Series["Data"].Points[i - 1].LabelForeColor = Color.DarkBlue;
                ChartThongKe.Series["Data"].Points[i - 1].Font = new Font("Arial", 8, FontStyle.Bold);
            }
            pnlThongKe.Controls.Add(ChartThongKe);
        }

        private void btnTKTheoQuyTrongNam_Click(object sender, EventArgs e)
        {
            pnlThongKe.Controls.Clear();
            Chart ChartThongKe = new Chart();
            ChartThongKe.Size = new System.Drawing.Size(1200, 400);
            ChartThongKe.ChartAreas.Add(new ChartArea("NewChartArea"));
            ChartThongKe.Series.Add(new Series("Data"));
            for (int i = 1; i <= 4; i++)
            {
                double TongTien = 0;
                foreach (DonHang dh in ThongKeBLL_CT.DonHangQuy(i, dTNgay.Value.Year))
                {
                    TongTien = ThongKeBLL_CT.TongHoaDon(ThongKeBLL_CT.DonHangQuy(i, dTNgay.Value.Year));
                }
                ChartThongKe.Series["Data"].Points.Add(TongTien);
                ChartThongKe.Series["Data"].Points[i - 1].Color = Color.Red;
                ChartThongKe.Series["Data"].Points[i - 1].AxisLabel = "Quý " + (i).ToString();
                ChartThongKe.Series["Data"].Points[i - 1].Label = TongTien.ToString("N0", CultureInfo.InvariantCulture);
                ChartThongKe.Series["Data"].Points[i - 1].LabelForeColor = Color.DarkBlue;
                ChartThongKe.Series["Data"].Points[i - 1].Font = new Font("Arial", 8, FontStyle.Bold);
            }
            pnlThongKe.Controls.Add(ChartThongKe);
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
