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

namespace week08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text file|*.txt;*.csv";
            var dialogResult = dialog.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(dialog.FileName))
                    {
                        var content = sr.ReadToEnd();
                        txtContent.Text = content;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("IOExcelption: "+ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UnknownExcelption: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text file|*.txt";
            var dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
                try
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        writer.Write(txtContent.Text);
                        MessageBox.Show("Saved. " + dialog.FileName);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("IOExcelption: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("UnknownExcelption: " + ex.Message);
                }
           
            
        }
    }
}
