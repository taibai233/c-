using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tnWrite_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();

            //   string path = txtFilePath.Text;
            string path = saveFileDialog1.FileName;
            txtFilePath.Text = path;
            string context = rTx.Text;
            if(path.Equals(null)||path.Equals(""))
            {
                MessageBox.Show("文件路径不能为空");
                txtFilePath.Focus();
                return;
            }
            FileStream myfs = new FileStream(path, FileMode.Create);
            StreamWriter mysw = new StreamWriter(myfs,Encoding.Unicode);
            try
            {
                mysw.Write(context);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                mysw.Close();
                myfs.Close();
            }
            MessageBox.Show("写入成功");

        }

        private void tnRead_Click(object sender, EventArgs e)
        {
            // string path = txtFilePath.Text;
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;
            txtFilePath.Text = path;
            if (path.Equals(null) || path.Equals(""))
            {
                MessageBox.Show("文件路径不能为空");
                txtFilePath.Focus();
                return;
            }
            string filename = path.Substring(path.LastIndexOf("."));
            if (!filename.Equals(".txt"))
            {
                MessageBox.Show("不是txt文件");
                return;
            }
            FileStream myfs = new FileStream(path, FileMode.Open);
            StreamReader mysr = new StreamReader(myfs, Encoding.Unicode);
                rTx.Text = mysr.ReadToEnd();
            mysr.Close();
            myfs.Close();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
