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
using Microsoft.VisualBasic;

namespace UI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void Inout_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NewFileName = "";
            if (BTN1.Checked== true)
            {
                if (FileRdo2.Checked == true)
                {
                    NewFileName = Properties.Settings.Default.DefaultPath;
                    if (System.IO.Directory.Exists(NewFileName)==false)
                    {
                        var directoryInfo = Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BHFFiles"));
                    }
                    try
                    {
                        var FullPath =NewFileName + DateTime.Now.ToString("hhmmttddddddMMMMyyyy") + ".nif";
                        using (StreamWriter sw = File.CreateText(FullPath))
                        {
                            sw.WriteLine(InputTB.Text);

                        }
                        
                        Upload.NIWS_NIFClient client = new Upload.NIWS_NIFClient();
                        string textFile = FullPath;
                        string text = File.ReadAllText(textFile);
                        var responce = client.BatchFileUpload("1da553ba-b698-4e26-913a-af2ae0510f53", text);
                        //var holder = client.RequestFileUploadReport("1da553ba-b698-4e26-913a-af2ae0510f53", "10019639.1000781359.3106.41001.011");
                        //var responce2 = client.RequestAVSReport("1da553ba-b698-4e26-913a-af2ae0510f53", "10019639.1000781359.3106.41001.011");
                        OutputTb.Text += responce + '\n';


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                if (FileRdo1.Checked == true)
                {
                   
                    if (FileName.Text == null || FileName.Text == "")
                    {
                        MessageBox.Show("file path empty");
                        NewFileName = @FileName.Text + DateTime.Now.ToString("ddddddMMMMyyyy") + ".nif";


                    }
                    
                    NewFileName = FileName.Text;
                    var FullPath = NewFileName + DateTime.Now.ToString("hhmmttddddddMMMMyyyy") + ".nif";
                    try
                    {
                        using (StreamWriter sw = File.CreateText(FullPath))
                        {
                            sw.WriteLine(InputTB.Text);

                        }
                        Upload.NIWS_NIFClient client = new Upload.NIWS_NIFClient();
                        string textFile = FullPath;
                        string text = File.ReadAllText(textFile);
                        var responce = client.BatchFileUpload("1da553ba-b698-4e26-913a-af2ae0510f53", text);
                        OutputTb.Text += responce + '\n';
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    
                }
              
                
                
                
            }
            if (Btn2.Checked == true)
            {
                if (FileTokenTb.Text == "" || FileTokenTb.Text == null)
                {
                    MessageBox.Show("File token is empty");
                }
                try
                {
                    Upload.NIWS_NIFClient client = new Upload.NIWS_NIFClient();
                    var holder = client.RequestFileUploadReport("1da553ba-b698-4e26-913a-af2ae0510f53", FileTokenTb.Text);
                    var responce2 = client.RequestAVSReport("1da553ba-b698-4e26-913a-af2ae0510f53", FileTokenTb.Text);
                    OutputTb.Text += holder + '\n';
                    OutputTb.Text += responce2 + '\n';
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
               
            }
            
            
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = DateTime.Now.ToString("dddd:HH:mm:ss")+".txt";

            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine(OutputTb.Text);
                writer.Dispose();
                writer.Close();

            }


        }
            private void Btn2_CheckedChanged(object sender, EventArgs e)
        {
            if (Btn2.Checked == true)
            {
                FileTokenLbl.Visible = true;
                FileTokenTb.Visible = true;
            }
            if (Btn2.Checked == false)
            {
                FileTokenTb.Text = "";
                FileTokenLbl.Visible = false;
                FileTokenTb.Visible = false;
            }
        }

        private void Btn3_CheckedChanged(object sender, EventArgs e)
        {
            if (Btn3.Checked == true)
            {
                FileTokenLbl.Visible = true;
                FileTokenTb.Visible = true;
            }
            if (Btn3.Checked == false)
            {
                FileTokenTb.Text = "";
                FileTokenLbl.Visible = false;
                FileTokenTb.Visible = false;
            }
        }

        private void FileRdo1_CheckedChanged(object sender, EventArgs e)
        {
            if (FileRdo1.Checked == true)
            {
                FileName.Visible = true;
                Lbl1.Visible = true;
              

                FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
                if (directchoosedlg.ShowDialog() == DialogResult.OK)
                {
                    FileName.Text = directchoosedlg.SelectedPath;
                }
                else
                {
                    return;
                }
               
            }
            else
            {
                FileName.Visible = false;
                Lbl1.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetDefaultPath_CheckedChanged(object sender, EventArgs e)
        {
            //if (FileName.Text != null && FileName.Text !="")
            //{
            //    Properties.Settings.Default.DefaultPath = FileName.Text;
            //    //Save the setting 
            //    Properties.Settings.Default.Save();
            //    //To get the value of a setting, use
            //    //string mystr = Properties.Settings.Default.DefaultPath;
            //}
            
        }
    }
}
