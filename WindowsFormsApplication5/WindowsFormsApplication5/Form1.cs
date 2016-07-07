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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<student> list = new List<student>();

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = @"Server=.\sqlexpress;database=myschool;integrated security=true";
            SqlConnection conn = new SqlConnection(strConn);
            string name = "四学期";
            try
            {
                conn.Open();
                ////  string sql = "update grade set gradename ='三学期' where gradeid=3";
                //string sql = "insert into grade(gradename)values('"+name+"')";
                //SqlCommand cmd = new SqlCommand(sql,conn);
                //int count = cmd.ExecuteNonQuery();
                //if(count>0)
                //{
                //    MessageBox.Show("操作成功");
                //}
                //string sql = "select count(*) from student";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //int count = (int)cmd.ExecuteScalar();
                //MessageBox.Show(count.ToString())
                string sql = "select * from student";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                list.Clear();
               // this.comboBox1.Items.Clear();
                while(dr.Read())
                {
                    //  MessageBox.Show(dr["studentname"].ToString());
                   // this.comboBox1.Items.Add(dr["studentname"].ToString());
                    student stu = new student();
                    
                    stu.StudnetNO = (int)dr["studentno"];
                    stu.StudnetName = dr["studentname"].ToString();
                    stu.LoginPwd = dr["loginpwd"].ToString();
                    stu.Email = dr["email"].ToString();
                    stu.BornDate = (DateTime)dr["borndate"];
                    list.Add(stu);
                    
                }
               
                dr.Close();
                this.dataGridView1.DataSource = list;
                this.comboBox1.DataSource = list;
                this.comboBox1.DisplayMember = "studentname";
                this.comboBox1.ValueMember = "studentno";
;            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
          


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string strConn = @"Server=.\sqlexpress;database=myschool;integrated security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            string strname = this.comboBox1.SelectedItem.ToString();
            string sql = "select * from student where studentname='" + strname + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
