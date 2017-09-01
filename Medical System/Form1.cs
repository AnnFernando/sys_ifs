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
    public partial class login : Form
    {
        DB_Operations dbConn = new DB_Operations();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uname.Clear();
            pw.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            //validate credentials
            Boolean valid;
            valid = validateUser();

            if (valid)
            {
                this.Hide();
                home newHome = new home();
                newHome.Show();
            }
            else             
            {
                MessageBox.Show("The credentials are invalid !!!!");
                uname.Clear();
                pw.Clear();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public Boolean validateUser() 
        {
            String name = uname.Text;
            String pass = pw.Text;
            

            dbConn.Conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbConn.Conn;
            cmd.CommandText = "validate_user";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("uname", OracleDbType.Varchar2, 20).Value = name;
            cmd.Parameters.Add("pw", OracleDbType.Varchar2, 100).Value = pass;
            cmd.Parameters.Add("exist ", OracleDbType.Int32).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
          
            int exist =Convert.ToInt32(cmd.Parameters[2].Value);
            dbConn.Conn.Dispose();

            if (exist == 1)
                return true;
            else
                return false;
        }
    }
}
