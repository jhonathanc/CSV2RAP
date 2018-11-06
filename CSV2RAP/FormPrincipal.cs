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

namespace CSV2RAP
{
    public partial class FormPrincipal : Form
    {
        private Stream csvStream = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Buttons_Click(object sender, EventArgs e)
        {
            if (sender == btnSelectCSVFile)
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.DefaultExt = ".csv";
                    ofd.Filter = "CSV files (*.csv) | *.csv";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            csvStream = ofd.OpenFile();
                            tbCSVFileName.Text = ofd.FileName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                        }
                    }
                }
            }
            else if (sender == btnSelectOutputPath)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                        tbRAPOutputPath.Text = fbd.SelectedPath;
                }
            }
            else
            {
                if ((csvStream != null) && (tbRAPOutputPath.Text != ""))
                {
                    CSV2RAPConverter.Convert2Rap(csvStream, tbRAPOutputPath.Text, ';');
                    MessageBox.Show("Tudo ok.");
                }
            }
        }
    }
}
