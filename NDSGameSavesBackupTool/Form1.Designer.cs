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
            this.groupBox_BackUpType = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBoxReadyToBackUp = new System.Windows.Forms.ListBox();
            this.groupBox_status = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStartBuckup = new System.Windows.Forms.Button();
            this.groupBox_BackUpType.SuspendLayout();
            this.groupBox_status.SuspendLayout();
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
            this.textBoxBackUpTo.Text = ".\\saves";
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
            this.listBoxAllSaves.Location = new System.Drawing.Point(11, 100);
            this.listBoxAllSaves.Name = "listBoxAllSaves";
            this.listBoxAllSaves.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxAllSaves.Size = new System.Drawing.Size(166, 232);
            this.listBoxAllSaves.TabIndex = 4;
            // 
            // groupBox_BackUpType
            // 
            this.groupBox_BackUpType.Controls.Add(this.radioButton2);
            this.groupBox_BackUpType.Controls.Add(this.radioButton1);
            this.groupBox_BackUpType.Enabled = false;
            this.groupBox_BackUpType.Location = new System.Drawing.Point(458, 82);
            this.groupBox_BackUpType.Name = "groupBox_BackUpType";
            this.groupBox_BackUpType.Size = new System.Drawing.Size(166, 77);
            this.groupBox_BackUpType.TabIndex = 5;
            this.groupBox_BackUpType.TabStop = false;
            this.groupBox_BackUpType.Text = "备份方式";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "创建备份日期的子文件夹";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(119, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "直接备份至文件夹";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBoxReadyToBackUp
            // 
            this.listBoxReadyToBackUp.FormattingEnabled = true;
            this.listBoxReadyToBackUp.ItemHeight = 12;
            this.listBoxReadyToBackUp.Location = new System.Drawing.Point(285, 100);
            this.listBoxReadyToBackUp.Name = "listBoxReadyToBackUp";
            this.listBoxReadyToBackUp.Size = new System.Drawing.Size(166, 232);
            this.listBoxReadyToBackUp.TabIndex = 6;
            // 
            // groupBox_status
            // 
            this.groupBox_status.Controls.Add(this.labelStatus);
            this.groupBox_status.Location = new System.Drawing.Point(458, 12);
            this.groupBox_status.Name = "groupBox_status";
            this.groupBox_status.Size = new System.Drawing.Size(162, 52);
            this.groupBox_status.TabIndex = 7;
            this.groupBox_status.TabStop = false;
            this.groupBox_status.Text = "当前状态";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(53, 29);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 12);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "准备就绪";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Resize += new System.EventHandler(this.labelStatus_Resize);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(183, 151);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "添加选中项>>>";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(183, 181);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(95, 23);
            this.buttonAddAll.TabIndex = 9;
            this.buttonAddAll.Text = "添加全部项>>>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(183, 211);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(95, 23);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "<<<移除选中项";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(183, 241);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(95, 23);
            this.buttonRemoveAll.TabIndex = 11;
            this.buttonRemoveAll.Text = "<<<移除全部项";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "找到的存档列表：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "准备备份的存档列表：";
            // 
            // buttonStartBuckup
            // 
            this.buttonStartBuckup.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStartBuckup.Location = new System.Drawing.Point(465, 257);
            this.buttonStartBuckup.Name = "buttonStartBuckup";
            this.buttonStartBuckup.Size = new System.Drawing.Size(155, 75);
            this.buttonStartBuckup.TabIndex = 14;
            this.buttonStartBuckup.Text = "开始备份";
            this.buttonStartBuckup.UseVisualStyleBackColor = true;
            this.buttonStartBuckup.Click += new System.EventHandler(this.buttonStartBuckup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 343);
            this.Controls.Add(this.buttonStartBuckup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox_status);
            this.Controls.Add(this.listBoxReadyToBackUp);
            this.Controls.Add(this.groupBox_BackUpType);
            this.Controls.Add(this.listBoxAllSaves);
            this.Controls.Add(this.buttonBackUpTo);
            this.Controls.Add(this.buttonBackUpFrom);
            this.Controls.Add(this.textBoxBackUpTo);
            this.Controls.Add(this.textBoxBackUpFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "NDS游戏存档备份工具V1.0 by:绝洛";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_BackUpType.ResumeLayout(false);
            this.groupBox_BackUpType.PerformLayout();
            this.groupBox_status.ResumeLayout(false);
            this.groupBox_status.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox_BackUpType;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBoxReadyToBackUp;
        private System.Windows.Forms.GroupBox groupBox_status;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStartBuckup;
    }
}

