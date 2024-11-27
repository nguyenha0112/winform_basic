using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaTayNguyen_3238.DAL
{
    internal class DalKhachHang
    {
        LopDungChung lopchung;
        public DalKhachHang()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from KhachHang";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public void DalThem(String makh, String hoTen,String sdt, string tenhinh)
        {
            String sqlThem = "insert into KhachHang values('" + makh + "', N'" + hoTen + "','"+sdt+"','"+tenhinh+"')";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(String makh, String hoTen, String sdt, string tenhinh)
        {
            String sqlSua = "update KhachHang set  TenKh = N'" + hoTen + "',SDT = '"+sdt+"',HinhAnh =N'"+tenhinh+"'where MaKh =N'" + makh + "'";
            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(String makh)
        {
            String sqlXoa = "delete from KhachHang where MaKh = '" + makh + "'";
            lopchung.Nonquery(sqlXoa);
        }
        public DataTable DalTim(String tim)
        {
            String sqlGrid = "select * from KhachHang where MaKh like '%" + tim + "%' or" +
                " TenKh like '%" + tim + "%'";
            return lopchung.LoadDaTa(sqlGrid);
        }
    }
}
