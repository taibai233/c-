using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form1 f1;
        public student_hzw st1;
        public Form2(Form1 _f1)
        {
            InitializeComponent();
             f1 = _f1;
        }
        public Form2(Form1 _f1,student_hzw _st1)
        {
            InitializeComponent();
            f1 = _f1;
            st1 = _st1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_hzw st = new student_hzw();
            st.Name_hzw =Name.Text;
            st.Sex_hzw = Sex.Text;
            st.PhoneNumber_hzw = Name.Text;
            st.Job_hzw = Job.Text;
            st.Adress_hzw = Adress.Text;            st.FriendShip = Relationship.Text;
            f1.Ph.Add(st.Name_hzw, st);
            f1.FullData(f1.Ph);
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (st1 != null)
            {
                Name.Text = st1.Name_hzw;
                Sex.Text = st1.Sex_hzw;
                Name.Text = st1.PhoneNumber_hzw;
                Job.Text = st1.Job_hzw;
                Adress.Text = st1.Adress_hzw;
                Relationship.Text = st1.FriendShip;
            }
        }
    }
}
