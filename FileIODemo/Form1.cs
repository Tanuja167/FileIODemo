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

namespace FileIODemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreatedirectory_Click(object sender, EventArgs e)
        {
            /*try
            {
                string path = @"F:\TestFolder";

                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory already exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Directory created");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }*/

            try
            {
                string path = @"F:\TestFolder";
                DirectoryInfo info = new DirectoryInfo(path);
                if(info.Exists)
                {
                    MessageBox.Show("Directory already exists");
                }
                else
                {
                    info.Create();
                    MessageBox.Show("Directory created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            /*try
            {
                string path = @"F:\TestFolder\Employee.dat"; 
                if (File.Exists(path))
                {
                    MessageBox.Show("File already exsist");
                }
                else
                {
                  File.Create(path);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            try
            {
                string path = @"F:\TestFolder\Employee.dat";
                FileInfo info = new FileInfo(path);

                if(info.Exists)
                {
                    MessageBox.Show("File already exsist");
                }
                else
                {
                    info.Create();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnstreamwrite_Click(object sender, EventArgs e)
        {
            try
            {

                FileStream fs = new FileStream(@"F:\TestFolder\data.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {

                FileStream fs = new FileStream(@"F:\TestFolder\Employee.dat", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(txtid.Text));
                bw.Write(txtname.Text);
                bw.Write(Convert.ToDouble(txtsalary.Text));
                bw.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"F:\TestFolder\Employee.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtsalary.Text = br.ReadDouble().ToString();
                br.Close();
                fs.Close();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnstreamread_Click(object sender, EventArgs e)
        {
            try
            {

                FileStream fs = new FileStream(@"F:\TestFolder\Employee.dat", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
