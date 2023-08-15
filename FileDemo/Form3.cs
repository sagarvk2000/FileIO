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

namespace FileDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnBinWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\Student.dat";

                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fs);
                binaryWriter.Write(Convert.ToInt32(txtStu_roll.Text));
                binaryWriter.Write(txtStu_Name.Text);
                binaryWriter.Write(Convert.ToDouble(txtPercentage.Text));
                binaryWriter.Close();
                fs.Close();

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4-2-Aug\Student.dat";

                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txtStu_roll.Text = binaryReader.ReadInt32().ToString();
                txtStu_Name.Text = binaryReader.ReadString();
                txtPercentage.Text = binaryReader.ReadDouble().ToString();
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
