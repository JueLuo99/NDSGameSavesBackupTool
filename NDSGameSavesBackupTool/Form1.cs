using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDSGameSavesBackupTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //K为文件名，V为绝对路径
        public Dictionary<string, string> saves = new Dictionary<string, string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxBackUpFrom.Text = folderBrowserDialog1.SelectedPath;
            findSaves(textBoxBackUpFrom.Text);
            foreach (string f in saves.Keys) listBoxAllSaves.Items.Add(f);
        }

        private void buttonBackUpTo_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxBackUpTo.Text = folderBrowserDialog1.SelectedPath;
        }

        private void textBoxBackUpFrom_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查找指定目录下的存档文件，并添加至“saves”字典
        /// </summary>
        /// <param name="dirpath"></param>
        public void findSaves(string dirpath)
        {
            string[] files = Directory.GetFiles(dirpath, "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                try
                {
                    saves.Add(Path.GetFileName(file), Path.GetFullPath(file));
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("检测到同名的存档文件，将只备份一个！");
                    continue;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "请选择从何处备份";
        }
        
        //使状态显示文本每次变更后都能居中显示
        private void labelStatus_Resize(object sender, EventArgs e)
        {
            labelStatus.Location = new Point((groupBox_status.Width - labelStatus.Width) / 2, 24);
        }
    }
}
