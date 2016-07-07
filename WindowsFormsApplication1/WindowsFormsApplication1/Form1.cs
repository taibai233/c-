using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    { Dictionary<string, PhoneBook> phonebook;
        public Form1()
        {
            InitializeComponent();
            phonebook = new Dictionary<string, PhoneBook>();
            PhoneBook p1=new PhoneBook("aaa","1234556","nokia");

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void FillData(Dictionary<string ,PhoneBook>ph)
        {
            listView1.Items.Clear();
            foreach(PhoneBook p in ph.Values)
            {
                ListViewItem item = new ListViewItem(p.Name);
                item.SubItems.AddRange(new string[] { p.PhoneNumber, p.PhoneType });
                listView1.Items.
            }
        }
    }
}
