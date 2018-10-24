namespace NDSGameSavesBackupTool
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
            this.textBoxBackUpFrom = new System.Windows.Forms.TextBox();
            this.textBoxBackUpTo = new System.Windows.Forms.TextBox();
            this.buttonBackUpFrom = new System.Windows.Forms.Button();
            this.buttonBackUpTo = new System.Windows.Forms.Button();
            this.listBoxAllSaves = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.listBoxReadyToBackUp = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBackUpFrom
            // 
            this.textBoxBackUpFrom.Enabled = false;
            this.textBoxBackUpFrom.Location = new System.Drawing.Point(119, 14);
            this.textBoxBackUpFrom.Name = "textBoxBackUpFrom";
            this.textBoxBackUpFrom.Size = new System.Drawing.Size(333, 21);
            this.textBoxBackUpFrom.TabIndex = 0;
            this.textBoxBackUpFrom.TextChanged += new System.EventHandler(this.textBoxBackUpFrom_TextChanged);
            // 
            // textBoxBackUpTo
            // 
            this.textBoxBackUpTo.Enabled = false;
            this.textBoxBackUpTo.Location = new System.Drawing.Point(119, 43);
            this.textBoxBackUpTo.Name = "textBoxBackUpTo";
            this.textBoxBackUpTo.Size = new System.Drawing.Size(333, 21);
            this.textBoxBackUpTo.TabIndex = 1;
            // 
            // buttonBackUpFrom
            // 
            this.buttonBackUpFrom.Location = new System.Drawing.Point(12, 12);
            this.buttonBackUpFrom.Name = "buttonBackUpFrom";
            this.buttonBackUpFrom.Size = new System.Drawing.Size(101, 23);
            this.buttonBackUpFrom.TabIndex = 2;
            this.buttonBackUpFrom.Text = "选择备份自...";
            this.buttonBackUpFrom.UseVisualStyleBackColor = true;
            this.buttonBackUpFrom.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBackUpTo
            // 
            this.buttonBackUpTo.Location = new System.Drawing.Point(12, 41);
            this.buttonBackUpTo.Name = "buttonBackUpTo";
            this.buttonBackUpTo.Size = new System.Drawing.Size(101, 23);
            this.buttonBackUpTo.TabIndex = 3;
            this.buttonBackUpTo.Text = "选择备份到...";
            this.buttonBackUpTo.UseVisualStyleBackColor = true;
            this.buttonBackUpTo.Click += new System.EventHandler(this.buttonBackUpTo_Click);
            // 
            // listBoxAllSaves
            // 
            this.listBoxAllSaves.FormattingEnabled = true;
            this.listBoxAllSaves.ItemHeight = 12;
            this.listBoxAllSaves.Items.AddRange(new object[] {
            "1",
            "1",
            "2",
            "3",
            "35",
            "5",
            "4",
            "5",
            "5",
            "7",
            "8"});
            this.listBoxAllSaves.Location = new System.Drawing.Point(12, 82);
            this.listBoxAllSaves.Name = "listBoxAllSaves";
            this.listBoxAllSaves.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAllSaves.Size = new System.Drawing.Size(166, 232);
            this.listBoxAllSaves.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(458, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "备份方式";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "直接备份至文件夹";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "创建备份日期的子文件夹";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // listBoxReadyToBackUp
            // 
            this.listBoxReadyToBackUp.FormattingEnabled = true;
            this.listBoxReadyToBackUp.ItemHeight = 12;
            this.listBoxReadyToBackUp.Location = new System.Drawing.Point(286, 82);
            this.listBoxReadyToBackUp.Name = "listBoxReadyToBackUp";
            this.listBoxReadyToBackUp.Size = new System.Drawing.Size(166, 232);
            this.listBoxReadyToBackUp.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 404);
            this.Controls.Add(this.listBoxReadyToBackUp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxAllSaves);
            this.Controls.Add(this.buttonBackUpTo);
            this.Controls.Add(this.buttonBackUpFrom);
            this.Controls.Add(this.textBoxBackUpTo);
            this.Controls.Add(this.textBoxBackUpFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBackUpFrom;
        private System.Windows.Forms.TextBox textBoxBackUpTo;
        private System.Windows.Forms.Button buttonBackUpFrom;
        private System.Windows.Forms.Button buttonBackUpTo;
        private System.Windows.Forms.ListBox listBoxAllSaves;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBoxReadyToBackUp;
    }
}

