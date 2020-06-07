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
    public partial class TimKiemSach : UserControl
    {
        int soSach;
        System.Data.DataTable dataTable;
        public TimKiemSach()
        {
            InitializeComponent();
            AutoSize = true;
            dataTable = Interface.databaseHelper.GetDatabase("Select * from  dbo.[Sach];");
            soSach = dataTable.Rows.Count;
            trackBarPage.Value = 1;
            trackBarPage.Maximum = soSach / 25;
            if (soSach % 25 != 0)
                trackBarPage.Maximum++;

        }
        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            //Viết đầy đủ câu lệnh sql
            string sql = "Select * From dbo.[Sach] where Ten like N'%" + txtTimKiem.Text + "%';";
            dataTable = Interface.databaseHelper.GetDatabase(sql);
            soSach = dataTable.Rows.Count;
            pnlHienThi.Controls.Clear();
            if (trackBarPage.Maximum == 1)
                HienThiSachDacBiet();
            else
                HienThiSach(trackBarPage.Value);
            pnlHienThi.Invalidate();
        }
        private void TrackBarPage_Scroll(object sender, EventArgs e)
        {
            btnTimKiem.Text = trackBarPage.Value.ToString();
            pnlHienThi.Controls.Clear();
            if (trackBarPage.Maximum == 1)
                HienThiSachDacBiet();
            else
                HienThiSach(trackBarPage.Value);
            pnlHienThi.Invalidate();
        }

        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            if (trackBarPage.Maximum == 1)
                trackBarPage.Hide();
            HienThiSach(trackBarPage.Value);
        }
        void HienThiSachDacBiet()
        {
            for (int i = 0; i < soSach; i++)
            {
                Sach newSach = new Sach(int.Parse(dataTable.Rows[i][0].ToString()), dataTable.Rows[i][1].ToString(), int.Parse(dataTable.Rows[i][6].ToString()), int.Parse(dataTable.Rows[i][5].ToString()));
                pnlHienThi.Controls.Add(newSach);
            }
        }
        void HienThiSach(int page)
        {
            for (int i = 0; i < 25 && (page - 1) * 25 + i < soSach && i < soSach; i++)
            {
                Sach newSach = new Sach(int.Parse(dataTable.Rows[i][0].ToString()), dataTable.Rows[i][1].ToString(), int.Parse(dataTable.Rows[i][6].ToString()), int.Parse(dataTable.Rows[i][5].ToString()));
                pnlHienThi.Controls.Add(newSach);
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            pnlHienThi.Controls.Clear();
            dataTable = Interface.databaseHelper.GetDatabase("Select * from  dbo.[Sach];");
            if (trackBarPage.Maximum == 1)
                trackBarPage.Hide();
            HienThiSach(trackBarPage.Value);
        }
    }
}
