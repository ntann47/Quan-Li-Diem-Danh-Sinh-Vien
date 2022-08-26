using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class GiangVienDAO
    {
        private static GiangVienDAO instance;

        public static GiangVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiangVienDAO();
                return instance;
            }
        }
        public GiangVien LayThongTin_GV(string magv)
        {
            GiangVien gv = new GiangVien();
            DataTable dt_GV = new DataTable();
            string query = "SELECT * FROM GIANGVIEN WHERE MAGIANGVIEN = @MAGV";
            object[] parameter = new object[] { magv.Trim() };
            dt_GV = DataProvider.Instance.ExcuteQuery(query,parameter);
            if(dt_GV.Rows.Count!=0)
            {

                string ma = dt_GV.Rows[0][0].ToString().Trim();
                string ten = dt_GV.Rows[0][1].ToString().Trim();
                string gioitinh = dt_GV.Rows[0][2].ToString().Trim();
                string ngsinh = dt_GV.Rows[0][3].ToString().Trim();
                DateTime dt_ngsinh = DateTime.Parse(ngsinh);
                string trinhdo = dt_GV.Rows[0][4].ToString().Trim();
                string makhoa = dt_GV.Rows[0][5].ToString().Trim();
                gv = new GiangVien(ma, ten, gioitinh, dt_ngsinh, trinhdo, makhoa);
                return gv;
            }
            return null;          
        }    
        public DataTable Load_DanhSach_GiangVien()
        {
            DataTable dt_GV = new DataTable();
            string query = "SELECT * FROM GIANGVIEN";
            dt_GV = DataProvider.Instance.ExcuteQuery(query); 
            return dt_GV;
        }
        public DataTable Load_DSLop_GV(string magv)
        {
            DataTable ds_Lop = new DataTable();
            string query = "EXEC dbo.LAYDSLOP_GV @MAGV";
            object[] parameter = new object[] { magv.Trim() };
            ds_Lop = DataProvider.Instance.ExcuteQuery(query, parameter);
            return ds_Lop;
        }
        public DataTable Load_DSCBMH_GV(string magv)
        {
            DataTable ds_MH = new DataTable();
            string query = "EXEC dbo.LAYDSCBMONHOC_GV @MAGV";
            object[] parameter = new object[] { magv.Trim() };
            ds_MH = DataProvider.Instance.ExcuteQuery(query, parameter);
            return ds_MH;
        }
        public DataTable Load_DSLopDiemDanh_GV(string magv,string tenmh)
        {
            DataTable ds_LopDD = new DataTable();
            string query = "EXEC dbo.LAYDSLOPDIEMDANH_GV @MAGV , @TENMH";
            object[] parameter = new object[] { magv.Trim(),tenmh.Trim() };
            ds_LopDD= DataProvider.Instance.ExcuteQuery(query, parameter);
            return ds_LopDD;
        }
        public int Insert_GiangVien(GiangVien gv)
        {
            int rows = -1;
            string query = "EXEC dbo.INSERT_GIANGVIEN @MAGIANGVIEN , @HOTENGV , @GIOITINH , @NGAYSINH , @TRINHDO , @MAKHOA";
            object[] parameter = new object[] { gv.Magiangvien,gv.Hotengv,gv.Gioitinh,gv.Ngaysinh,gv.Trinhdo,gv.Makhoa };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Update_GiangVien(GiangVien gv)
        {
            int rows = -1;
            string query = "EXEC dbo.UPDATE_GIANGVIEN @MAGIANGVIEN , @HOTENGV , @GIOITINH , @NGAYSINH , @TRINHDO , @MAKHOA";
            object[] parameter = new object[] { gv.Magiangvien, gv.Hotengv, gv.Gioitinh, gv.Ngaysinh, gv.Trinhdo, gv.Makhoa };
            DataProvider.Instance.ExcuteNonQuery(query, parameter);
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int Delete_GiangVien(GiangVien gv)
        {
            int rows = -1;
            string query = "DELETE FROM GIANGVIEN WHERE MAGIANGVIEN = @MAGIANGVIEN";
            object[] parameter = new object[] { gv.Magiangvien };
            rows = DataProvider.Instance.ExcuteNonQuery(query, parameter);
            return rows;
        }
        public int KiemTraKhoaNgoai_GiangVien(TaiKhoan tk)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM GIANGVIEN WHERE MAGIANGVIEN = @TENTAIKHOAN";
            object[] parameter = new object[] { tk.Tentaikhoan };
            dt = DataProvider.Instance.ExcuteQuery(query,parameter);
            if (dt.Rows.Count != 0)
                return 1;
            return 0;
        }
    }
}
