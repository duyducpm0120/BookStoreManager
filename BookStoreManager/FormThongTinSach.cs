using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManager
{
    public partial class FormThongTinSach : Form
    {
        int Id;
        public FormThongTinSach(int ID, string ten, int gia, int soluongdaban)
        {
            InitializeComponent();
            this.Id = ID;
            labelTen.Text = ten;
            labelGia.Text = gia.ToString() + " vnd";
            labelSoLuongDaBan.Text = soluongdaban.ToString();
            picBiaSach.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Image\\" + Id.ToString() + ".jpg");           
            //dataTable=Interface.databaseHelper.GetDatabase("");
        }
        private void ThongTinSachWF_Load(object sender, EventArgs e)
        {
            
        }
    }
}
