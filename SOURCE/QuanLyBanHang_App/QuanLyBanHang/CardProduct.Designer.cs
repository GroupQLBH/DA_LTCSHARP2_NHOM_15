namespace DemoReviewApp
{
    partial class CardProduct
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.GNRating = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GNimg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GNimg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblDonGia);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTenSp);
            this.guna2CustomGradientPanel1.Controls.Add(this.GNRating);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.GNimg);
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.LightSkyBlue;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(409, 134);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            this.guna2CustomGradientPanel1.MouseEnter += new System.EventHandler(this.guna2CustomGradientPanel1_MouseEnter);
            this.guna2CustomGradientPanel1.MouseLeave += new System.EventHandler(this.guna2CustomGradientPanel1_MouseLeave);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.BackColor = System.Drawing.Color.Transparent;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.Salmon;
            this.lblDonGia.Location = new System.Drawing.Point(115, 74);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(62, 16);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.BackColor = System.Drawing.Color.Transparent;
            this.lblTenSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSp.ForeColor = System.Drawing.Color.Cyan;
            this.lblTenSp.Location = new System.Drawing.Point(115, 42);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(105, 16);
            this.lblTenSp.TabIndex = 4;
            this.lblTenSp.Text = "Tên sản phẩm";
            this.lblTenSp.Click += new System.EventHandler(this.label3_Click);
            // 
            // GNRating
            // 
            this.GNRating.BackColor = System.Drawing.Color.Transparent;
            this.GNRating.Location = new System.Drawing.Point(118, 93);
            this.GNRating.Name = "GNRating";
            this.GNRating.RatingColor = System.Drawing.Color.Gold;
            this.GNRating.Size = new System.Drawing.Size(147, 23);
            this.GNRating.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn Giá: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm";
            // 
            // GNimg
            // 
            this.GNimg.BackColor = System.Drawing.Color.Transparent;
            this.GNimg.BorderRadius = 30;
            this.GNimg.Location = new System.Drawing.Point(12, 27);
            this.GNimg.Name = "GNimg";
            this.GNimg.ShadowDecoration.Parent = this.GNimg;
            this.GNimg.Size = new System.Drawing.Size(91, 89);
            this.GNimg.TabIndex = 0;
            this.GNimg.TabStop = false;
            // 
            // CardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "CardProduct";
            this.Size = new System.Drawing.Size(415, 139);
            this.MouseEnter += new System.EventHandler(this.CardProduct_MouseEnter_1);
            this.MouseLeave += new System.EventHandler(this.CardProduct_MouseLeave);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GNimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox GNimg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RatingStar GNRating;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTenSp;
    }
}
