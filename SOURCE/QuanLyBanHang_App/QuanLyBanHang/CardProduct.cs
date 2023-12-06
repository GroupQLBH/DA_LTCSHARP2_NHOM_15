using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoReviewApp
{
    public partial class CardProduct : UserControl
    {
        public event EventHandler<EventArgs> UserControlClicked;
        public CardProduct()
        {
            InitializeComponent();
            this.Click += YourUserControl_Click;
            guna2CustomGradientPanel1.Click += YourUserControl_Click;
        }

        private string maSanPham;

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }

        static Image ResizeImage(string imagePath, int width, int height)
        {
            // Đọc ảnh từ đường dẫn
            Image originalImage = Image.FromFile(imagePath);

            // Tạo Bitmap mới với kích thước mới
            Bitmap resizedBitmap = new Bitmap(width, height);

            // Tạo đối tượng Graphics từ Bitmap mới
            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                // Vẽ ảnh gốc lên Bitmap mới với kích thước mới
                g.DrawImage(originalImage, new Rectangle(0, 0, width, height));
            }

            return resizedBitmap;
        }
        public void SetProductInfo(string ma,string TenSp, decimal DonGia , float Rating,string img )
        {
            this.maSanPham = ma;
            lblTenSp.Text = TenSp;
            lblDonGia.Text = Convert.ToString(DonGia);
            Image resizedImage = ResizeImage(@"..\..\Images\" + img, GNimg.Width, GNimg.Height);
            GNimg.Image = resizedImage;
            GNRating.Value = Rating;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void YourUserControl_Click(object sender, EventArgs e)
        {
            // Khi User Control được click, phát ra sự kiện UserControlClicked
            OnUserControlClicked();
        }

        protected virtual void OnUserControlClicked()
        {
            // Kiểm tra xem sự kiện đã được kích hoạt chưa
            UserControlClicked?.Invoke(this, EventArgs.Empty);
        }

        private void CardProduct_MouseEnter_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void CardProduct_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void guna2CustomGradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void guna2CustomGradientPanel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
}
