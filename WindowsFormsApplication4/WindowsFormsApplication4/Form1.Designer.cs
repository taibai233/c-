namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem tisidele;
            this.tvExplore = new System.Windows.Forms.TreeView();
            this.lv = new System.Windows.Forms.ListView();
            this.filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsopr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tisicopy = new System.Windows.Forms.ToolStripMenuItem();
            tisidele = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsopr.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvExplore
            // 
            this.tvExplore.Location = new System.Drawing.Point(12, 12);
            this.tvExplore.Name = "tvExplore";
            this.tvExplore.Size = new System.Drawing.Size(131, 464);
            this.tvExplore.TabIndex = 0;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.filename,
            this.fileLength,
            this.fileType,
            this.filePath});
            this.lv.ContextMenuStrip = this.cmsopr;
            this.lv.Location = new System.Drawing.Point(150, 13);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(394, 463);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // filename
            // 
            this.filename.Text = "文件名";
            // 
            // fileLength
            // 
            this.fileLength.Text = "文件大小（KB）";
            this.fileLength.Width = 110;
            // 
            // fileType
            // 
            this.fileType.Text = "文件类型";
            this.fileType.Width = 107;
            // 
            // filePath
            // 
            this.filePath.Text = "文件路径";
            this.filePath.Width = 117;
            // 
            // cmsopr
            // 
            this.cmsopr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tisicopy,
            tisidele});
            this.cmsopr.Name = "cmsopr";
            this.cmsopr.Size = new System.Drawing.Size(153, 70);
            // 
            // tisicopy
            // 
            this.tisicopy.Name = "tisicopy";
            this.tisicopy.Size = new System.Drawing.Size(152, 22);
            this.tisicopy.Text = "复制";
            this.tisicopy.Click += new System.EventHandler(this.tisicopy_Click);
            // 
            // tisidele
            // 
            tisidele.Name = "tisidele";
            tisidele.Size = new System.Drawing.Size(152, 22);
            tisidele.Text = "删除";
            tisidele.Click += new System.EventHandler(this.tisidele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 503);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.tvExplore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsopr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvExplore;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader filename;
        private System.Windows.Forms.ColumnHeader fileLength;
        private System.Windows.Forms.ColumnHeader fileType;
        private System.Windows.Forms.ColumnHeader filePath;
        private System.Windows.Forms.ContextMenuStrip cmsopr;
        private System.Windows.Forms.ToolStripMenuItem tisicopy;
    }
}

