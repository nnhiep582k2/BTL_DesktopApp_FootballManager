using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace baitaplon
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<TaiKhoan>TaiKhoans(string query)//dung de check tk
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                sqlCommand = new SqlCommand(query, conn);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1)));
                }
                conn.Close();
            }
            return taiKhoans;
        }
        public void Command(String query)//dung de dang ky tk
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                sqlCommand= new SqlCommand(query, conn);
                sqlCommand.ExecuteNonQuery();//Thuc thi cau truy van
                conn.Close();

            }    
        }
    }
}
