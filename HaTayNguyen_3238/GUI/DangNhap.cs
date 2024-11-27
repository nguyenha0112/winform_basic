using HaTayNguyen_3238.DAL;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
        }
        LopDungChung lopchung;


        private void btn_them_Click(object sender, EventArgs e)
        {
            String sqlDN = "select count (*) from TaiKhoan " +
                            "where TaiKhoan = '" + txt_TK.Text + "' and MatKhau = '" + txt_MK.Text + "'";
            int kq = (int)lopchung.Scalar(sqlDN);
            if (kq >= 1)
            {
                TrangChu tc = new TrangChu();
                tc.Show();
                this.Hide();
            }
            else MessageBox.Show("Sai tên ĐN hoặc MK");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlDN = "select count (*) from TaiKhoan " +
                           "where TaiKhoan = '" + txt_TK.Text + "'";
            int check = (int)lopchung.Scalar(sqlDN) ;
            string sqldem = "select count (*) from TaiKhoan";
            int kq = (int)lopchung.Scalar(sqldem) + 1;
            string matk = "TK" + kq.ToString();
            if (txt_TK.Text.Length == 0 || txt_MK.Text.Length == 0)
            {
                MessageBox.Show("khong duoc bo trong");
            }
            else if(check>=1)
            {
                MessageBox.Show("tai khoan da duoc dang ki");
            }
            else
            {
                String sqlThem = "insert into TaiKhoan values('" + matk + "','" + txt_TK.Text + "','" + txt_MK.Text + "')";
                lopchung.Nonquery(sqlThem);
            }

        }
        bool tam = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tam)
            {
                txt_MK.PasswordChar = '\0';
                tam = !tam;
            }
            else
            {
                txt_MK.PasswordChar = '*';
                tam = !tam;
            }
        }
    }
}
