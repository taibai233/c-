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

namespace WindowsFormsApplication5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string strConn = @"Server=.\sqlexpress;database=myschool;integrated security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string sql = "";
            sql = "select * from grade";
            SqlCommand cmd = null;
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt;
            dt = new DataTable();
            dt.Load(dr);
            this.comboBox1.DataSource = dt;
            this.comboBox1.DisplayMember = "gradename";
            this.comboBox1.ValueMember = "gradeid";
            conn.Close();
        }
    }
}
