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
    public partial class home : Form
    {
        DB_Operations dbConn = new DB_Operations();
        
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration register = new Registration();
            register.Show();

            //dbConn.Conn.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = dbConn.Conn;
            //cmd.CommandText = "select stu_name from Astudent";
            //cmd.CommandType = CommandType.Text;
            //OracleDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //list.Text = dr.GetString(0);
            //dbConn.Conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList newList = new StudentList();
            newList.Show();
        }
    }
}
