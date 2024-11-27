using HaTayNguyen_3238.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaTayNguyen_3238.GUI
{
    public partial class QuanLyKH : Form
    {
       
        public QuanLyKH()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bllkh = new BLL.BllKhachHang(this);
        }
        LopDungChung lopchung;
        BLL.BllKhachHang bllkh;
        private void QuanLyKH_Load(object sender, EventArgs e)
        {
            LoadGrid(); 
        }
        public void LoadGrid()
        {
            bllkh.BllGrid();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(duongdan + txt_tenHinh.Text);
            bllkh.BllThem();
            LoadGrid();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(duongdan + txt_tenHinh.Text);
            bllkh.BllSua();
            LoadGrid();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            File.Delete(duongdan + txt_tenHinh.Text);
            bllkh.BllXoa();
            LoadGrid();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            bllkh.Blltim();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Makh.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_tenhk.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sdt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_tenHinh.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn hình";
            ofd.Filter = "Tất cả đuôi|*.*|Đuôi jpg|*.jpg|Đuôi png|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
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

        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.ShowDialog();
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.ShowDialog();
        }
    }
}
