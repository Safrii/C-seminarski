using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "Text Files (.txt)|*.txt";
            if (openFile1.ShowDialog() == DialogResult.OK)
            {
                //richTextBox1.LoadFile(openFile1.FileName);
                System.IO.StreamReader streamReader = new System.IO.StreamReader(openFile1.FileName);
                richTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text Files (.txt)|*.txt";
            if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
            {

                System.IO.StreamWriter streamSave = new System.IO.StreamWriter(saveFile1.FileName);
                streamSave.Write(richTextBox1.Text);
                streamSave.Close();
            }
        }

        private void updateFontForSpecificPartOdTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            richTextBox1.SelectionFont = fontDialog.Font;
            
        }
    }
}
