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
using System.Data;
using System.Data.OleDb;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ret = folderBrowserDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                string[] strFiles = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                try
                {
                    var sourceDir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                    try
                    {
                        System.IO.FileInfo[] files = sourceDir.GetFiles("*.mp3", SearchOption.AllDirectories);
                        foreach (System.IO.FileInfo f in files)
                        {
                            listBox1.Items.Add(f.FullName);
                        }
                        listBox1.HorizontalScrollbar = true;
                        listBox1.ScrollAlwaysVisible = true;
                        listBox1.Show();
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Error accessing folder \n{0}", ex.Message);
                    }
                    catch (System.UnauthorizedAccessException ex)
                    {
                        Console.WriteLine("Error accessing folder \n{0}", ex.Message);
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error opening folder \n{0}", ex.Message);
                }
            }
            Console.WriteLine(ret);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
        }

    }
}
