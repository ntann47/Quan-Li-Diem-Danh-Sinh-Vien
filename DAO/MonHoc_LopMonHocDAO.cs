using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class MonHoc_LopMonHocDAO
    {
        private static MonHoc_LopMonHocDAO instance;

        public static MonHoc_LopMonHocDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonHoc_LopMonHocDAO();
                return instance;
            }
        }
        public MonHoc_LopMonHoc LayThongTin_MonHoc_LopMH(int idlopmh)
        {
            DataTable dt_lopmh = new DataTable();
            string query = "SELECT * FROM MONHOC_LOPMONHOC WHERE IDLOPMH = @IDLOPMH";
            object[] parameter = new object[] { idlopmh };
            dt_lopmh = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt_lopmh.Rows.Count != 0)
            {
                int idlopmomhoc = Int32.Parse(dt_lopmh.Rows[0][0].ToString().Trim());
                string malopmh = dt_lopmh.Rows[0][1].ToString().Trim();
                string mamh = dt_lopmh.Rows[0][2].ToString().Trim();
                string magv = dt_lopmh.Rows[0][3].ToString().Trim();
                int hocky = Int32.Parse(dt_lopmh.Rows[0][4].ToString().Trim());
                string namhoc = dt_lopmh.Rows[0][5].ToString().Trim();
                int sobuoihoc = Int32.Parse(dt_lopmh.Rows[0][6].ToString().Trim());
                DateTime ngaybatdau = DateTime.Parse(dt_lopmh.Rows[0][7].ToString().Trim());
                DateTime ngayketthuc = DateTime.Parse(dt_lopmh.Rows[0][8].ToString().Trim());
                int siso = Int32.Parse(dt_lopmh.Rows[0][9].ToString().Trim());
                string maphonghoc = dt_lopmh.Rows[0][10].ToString().Trim();
                string macahoc = dt_lopmh.Rows[0][11].ToString().Trim();
                string trangthai = dt_lopmh.Rows[0][12].ToString().Trim();
                MonHoc_LopMonHoc x = new MonHoc_LopMonHoc(idlopmomhoc,malopmh, mamh, magv,hocky,namhoc,sobuoihoc,ngaybatdau,ngayketthuc,siso,maphonghoc,macahoc,trangthai);
                return x;
            }
            return null;
        }
        public int Insert_MonHoc_LopMonHoc(MonHoc_LopMonHoc mh_lmh)
        {
            int rows = -1;
            string query = "EXEC dbo.INSERT_MONHOC_LOPMONHOC @IDLOPMH , @MALOPMH , @MAMH , @HOCKY , @NAMHOC , @SOBUOIHOC , @NGAYBATDAU , @NGAYKETTHUC , @SISO , @MAPHONGHOC , @MACAHOC , @TRANGTHAI";
            object[] parameter = new object[] { mh_lmh.Idlopmh, mh_lmh.Malopmh, mh_lmh.Mamh, mh_lmh.Hocky, mh_lmh.Namhoc,mh_lmh.Sobuoihoc,mh_lmh.Ngaybatdau,mh_lmh.Ngayketthuc,mh_lmh.Siso,mh_lmh.Maphonghoc, mh_lmh.Macahoc,mh_lmh.Trangthai };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Update_MonHoc_LopMonHoc(MonHoc_LopMonHoc x)
        {
            int rows = -1;
            string query = "EXEC dbo.UPDATE_MOCHOC_LOPMONHOC_GV @IDLOPMH , @MALOPMH , @MAMH , @MAGIANGVIEN , @HOCKY , @NAMHOC , @SOBUOIHOC , @NGAYBATDAU , @NGAYKETTHUC , @SISO , @MAPHONGHOC , @MACAHOC , @TRANGTHAI";
            object[] parameter = new object[] { x.Idlopmh,x.Malopmh,x.Mamh,x.Magiangvien,x.Hocky,x.Namhoc,x.Sobuoihoc,x.Ngaybatdau,x.Ngayketthuc,x.Siso,x.Maphonghoc,x.Macahoc,x.Trangthai };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;

        }
        public int Update_GV_MonHoc_LopMonHoc(MonHoc_LopMonHoc x, string magv)
        {
            int rows = -1;
            string query = "UPDATE MONHOC_LOPMONHOC SET MAGIANGVIEN = @MAGIANGVIEN WHERE IDLOPMH = @IDLOPMH";
            object[] parameter = new object[] { magv,x.Idlopmh };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Delete_MonHoc_LopMonHoc(MonHoc_LopMonHoc x)
        {
            int rows = -1;
            string query = "DELETE FROM MONHOC_LOPMONHOC WHERE IDLOPMH = @IDLOPMH";
            object[] parameter = new object[] { x.Idlopmh};
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public DataTable Load_DSMH_LMH()
         {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM MONHOC_LOPMONHOC";
            dt = DataProvider.Instance.ExcuteQuery(query);
            return dt;
        }
        public DataTable Load_DSLopMonHocTheoMaMonHoc(string mamh)
        {
            DataTable dt = new DataTable();
            string query = "EXEC dbo.HIENTHI_DSLOPMONHOCTHEOMON @MAMH";
            object[] parameter = new object[] { mamh };
            dt = DataProvider.Instance.ExcuteQuery(query,parameter);
            return dt;
        }
        //
        public DataTable TongKetVang_LopMonHoc(MonHoc_LopMonHoc x)
        {
            DataTable dt = new DataTable();
            string query = "EXEC dbo.TONGKETVANG_LOPMONHOC @IDLOPMONHOC";
            object[] parameter = new object[] { x.Idlopmh };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            return dt;
        }
        public int KiemTraKhoaNgoai_GiangVien(GiangVien gv)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM MONHOC_LOPMONHOC WHERE MAGIANGVIEN = @MAGV";
            object[] parameter = new object[] { gv.Magiangvien };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }
        public int KiemTraKhoaNgoai_MonHoc(MonHoc mh)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM MONHOC_LOPMONHOC WHERE MAMH = @MA";
            object[] parameter = new object[] { mh.Mamh };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }
        public int LaySiSo_LopMonHoc(int idlopmh)
        {
            int sosv = 0;
            string query = "SELECT dbo.LAYSISOLOP( @IDLOPMH )";
            object[] parameter = new object[] { idlopmh };
            sosv = (int) DataProvider.Instance.ExcuteScalar(query, parameter);
            return sosv;
        }
    }
}
