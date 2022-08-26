using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LichSuVangDAO
    {
        private static LichSuVangDAO instance;

        public static LichSuVangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichSuVangDAO();
                return instance;
            }
        }
        public DataTable LayDS_LichSuVang_PDD(int mapdd)
        {
            DataTable ds_LSV = new DataTable();
            string query = "SELECT L.MASV,L.HOTENSV,L.GIOITINH,L.LOPNIENCHE,L.LYDOVANG FROM LICHSUVANG L WHERE MAPDD = @MAPDD";
            object[] parameter = new object[] { mapdd };
            ds_LSV = DataProvider.Instance.ExcuteQuery(query, parameter);
            return ds_LSV;
        }
        public int Insert_LichSuVang(LichSuVang lsv)
        {
            
            int rows = -1;
            string query = "INSERT INTO LICHSUVANG VALUES( @MAPDD , @ID , @MASV , @HOTENSV , @GIOITINH , @NGAYSINH , @LOPNIENCHE , @LIDOVANG )";
            object[] parameter = new object[] { lsv.Mapdd, lsv.Id, lsv.Masv, lsv.Hotensv, lsv.Gioitinh, lsv.Ngaysinh, lsv.Lopnienche, lsv.Lydovang };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }

        public int KiemTraKhoaNgoai_SinhVien(SinhVien sv)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM LICHSUVANG WHERE MASV = @MASV";
            object[] parameter = new object[] { sv.Masv };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
