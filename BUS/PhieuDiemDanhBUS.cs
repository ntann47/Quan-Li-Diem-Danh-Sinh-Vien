using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhieuDiemDanhBUS
    {
        private static PhieuDiemDanhBUS instance;
        public static PhieuDiemDanhBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDiemDanhBUS();
                return instance;
            }
        }
        public DataTable LayDS_LichSuDiemDanh_LopMH(int idlopmh)
        {
            return PhieuDiemDanhDAO.Instance.LayDS_LichSuDiemDanh_LopMH(idlopmh);
        }
        public int TruyCap_MaPDDCuoiCung()
        {
            return PhieuDiemDanhDAO.Instance.TruyCap_MaPDDCuoiCung();
        }
        public int TruyCap_TuanHocCuoiCung(int idlopmonhoc)
        {
            return DataProvider.Instance.ExcuteQuery_TuanHoc(idlopmonhoc);
        }
        public int Insert_PhieuDiemDanh(PhieuDiemDanh pdd)
        {
            try
            {
                PhieuDiemDanhDAO.Instance.Insert_PhieuDiemDanh(pdd);
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int KiemTraKhoaNgoai_MonHoc_LopMonHoc(MonHoc_LopMonHoc mh_lmh)
        {

            return PhieuDiemDanhDAO.Instance.KiemTraKhoaNgoai_MonHoc_LopMonHoc(mh_lmh);
        }
        public int KiemTra_LichSuDiemDanh(int idlopmh, int tuanthu)
        {
            return PhieuDiemDanhDAO.Instance.KiemTra_LichSuDiemDanh(idlopmh, tuanthu);
        }
    }
}
