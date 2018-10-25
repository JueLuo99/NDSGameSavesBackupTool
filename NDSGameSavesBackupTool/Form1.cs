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
            labelStatus.Text = "扫描中...请稍后...";
            findSaves(textBoxBackUpFrom.Text);
            foreach (string f in saves.Keys) listBoxAllSaves.Items.Add(f);
            label1.Text = "找到的存档列表：（共" + saves.Count + "个）";
            labelStatus.Text = "请选择需要备份的存档";
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //这里涉及到删除元素，逆向顺序删除，否则会导致下标变动
            for (int i = listBoxAllSaves.SelectedItems.Count - 1; i > -1; i--)
            {
                listBoxReadyToBackUp.Items.Add(listBoxAllSaves.SelectedItems[i]);
                listBoxAllSaves.Items.Remove(listBoxAllSaves.SelectedItems[i]);
            }
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            foreach (var i in listBoxAllSaves.Items)
            {
                listBoxReadyToBackUp.Items.Add(i.ToString());
            }
            listBoxAllSaves.Items.Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //这里涉及到删除元素，逆向顺序删除，否则会导致下标变动
            for (int i = listBoxReadyToBackUp.SelectedItems.Count - 1; i > -1; i--)
            {
                listBoxAllSaves.Items.Add(listBoxReadyToBackUp.SelectedItems[i]);
                listBoxReadyToBackUp.Items.Remove(listBoxReadyToBackUp.SelectedItems[i]);
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (var i in listBoxReadyToBackUp.Items)
            {
                listBoxAllSaves.Items.Add(i.ToString());
            }
            listBoxReadyToBackUp.Items.Clear();
        }
    }
}
