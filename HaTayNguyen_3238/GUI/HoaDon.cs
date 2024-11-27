using HaTayNguyen_3238.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaTayNguyen_3238.GUI
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            bllhd = new BLL.BllHoaDon(this);
        }
        BLL.BllHoaDon bllhd;
        private void HoaDon_Load(object sender, EventArgs e)
        {
            loadgird();
        }
        public void loadgird()
        {
            bllhd.BllGrid();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bllhd.BllThem();
            loadgird();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bllhd.BllSua();
            loadgird();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bllhd.BllXoa();
            loadgird();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_HD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_map.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_makh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTime_ngayvao.Text = dataGridView1.CurrentRow.Cells["NgayVao"].Value.ToString();
            dateTime_ngaydi.Text = dataGridView1.CurrentRow.Cells["NgayRa"].Value.ToString();


        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTime_ngayvao_ValueChanged(object sender, EventArgs e)
        {
            int sothang = dateTime_ngaydi.Value.Month - dateTime_ngayvao.Value.Month;
            int songay = dateTime_ngaydi.Value.Day - dateTime_ngayvao.Value.Day +(sothang * 30);
            txt_songay.Text = songay.ToString();
        }

        private void dateTime_ngaydi_ValueChanged(object sender, EventArgs e)
        {
            int sothang = dateTime_ngaydi.Value.Month - dateTime_ngayvao.Value.Month;
            int songay = dateTime_ngaydi.Value.Day - dateTime_ngayvao.Value.Day + (sothang * 30);
            txt_songay.Text = songay.ToString();
        }
    }
}
