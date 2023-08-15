namespace FileDemo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtStu_Name = new System.Windows.Forms.TextBox();
            this.txtStu_roll = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBinRead = new System.Windows.Forms.Button();
            this.btnBinWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(173, 172);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 15;
            // 
            // txtStu_Name
            // 
            this.txtStu_Name.Location = new System.Drawing.Point(173, 111);
            this.txtStu_Name.Name = "txtStu_Name";
            this.txtStu_Name.Size = new System.Drawing.Size(100, 20);
            this.txtStu_Name.TabIndex = 14;
            // 
            // txtStu_roll
            // 
            this.txtStu_roll.Location = new System.Drawing.Point(173, 61);
            this.txtStu_roll.Name = "txtStu_roll";
            this.txtStu_roll.Size = new System.Drawing.Size(100, 20);
            this.txtStu_roll.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stu_Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stu_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Stu_Rollno";
            // 
            // btnBinRead
            // 
            this.btnBinRead.Location = new System.Drawing.Point(520, 80);
            this.btnBinRead.Name = "btnBinRead";
            this.btnBinRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinRead.TabIndex = 9;
            this.btnBinRead.Text = "Bin Read";
            this.btnBinRead.UseVisualStyleBackColor = true;
            this.btnBinRead.Click += new System.EventHandler(this.btnBinRead_Click);
            // 
            // btnBinWrite
            // 
            this.btnBinWrite.Location = new System.Drawing.Point(422, 80);
            this.btnBinWrite.Name = "btnBinWrite";
            this.btnBinWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinWrite.TabIndex = 8;
            this.btnBinWrite.Text = "Bin Write";
            this.btnBinWrite.UseVisualStyleBackColor = true;
            this.btnBinWrite.Click += new System.EventHandler(this.btnBinWrite_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtStu_Name);
            this.Controls.Add(this.txtStu_roll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBinRead);
            this.Controls.Add(this.btnBinWrite);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.TextBox txtStu_Name;
        private System.Windows.Forms.TextBox txtStu_roll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinRead;
        private System.Windows.Forms.Button btnBinWrite;
    }
}