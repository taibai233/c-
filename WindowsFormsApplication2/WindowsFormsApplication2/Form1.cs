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
    public partial class Form1 : Form
    {
        private Dictionary<string, student_hzw> ph;

        public Dictionary<string, student_hzw> Ph
        {
            get
            {
                return ph;
            }

            set
            {
                ph = value;
            }
        }

        public Form1()
        {
            student_hzw p1 = new student_hzw();
            InitializeComponent();
            Ph = new Dictionary<string, student_hzw>();
            FullData(ph);
        }
        public void FullData(Dictionary<string, student_hzw> ph)
        {
            listView1.Items.Clear();
            foreach (student_hzw p in ph.Values)
            {
                ListViewItem item = new ListViewItem(p.Name_hzw);
                item.SubItems.AddRange(new string[] { p.Sex_hzw, p.Job_hzw, p.PhoneNumber_hzw.ToString(), p.Adress_hzw, p.FriendShip });
                listView1.Items.Add(item);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm1 = new Form2(this);
            fm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fName = FName.Text;
            if (fName == "")
            {
                MessageBox.Show("请输入姓名");
            }
            else
            {
                foreach (string p1 in ph.Keys)
                {
                    if (p1 == fName)
                    {
                        MessageBox.Show("存在此人");
                    }
                }
                MessageBox.Show("无此人");
                return;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fPhoneNumber = FPhoneNumber.Text;
            if (fPhoneNumber == "")
            {
                MessageBox.Show("请输入姓名");
            }
            else
            {
                foreach (student_hzw p1 in ph.Values)
                {
                    if (p1.PhoneNumber_hzw == fPhoneNumber)
                    {
                        MessageBox.Show("存在此号码");
                    }
                }
                MessageBox.Show("无此号码");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中");
            }
            else
            {
                int i;
                i = listView1.SelectedItems[0].Index;
                string name = listView1.Items[i].SubItems[0].Text;
                ph.Remove(name);
                FullData(ph);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("未选中");
            }
            else
            {
                int i;
                i = listView1.SelectedItems[0].Index;
                string name = listView1.Items[i].SubItems[0].Text;
                student_hzw st1;
                ph.TryGetValue(name,out st1);
                Form2 fm = new Form2(this, st1);
                fm.Show();
                ph.Remove(name);
                FullData(ph);
            }
        }
    }
}
