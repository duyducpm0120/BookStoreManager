using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManager
{
    public partial class Sach : UserControl
    {
        string ten;
        int gia, soLuongDaBan;
        public int Id;
        public Sach(int id, string ten, int gia, int soLuongDaBan)
        {
            InitializeComponent();
            this.gia = gia;
            this.soLuongDaBan = soLuongDaBan;
            this.ten = ten;
            this.Id = id;
            picAnhSach.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Image\\" + Id.ToString() + ".jpg");
            richTextBoxTenSach.Text = ten;
            labelSoluongdaban.Text = soLuongDaBan.ToString();
            labelGiaSach.Text = gia.ToString() +" vnd";
        }
        private void Sach_Load(object sender, EventArgs e)
        {
            //labelTenSach.Text = ten;
            //labelSoLuongBan.Text = soLuongDaBan.ToString();
            //labelGiaSach.Text = gia.ToString();
        }

        private void PicAnhSach_Click(object sender, EventArgs e)
        {
            FormThongTinSach formThongTinSach = new FormThongTinSach(this.Id, this.ten, this.gia, this.soLuongDaBan);
            formThongTinSach.Show();
        }
    }
}
