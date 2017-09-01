using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace Medical_System
{
    class DB_Operations
    {
        static string oradb = "Data Source=cmbtrndb02/app8sp2;User Id=ifsapp;Password=ifsapp;";
        private OracleConnection conn;

        public DB_Operations()
        {
            conn = new OracleConnection(oradb);

        }

        public OracleConnection Conn
        {
            get { return conn; }
           
        }


        //public void insertData(DB_Operations dbConn, )
        //{
        //    dbConn.Conn.Open();
        //    OracleCommand cmd = new OracleCommand();
        //    cmd.Connection = dbConn.Conn;
        //    cmd.CommandText = "Insert_new_student";
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("stu_id", OracleDbType.Int32, 6).Value = s_id;
        //    cmd.Parameters.Add("stu_name", OracleDbType.Varchar2, 100).Value = s_name;
        //    cmd.Parameters.Add("stu_grade", OracleDbType.Int32, 5).Value = s_grade;
        //    cmd.Parameters.Add("stu_address", OracleDbType.Varchar2, 200).Value = s_address;
        //    cmd.Parameters.Add("stu_gender", OracleDbType.Varchar2, 10).Value = s_gender;

        //    cmd.ExecuteNonQuery();
        //    dbConn.Conn.Dispose();
        
        //}

        
    }
}
