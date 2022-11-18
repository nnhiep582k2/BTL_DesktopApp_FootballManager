using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;

namespace baitaplon.View
{
    internal class ConnAdd
    {
        private SqlConnection sqlConnection;
        private string string_connect = "Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True";

        private SqlDataAdapter dataadapter;// chen du lieu vao bang
        private SqlCommand sqlcommand; //thu thi cau lenh truy van

        public DataTable table(String query) //lay bang ddo du lieu
        {
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                dataadapter = new SqlDataAdapter(query, sqlConnection);
                dataadapter.Fill(datatable);
                sqlConnection.Close();
            }
            return datatable;

        }
        public void Excute_new(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                SqlCommand comm = new SqlCommand(query, sqlConnection);
                comm.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public void Excute( DoiBong doibong,String query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                sqlcommand = new SqlCommand(query, sqlConnection);
                sqlcommand.Parameters.Add("@madoi", doibong.Madb);
                sqlcommand.Parameters.Add("@tendoi", doibong.Tendb);
                sqlcommand.Parameters.Add("@hlv", doibong.Hvldb);
                sqlcommand.Parameters.Add("@anh", doibong.Anh);
                sqlcommand.Parameters.Add("@masan", doibong.Masan);
                sqlcommand.Parameters.Add("@matinh", doibong.Matinh);
                sqlcommand.ExecuteNonQuery();//thu thi cau lenh
                sqlConnection.Close();

            }

        }
    }
}
