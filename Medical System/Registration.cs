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
    
        
    public partial class Registration : Form
    {
        DB_Operations dbConn = new DB_Operations();

        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s_id = Convert.ToInt32(id.Text);
            String s_name = name.Text;
            int s_grade = Convert.ToInt32(grade.Text);
            String s_address = address.Text;

            String s_gender = null;
            if (radioButton1.Checked)
                s_gender = radioButton1.Text;
            else if (radioButton2.Checked)
                s_gender = radioButton2.Text;

            dbConn.Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbConn.Conn;
            cmd.CommandText = "Insert_new_student";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("stu_id", OracleDbType.Int32, 6).Value = s_id;
            cmd.Parameters.Add("stu_name", OracleDbType.Varchar2, 100).Value = s_name;
            cmd.Parameters.Add("stu_grade", OracleDbType.Int32, 5).Value = s_grade;
            cmd.Parameters.Add("stu_address", OracleDbType.Varchar2, 200).Value = s_address;
            cmd.Parameters.Add("stu_gender", OracleDbType.Varchar2, 10).Value = s_gender;
            
            cmd.ExecuteNonQuery();
            dbConn.Conn.Dispose();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
