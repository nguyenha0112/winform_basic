using HaTayNguyen_3238.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaTayNguyen_3238.BLL
{
    internal class BllKhachHang
    {
        
            DAL.DalKhachHang daKh;
            QuanLyKH KH;
            public BllKhachHang(QuanLyKH fKh)
            {
                daKh = new DAL.DalKhachHang();
                KH = fKh;
            }
            public void BllGrid()
            {
               KH.dataGridView1.DataSource = daKh.DalLoadGrid();
            }
        public void BllThem()
        {
            daKh.DalThem(KH.txt_Makh.Text,KH.txt_tenhk.Text,KH.txt_sdt.Text,KH.txt_tenHinh.Text);
        }
        public void BllSua()
        {daKh.DalSua(KH.txt_Makh.Text, KH.txt_tenhk.Text, KH.txt_sdt.Text, KH.txt_tenHinh.Text);
           
        }
        public void BllXoa()
        {
            daKh.DalXoa(KH.txt_Makh.Text);
        }
        public void Blltim()
        {
            KH.dataGridView1.DataSource= daKh.DalTim(KH.txt_Tim.Text);
        }


    }
}
