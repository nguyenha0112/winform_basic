using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaTayNguyen_3238.DAL
{
    internal class DalHoaDon
    {
        LopDungChung lopchung;
        public DalHoaDon()
        {
            lopchung = new LopDungChung();
        }
        public DataTable DalLoadGrid()
        {
            String sqlGrid = "select * from HoaDon";
            return lopchung.LoadDaTa(sqlGrid);
        }
        public void DalThem(string Mahd, string MaP,String MaKh,DateTime Ngayvao,DateTime ngayra)
        {
            string sqlThem = "INSERT INTO HoaDon (MaHd, MaP, MaKh, NgayVao, NgayRa)" +
                " VALUES ('" + Mahd + "', N'" + MaP + "', '" + MaKh + "', CONVERT(DATETIME, '" + Ngayvao + "', 103), CONVERT(DATETIME, '" + ngayra + "', 103));";
            lopchung.Nonquery(sqlThem);
        }
        public void DalSua(string Mahd, string MaP, String MaKh, DateTime Ngayvao, DateTime ngayra)
        {
            string sqlSua = "UPDATE HoaDon SET MaP = N'" + MaP + "', MaKh = N'" + MaKh + "'," +
                " NgayVao = CONVERT(DATETIME, '" + Ngayvao + "', 103), NgayRa = CONVERT(DATETIME, '" + ngayra + "', 103) WHERE MaHd = N'" + Mahd + "';";

            lopchung.Nonquery(sqlSua);
        }
        public void DalXoa(String mahd)
        {
            String sqlXoa = "delete from HoaDon where MaHd = '" + mahd + "'";
            lopchung.Nonquery(sqlXoa);
        }
    }
}
