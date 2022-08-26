using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhieuDiemDanhDAO
    {
        private static PhieuDiemDanhDAO instance;

        public static PhieuDiemDanhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDiemDanhDAO();
                return instance;
            }
        }
        public DataTable LayDS_LichSuDiemDanh_LopMH(int idlopmh)
        {
            DataTable ds_LSDD = new DataTable();
            string query = "EXEC dbo.LAY_LICHSUDD_IDLOPMH @IDLOPMH";
            object[] parameter = new object[] { idlopmh };
            ds_LSDD = DataProvider.Instance.ExcuteQuery(query, parameter);
            return ds_LSDD;
        }
        public int TruyCap_MaPDDCuoiCung()
        {
            int ma = -1;
            DataTable dt = new DataTable();
            string query = "DECLARE @SO INT EXEC TRUYCAP_MAPDDCUOICUNG @SO OUTPUT SELECT @SO";
            dt = DataProvider.Instance.ExcuteQuery(query);
            ma = Int32.Parse(dt.Rows[0][0].ToString());
            return ma;
        }
        public int Insert_PhieuDiemDanh(PhieuDiemDanh pdd)
        {
            string query = "INSERT INTO PHIEUDIEMDANH VALUES( @MAPDD , @IDLOPMH , @TUANTHU , @NGAYDIEMDANH , @SOSINHVIENVANG )";
            object[] parameter = new object[] { pdd.Mapdd,pdd.Idlopmh,pdd.Tuanthu,pdd.Ngaydiemdanh,pdd.Sosinhvienvang };
            try
            {
                DataProvider.Instance.ExcuteQuery(query, parameter);
            }catch(Exception)
            {
                return -1;
            }
            return 1;
        }
        public int KiemTraKhoaNgoai_MonHoc_LopMonHoc(MonHoc_LopMonHoc mh_lmh)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM PHIEUDIEMDANH WHERE IDLOPMH = @IDLOPMH";
            object[] parameter = new object[] { mh_lmh.Idlopmh };
            dt = DataProvider.Instance.ExcuteQuery(query, parameter);
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }
        //EXEC KIEMTRA_LICHSUDIEMDANH 2,1
        public int KiemTra_LichSuDiemDanh(int idlopmh,int tuanthu)
        {
            DataTable dt = new DataTable();
            string query = "EXEC KIEMTRA_LICHSUDIEMDANH @ID , @TUAN";
            object[] parameter = new object[] { idlopmh,tuanthu };
            dt = DataProvider.Instance.ExcuteQuery(query,parameter);
            if (dt.Rows.Count != 0)
                return 1;
            return 0;    
        }
    }
}
