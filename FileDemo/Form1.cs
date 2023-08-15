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

namespace FileDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder is already Exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\doc1.txt";
                if(File.Exists(path))
                {
                    MessageBox.Show("File already exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("File created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.dat";

                FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fs);
                binaryWriter.Write(Convert.ToInt32(txtid.Text));
                binaryWriter.Write(txtname.Text);
                binaryWriter.Write(Convert.ToDouble(txtprice.Text));
                binaryWriter.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\product.dat";

                FileStream fileStream = new FileStream(path,FileMode.Open,FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtid.Text = binaryReader.ReadInt32().ToString();
                txtname.Text = binaryReader.ReadString();
                txtprice.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
