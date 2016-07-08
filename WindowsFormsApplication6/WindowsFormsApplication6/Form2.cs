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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string strConn = @"Server=.\sqlexpress;database=myschool;integrated security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string sql = "select * from vstudent";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "gradename";
            this.comboBox1.ValueMember = "gradeid";
            this.dataGridView1.DataSource = dt;
            dr.Close();

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Server=.\sqlexpress;database=myschool;integrated security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string stname = this.comboBox1.SelectedValue.ToString();
            string sql = "select * from vstudent where gradeid='"+stname+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.dataGridView1.DataSource = dt;
            dr.Close();

            conn.Close();
        }
    }
}
