namespace WindowsFormsApplication3
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.tnWrite = new System.Windows.Forms.Button();
            this.rTx = new System.Windows.Forms.RichTextBox();
            this.tnRead = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(188, 21);
            this.txtFilePath.TabIndex = 0;
            // 
            // tnWrite
            // 
            this.tnWrite.Location = new System.Drawing.Point(206, 12);
            this.tnWrite.Name = "tnWrite";
            this.tnWrite.Size = new System.Drawing.Size(75, 23);
            this.tnWrite.TabIndex = 1;
            this.tnWrite.Text = "写入";
            this.tnWrite.UseVisualStyleBackColor = true;
            this.tnWrite.Click += new System.EventHandler(this.tnWrite_Click);
            // 
            // rTx
            // 
            this.rTx.Location = new System.Drawing.Point(12, 41);
            this.rTx.Name = "rTx";
            this.rTx.Size = new System.Drawing.Size(427, 259);
            this.rTx.TabIndex = 2;
            this.rTx.Text = "";
            // 
            // tnRead
            // 
            this.tnRead.Location = new System.Drawing.Point(288, 12);
            this.tnRead.Name = "tnRead";
            this.tnRead.Size = new System.Drawing.Size(75, 23);
            this.tnRead.TabIndex = 3;
            this.tnRead.Text = "读取";
            this.tnRead.UseVisualStyleBackColor = true;
            this.tnRead.Click += new System.EventHandler(this.tnRead_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 312);
            this.Controls.Add(this.tnRead);
            this.Controls.Add(this.rTx);
            this.Controls.Add(this.tnWrite);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button tnWrite;
        private System.Windows.Forms.RichTextBox rTx;
        private System.Windows.Forms.Button tnRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

