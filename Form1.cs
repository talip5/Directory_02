using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_02
{
    public partial class Form1 : Form
    {
        public string text1;
        public Form1()
        {
            InitializeComponent();

            listBox1.SelectedIndexChanged+=ListBox1_SelectedIndexChanged;
            listBox1.SelectedValueChanged+=ListBox1_SelectedValueChanged;


            //                    // Get the current directory.
            //                    string path = Directory.GetCurrentDirectory();
            //                    string target = @"c:\temp";
            //                    Console.WriteLine("The current directory is {0}", path);
            //
            //                    if (!Directory.Exists(target))
            //{
            //    Directory.CreateDirectory(target);
            //}

            //                    // Change the current directory.
            //                    Environment.CurrentDirectory = (target);
            //                    if (path.Equals(Directory.GetCurrentDirectory()))
            //                    {
            //                        Console.WriteLine("You are in the temp directory.");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("You are not in the temp directory.");
            //                    }
            //                }
        }

        private void ListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            text1= listBox1.SelectedItem.ToString();
            label4.Text = text1;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //text1= listBox1.SelectedItem.ToString();
            //label4.Text = text1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                // string[] array2 = Directory.GetFiles(@"C:\", "*.log"); // <-- Case-insensitive
                string[] array2 = Directory.GetFiles(@""+text1+"", "*.log"); // <-- Case-insensitive
                label4.Text = array2.Count().ToString();
                listBox1.Items.Clear();
                foreach (string s in array2)
                {
                    listBox1.Items.Add(s);
                }
            }
            else
            {
                listBox1.Items.Clear();

                string message = "Directory is not selected";
                listBox1.Items.Add(message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string dizi = "C:\\";
                //string[] array1 = Directory.GetFiles(@"C:\");
                //string[] array1 = Directory.GetFiles(dizi);
                string[] array1 = Directory.GetFiles(@""+text1+"");
                int count1 = array1.Count();
                //label4.Text = count1.ToString();
                //label4.Text = array1[1];
                // listBox2.Items.Add(array1[0]);
                listBox1.Items.Clear();
                foreach (var item in array1)
                {
                    listBox1.Items.Add(item);
                }
            }
            else
            {
                listBox1.Items.Clear();

                string message = "Directory is not selected";
                listBox1.Items.Add(message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] AltKlasorler = Directory.GetDirectories("C:\\");
            foreach (var item in AltKlasorler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] AltKlasorler = Directory.GetDirectories("C:\\", "p*");
            foreach (var item in AltKlasorler)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //label4.Text = Directory.GetDirectoryRoot("C:\\Dosya");
            //label4.Text = Directory.GetDirectoryRoot(@""+text1+"");
            label4.Text = Directory.GetDirectoryRoot(@"C:\Deneme1\temp");
            Directory.GetDirectoryRoot(@"C:\Deneme1\temp");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Directory.GetParent("C:\\Deneme1\\temp");
            Directory.GetParent("C:\\Deneme1\\temp");

            //System.IO.DirectoryInfo directoryInfo =
            //        System.IO.Directory.GetParent(path);

            //System.Console.WriteLine(directoryInfo.FullName);

            //string path1 = "C:\\Deneme1\\temp";
            string path1 = (@""+text1+"");
            System.IO.DirectoryInfo directoryInfo =
                   System.IO.Directory.GetParent(path1);
            label4.Text = directoryInfo.Name;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //text1= listBox1.SelectedItem.ToString();
            //label4.Text = text1;
            //string[] array1 = Directory.GetFiles(@""+text1+"");
            //foreach (var item in array1)
            //{
            //    listBox2.Items.Add(item);
            //}
            string directoryName;
            //string path1 = (@""+text1+"");
            string path1 = ("C:\\Deneme1\\temp\\new1");
            directoryName = Path.GetDirectoryName(path1);
            label4.Text = directoryName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string fileName = "haber.txt";
            string path1 = @"new1";
            string path2 = @"\new1";
            string fullPath;

            //fullPath = Path.GetFullPath(path1);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            //    path1, fullPath);

            fullPath = Path.GetFullPath(path1);
            //label4.Text=fullPath;

            //fullPath = Path.GetFullPath(fileName);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            //    fileName, fullPath);

            fullPath = Path.GetFullPath(fileName);
            //label4.Text=fullPath;

            //fullPath = Path.GetFullPath(path2);
            //Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            //    path2, fullPath);

            fullPath = Path.GetFullPath(path2);
            label4.Text=fullPath; // C:\new1

            // Output is based on your current directory, except
            // in the last case, where it is based on the root drive
            // GetFullPath('mydir') returns 'C:\temp\Demo\mydir'
            // GetFullPath('myfile.ext') returns 'C:\temp\Demo\myfile.ext'
            // GetFullPath('\mydir') returns 'C:\mydir'
        }

        private void Form1_Load_1(object sender, EventArgs e)
            {
            this.Text = "xxx";
        }
    }
}
