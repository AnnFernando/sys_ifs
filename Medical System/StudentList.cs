using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Medical_System
{
    public partial class StudentList : Form
    {
        DB_Operations dbConn = new DB_Operations();

        public StudentList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            dbConn.Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbConn.Conn;
            cmd.CommandText = "retrieveData";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("stu_id ", OracleDbType.Int32,10).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("stu_name ", OracleDbType.Varchar2,20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("stu_address ", OracleDbType.Varchar2,100).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            this.dataGridView1.Rows.Add(Convert.ToString(cmd.Parameters[0].Value), Convert.ToString(cmd.Parameters[1].Value), Convert.ToString(cmd.Parameters[2].Value));
            dbConn.Conn.Dispose();
           
        }
    }
}
