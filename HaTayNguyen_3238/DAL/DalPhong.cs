using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaTayNguyen_3238.DAL
{
    internal class DALPhong
    {
        LopDungChung lopchung;

        public string tenhinh { get; private set; }

        public DALPhong()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from Phong";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public DataTable DalLoadCombo()
        {
            String sqlGrid = "select * from Phong ";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public int DalDem()
        {
            String sqlDem = "select COUNT (*) from Phong";
            int kq = (int)lopchung.Scalar(sqlDem);
            return kq;
        }
        public DataTable DalLocCombo(String trangthai)
        {
            String sqlGrid = "select * from Phong where TrangThai =N'" + trangthai + "'";
            return lopchung.LoadDaTa(sqlGrid);

        }
        public void DalThem(String Map, String Sop, String TrangThai, string LoaiP, string giatien)
        {
            String sqlThem = "insert into Phong values('" + Map + "', N'" + Sop + "',N'" + TrangThai + "',N'" + LoaiP + "','"+float.Parse(giatien)+"')";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(String Map, String Sop, String TrangThai, String LoaiP, String giatien)
        {
            String sqlSua = "update Phong set  SoP =N'" + Sop + "',TrangThai =N'" + TrangThai + "',loaiP =N'" + LoaiP + "', GiaTien ='"+giatien+"'where MaP =N'"+Map+"'";
            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(String map)
        {
            String sqlXoa = "delete from Phong where MaP = '" + map + "'";
            lopchung.Nonquery(sqlXoa);
        }
    }
}
