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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        void BindInfo(TreeNode node)
        {
            DirectoryInfo diretoryinfo = new DirectoryInfo(node.Tag.ToString());
            DirectoryInfo[] dirs = diretoryinfo.GetDirectories();
            foreach (DirectoryInfo di in dirs)
            {
                TreeNode temp = new TreeNode();

                temp.Text = di.Name;
                temp.Tag = di.FullName;
                node.Nodes.Add(temp);
               


            }
            FileInfo[] fileinfo = diretoryinfo.GetFiles();
            List<myfile> Files = new List<myfile>();
            foreach (FileInfo myfile in fileinfo)

            {
                myfile file = new myfile();
                file.Filename = myfile.Name;
                file.FileLength = myfile.Length;
                file.FilePath = myfile.FullName;
                file.Filetpye = myfile.Extension;
                Files.Add(file);
            }
            ShowFiles(Files);

        }
        void ShowFiles(List<myfile> files)

        {
            ListViewItem item = null;
            lv.Items.Clear();
           foreach(myfile file in files)
            {
                item = new ListViewItem();
                item.Text = file.Filename;
                item.SubItems.Add(file.FileLength.ToString());
                item.SubItems.Add(file.Filetpye);
                item.SubItems.Add(file.FilePath);
                lv.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDriver();
        }
        void LoadDriver()
        {
            TreeNode dirver = new TreeNode();
            dirver.Text = @"D:\";
            dirver.Tag = @"D:\";
            this.tvExplore.Nodes.Add(dirver);
            BindInfo(tvExplore.TopNode);

        }

        private void tisicopy_Click(object sender, EventArgs e)
        {
            if(this.lv.SelectedItems.Count==0)
            {
                return;
            }
            FolderBrowserDialog fhd = new FolderBrowserDialog();
            DialogResult result = fhd.ShowDialog();
            string sourcePath = lv.SelectedItems[0].SubItems[3].Text;
            string desPath = null;
            if(result==DialogResult.OK)
            {
                desPath = fhd.SelectedPath;
                desPath += "\\" + lv.SelectedItems[0].SubItems[0].Text;
                File.Copy(sourcePath, desPath);
                MessageBox.Show("复制成功");
            }
        }

        private void tisidele_Click(object sender, EventArgs e)
        {
            if(this.lv.SelectedItems.Count==0)
            {
                return;
            }
            string sourcPath = lv.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show(this, "确定要删除么?", "警告", MessageBoxButtons.OKCancel);
            if(result==OK)
            {

            }
        }
    }
}
