using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitaplon.Model
{
    internal class ProcessConnect
    {
        private SqlConnection sqlConnection;
        private string string_connect;


        private SqlDataAdapter dataAdapter; //cầu nối giữa db vs datatable, dataset

        private SqlCommand sqlCommand; //thực thi câu lệnh truy vấn

        public ProcessConnect(string str_connect)
        {
            this.string_connect = str_connect;
        }




        //show ra datatable
        public DataTable getTable(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(table);
                sqlConnection.Close();
            }

            return table;

        }

        //thuwjc hiện truy vấn insert, delete, update
        public void Excute(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(string_connect))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }




    }
}
