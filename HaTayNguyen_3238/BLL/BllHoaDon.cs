using HaTayNguyen_3238.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaTayNguyen_3238.BLL
{
    internal class BllHoaDon
    {
        DAL.DalHoaDon dahd;
        HoaDon HD;
        public BllHoaDon(HoaDon fhd)
        {
            dahd = new DAL.DalHoaDon();
            HD = fhd;
        }
        public void BllGrid()
        {
            HD.dataGridView1.DataSource = dahd.DalLoadGrid();
        }
        public void BllThem()
        {
            dahd.DalThem(HD.txt_HD.Text,HD.txt_map.Text,HD.txt_makh.Text,HD.dateTime_ngayvao.Value,HD.dateTime_ngaydi.Value);
        }
        public void BllSua()
        {
            dahd.DalSua(HD.txt_HD.Text, HD.txt_map.Text, HD.txt_makh.Text, HD.dateTime_ngayvao.Value, HD.dateTime_ngaydi.Value);
        }
        public void BllXoa()
        {
            dahd.DalXoa(HD.txt_HD.Text);
        }

    }
}
