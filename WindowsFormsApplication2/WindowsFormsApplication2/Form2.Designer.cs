namespace WindowsFormsApplication2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Job = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Relationship = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "住址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "单位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "关系";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "电话";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(149, 44);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 21);
            this.Name.TabIndex = 14;
            // 
            // Job
            // 
            this.Job.Location = new System.Drawing.Point(149, 195);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(100, 21);
            this.Job.TabIndex = 16;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(149, 234);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(100, 21);
            this.Adress.TabIndex = 17;
            // 
            // Relationship
            // 
            this.Relationship.Location = new System.Drawing.Point(149, 285);
            this.Relationship.Name = "Relationship";
            this.Relationship.Size = new System.Drawing.Size(100, 21);
            this.Relationship.TabIndex = 18;
            // 
            // Sex
            // 
            this.Sex.Cursor = System.Windows.Forms.Cursors.Default;
            this.Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex.FormattingEnabled = true;
            this.Sex.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Sex.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.Sex.Location = new System.Drawing.Point(149, 146);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(100, 20);
            this.Sex.TabIndex = 19;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(149, 92);
            this.PhoneNumber.Mask = "000-0000-0000";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(100, 21);
            this.PhoneNumber.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 406);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.Relationship);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Job);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Job;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.TextBox Relationship;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.MaskedTextBox PhoneNumber;
    }
}