using HaTayNguyen_3238.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaTayNguyen_3238.BLL
{
    internal class BllPhong
    {
        DAL.DALPhong dap;
        Phong P;
        public BllPhong(Phong fP)
        {
            dap = new DAL.DALPhong();
            P = fP;
        }
        public void BllGrid()
        {
            P.dataGridView1.DataSource = dap.DalLoadGrid();
        }
        public void Bllloadcombo()
        {
            P.cb_trangthai.DataSource = dap.DalLoadCombo();
            P.cb_trangthai.DisplayMember = "TrangThai";
            P.cb_trangthai.ValueMember ="TrangThai";
        }
        public void Blldem() {
            P.txt_Dem.Text = dap.DalDem().ToString();
        }

        public void BllThem()
        {
           dap.DalThem(P.txt_map.Text,P.txt_sop.Text,P.cb_trangthai.SelectedValue.ToString(),P.txt_LoaiP.Text,P.txt_giatien.Text);
        }
        public void BllSua()
        {
            dap.DalSua(P.txt_map.Text, P.txt_sop.Text, P.cb_trangthai.SelectedValue.ToString(), P.txt_LoaiP.Text, P.txt_giatien.Text);

        }
        public void BllXoa()
        {
            dap.DalXoa(P.txt_map.Text);
        }
        public void BllLocCombo()
        {
            P.dataGridView1.DataSource = dap.DalLocCombo(P.cb_trangthai.SelectedValue.ToString());
        }
    }
}
