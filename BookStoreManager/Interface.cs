using Guna.UI.WinForms;
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
    public partial class Interface : Form
    {
        public static DatabaseHelper databaseHelper;

        public Interface()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
            this.AutoSize = true;
            btnLapPhieuNhap.Click += Click;
            btnTimKiemSach.Click += Click;
            btnLapHoaDon.Click += Click;
            SeparatorLapHoaDonBanSach.Hide();
            SeparatorLapPhieuNhapSach.Hide();
            SeparatorTimKiem.Hide();
            Separator.Hide();
        }
        private void Click(object sender, EventArgs e)
        {
            GunaButton btn = sender as GunaButton;
            btnLapHoaDon.BackColor = Color.FromArgb(100, 88, 255);
            btnTimKiemSach.BackColor = Color.FromArgb(100, 88, 255);
            btnLapPhieuNhap.BackColor = Color.FromArgb(100, 88, 255);
            SeparatorLapHoaDonBanSach.Hide();
            SeparatorLapPhieuNhapSach.Hide();
            SeparatorTimKiem.Hide();
            btn.BackColor = Color.FromArgb(151, 143, 255);
            if (btnLapHoaDon.BackColor == Color.FromArgb(151, 143, 255)){
                SeparatorLapHoaDonBanSach.Show();
                SeparatorLapPhieuNhapSach.Hide();
                SeparatorTimKiem.Hide();
                return;
            }
            else if (btnTimKiemSach.BackColor == Color.FromArgb(151, 143, 255)){
                SeparatorLapHoaDonBanSach.Hide();
                SeparatorLapPhieuNhapSach.Hide();
                SeparatorTimKiem.Show();
                return;
            }
            else if (btnLapPhieuNhap.BackColor == Color.FromArgb(151, 143, 255)){
                SeparatorLapHoaDonBanSach.Hide();
                SeparatorLapPhieuNhapSach.Show();
                SeparatorTimKiem.Hide();
                return;
            }
        }
        private void BtnTimKiemSach_Click(object sender, EventArgs e)
        {
            TimKiemSach timKiemSach = new TimKiemSach();
            panelInterface.Controls.Add(timKiemSach);
            timKiemSach.BringToFront();
        }

    }
}
