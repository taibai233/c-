using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtAccount.Text.Trim();
            string pwd = txtPwd.Text.Trim();

            string strConn = @"Server=.\sqlexpress;database=myschool;integrated security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            //string sql="select * from student where studentno='"+name+"'and loginpwd='"+pwd+"'";
            
            SqlCommand cmd = new SqlCommand("prologin", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studo", SqlDbType.NVarChar, 50).Value = name;
            cmd.Parameters.Add("@stupwd", SqlDbType.NVarChar, 50).Value = pwd;

            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("登录成功");

            }
            else
            {
                MessageBox.Show("登录失败");
            }
            dr.Close();
            conn.Close();
        }
    }
}
