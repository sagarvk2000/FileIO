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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\Employee.dat";

                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fs);
                binaryWriter.Write(Convert.ToInt32(txtEid.Text));
                binaryWriter.Write(txtEname.Text);
                binaryWriter.Write(Convert.ToDouble(txtSalary.Text));
                binaryWriter.Close();
                fs.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\Employee.dat";

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtEid.Text = binaryReader.ReadInt32().ToString();
                txtEname.Text = binaryReader.ReadString();
                txtSalary.Text = binaryReader.ReadDouble().ToString();
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
