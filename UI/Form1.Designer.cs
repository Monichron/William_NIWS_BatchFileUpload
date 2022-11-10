
namespace UI
{
    partial class Form1
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
            this.InputTB = new System.Windows.Forms.RichTextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.OutputTb = new System.Windows.Forms.RichTextBox();
            this.BTN1 = new System.Windows.Forms.RadioButton();
            this.Btn3 = new System.Windows.Forms.RadioButton();
            this.Btn2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileTokenTb = new System.Windows.Forms.RichTextBox();
            this.FileTokenLbl = new System.Windows.Forms.Label();
            this.FileRdo1 = new System.Windows.Forms.RadioButton();
            this.FileRdo2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SetDefaultPath = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTB
            // 
            this.InputTB.Location = new System.Drawing.Point(1, 64);
            this.InputTB.Name = "InputTB";
            this.InputTB.Size = new System.Drawing.Size(235, 579);
            this.InputTB.TabIndex = 0;
            this.InputTB.Text = "";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(531, 217);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(185, 13);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "File Path eg  C:\\Users\\William\\notes\\";
            this.Lbl1.Visible = false;
            this.Lbl1.Click += new System.EventHandler(this.Inout_Click);
            // 
            // OutputTb
            // 
            this.OutputTb.Location = new System.Drawing.Point(245, 65);
            this.OutputTb.Name = "OutputTb";
            this.OutputTb.Size = new System.Drawing.Size(280, 579);
            this.OutputTb.TabIndex = 0;
            this.OutputTb.Text = "";
            // 
            // BTN1
            // 
            this.BTN1.AutoSize = true;
            this.BTN1.Checked = true;
            this.BTN1.Location = new System.Drawing.Point(0, 19);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(76, 17);
            this.BTN1.TabIndex = 2;
            this.BTN1.TabStop = true;
            this.BTN1.Text = "Submit file ";
            this.BTN1.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.AutoSize = true;
            this.Btn3.Location = new System.Drawing.Point(235, 20);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(94, 17);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "Check Results";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.CheckedChanged += new System.EventHandler(this.Btn3_CheckedChanged);
            // 
            // Btn2
            // 
            this.Btn2.AutoSize = true;
            this.Btn2.Location = new System.Drawing.Point(81, 19);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(147, 17);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "Retrieve Batch Statement";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.CheckedChanged += new System.EventHandler(this.Btn2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN1);
            this.groupBox1.Controls.Add(this.Btn3);
            this.groupBox1.Controls.Add(this.Btn2);
            this.groupBox1.Location = new System.Drawing.Point(460, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Try To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit Upload Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(528, 233);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(309, 27);
            this.FileName.TabIndex = 5;
            this.FileName.Text = "";
            this.FileName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text File Input";
            // 
            // FileTokenTb
            // 
            this.FileTokenTb.Location = new System.Drawing.Point(528, 74);
            this.FileTokenTb.Name = "FileTokenTb";
            this.FileTokenTb.Size = new System.Drawing.Size(279, 25);
            this.FileTokenTb.TabIndex = 6;
            this.FileTokenTb.Text = "";
            this.FileTokenTb.Visible = false;
            // 
            // FileTokenLbl
            // 
            this.FileTokenLbl.AutoSize = true;
            this.FileTokenLbl.Location = new System.Drawing.Point(531, 58);
            this.FileTokenLbl.Name = "FileTokenLbl";
            this.FileTokenLbl.Size = new System.Drawing.Size(54, 13);
            this.FileTokenLbl.TabIndex = 1;
            this.FileTokenLbl.Text = "FileToken";
            this.FileTokenLbl.Visible = false;
            // 
            // FileRdo1
            // 
            this.FileRdo1.AutoSize = true;
            this.FileRdo1.Location = new System.Drawing.Point(9, 84);
            this.FileRdo1.Name = "FileRdo1";
            this.FileRdo1.Size = new System.Drawing.Size(85, 17);
            this.FileRdo1.TabIndex = 7;
            this.FileRdo1.Text = "Custom Path";
            this.FileRdo1.UseVisualStyleBackColor = true;
            this.FileRdo1.CheckedChanged += new System.EventHandler(this.FileRdo1_CheckedChanged);
            // 
            // FileRdo2
            // 
            this.FileRdo2.AutoSize = true;
            this.FileRdo2.Checked = true;
            this.FileRdo2.Location = new System.Drawing.Point(10, 61);
            this.FileRdo2.Name = "FileRdo2";
            this.FileRdo2.Size = new System.Drawing.Size(84, 17);
            this.FileRdo2.TabIndex = 8;
            this.FileRdo2.TabStop = true;
            this.FileRdo2.Text = "Default Path";
            this.FileRdo2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Default path: c:\\Documents";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FileRdo1);
            this.groupBox2.Controls.Add(this.FileRdo2);
            this.groupBox2.Location = new System.Drawing.Point(528, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 109);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Option for file path";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save Results As A .txt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DefaultPath: C:\\Users\\user pc\\OneDrive\\Documents\\BHFFilesResults";
            // 
            // SetDefaultPath
            // 
            this.SetDefaultPath.AutoSize = true;
            this.SetDefaultPath.Enabled = false;
            this.SetDefaultPath.Location = new System.Drawing.Point(533, 273);
            this.SetDefaultPath.Name = "SetDefaultPath";
            this.SetDefaultPath.Size = new System.Drawing.Size(128, 17);
            this.SetDefaultPath.TabIndex = 12;
            this.SetDefaultPath.TabStop = true;
            this.SetDefaultPath.Text = "Set New Default Path";
            this.SetDefaultPath.UseVisualStyleBackColor = true;
            this.SetDefaultPath.Visible = false;
            this.SetDefaultPath.CheckedChanged += new System.EventHandler(this.SetDefaultPath_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 645);
            this.Controls.Add(this.SetDefaultPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.FileTokenTb);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileTokenLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.OutputTb);
            this.Controls.Add(this.InputTB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox InputTB;
        private System.Windows.Forms.Label Lbl1;
        public System.Windows.Forms.RichTextBox OutputTb;
        private System.Windows.Forms.RadioButton BTN1;
        private System.Windows.Forms.RadioButton Btn3;
        private System.Windows.Forms.RadioButton Btn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox FileName;
        public System.Windows.Forms.RichTextBox FileTokenTb;
        public System.Windows.Forms.Label FileTokenLbl;
        private System.Windows.Forms.RadioButton FileRdo1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.RadioButton FileRdo2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton SetDefaultPath;
    }
}

