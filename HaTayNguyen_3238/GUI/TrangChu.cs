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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyKH quanLyKH = new QuanLyKH();
            quanLyKH.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();  
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
            this.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKH quanLyKH = new QuanLyKH();
            quanLyKH.Show();
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.Show();
        }

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
        }
    }
}
