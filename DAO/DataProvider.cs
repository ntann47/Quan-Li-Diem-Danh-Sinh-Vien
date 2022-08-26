using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionStr = "Data Source=DESKTOP-V8JV470\\SQLEXPRESS; Initial Catalog=DDSV; User ID= sa; Password=123";

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }
        public DataTable ExcuteQuery(string query, object[] parameter=null)
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection c = new SqlConnection(connectionStr))
            {
                c.Open();
                SqlCommand command = new SqlCommand(query, c);
                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> lstPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            lstPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                        command.Parameters.AddWithValue(lstPara[i], parameter[i]);
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                c.Close();
            }
            return dt;
        }
        public int ExcuteNonQuery(string query, object[] parameter=null)
        {
            int affectedRows = 0;
            using (SqlConnection c = new SqlConnection(connectionStr))
            {
                c.Open();
                SqlCommand command = new SqlCommand(query, c);
                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> lstPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0].Equals('@'))
                            lstPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                        command.Parameters.AddWithValue(lstPara[i], parameter[i]);
                }
                affectedRows = command.ExecuteNonQuery();
                c.Close();
                return affectedRows;
            }


        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection c = new SqlConnection(connectionStr))
            {
                c.Open();
                SqlCommand command = new SqlCommand(query, c);
                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> lstPara = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item[0] == '@')
                            lstPara.Add(item);
                    }
                    for (int i = 0; i < parameter.Length; i++)
                        command.Parameters.AddWithValue(lstPara[i], parameter[i]);
                }
                data = command.ExecuteScalar();
                c.Close();
                return data;
            }
 
        }
        public int ExcuteQuery_TuanHoc(int idlopmonhoc)
        {
            int tuanthu = -1;
         
            using (SqlConnection c = new SqlConnection(connectionStr))
            {
                c.Open();
                SqlCommand command = new SqlCommand("TRUYCAP_TUANHOCCUOICUNG",c);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IDLOPMH", idlopmonhoc);
                command.Parameters.Add("@TUAN", SqlDbType.Int);
                command.Parameters["@TUAN"].Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                tuanthu = Int32.Parse(command.Parameters["@TUAN"].Value.ToString());
                c.Close();
            }
            return tuanthu;
        }
        public object LaySiSo_LopMonHoc(int idlopmh)
        {
            object sosv = 0;
            string query = "SELECT dbo.dbo.LAYSISOLOP( @IDLOPMH )";
            object[] parameter = new object[] { idlopmh };
            sosv = DataProvider.Instance.ExcuteScalar(query, parameter);
            return sosv;
        }

    }

}
