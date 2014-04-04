using Common;
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

namespace Question_Generator_Mini
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnParseSentence_Click(object sender, EventArgs e)
        {
            try
            {
                InformationExtraction.InformationExtractor informationExtractor = new InformationExtraction.InformationExtractor();
                string information = informationExtractor.Extract();
                txtOutputText.Text = information;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);

            }

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: Move to Preprocessing Module
                ApplicationSettings applicationSettings = new ApplicationSettings();
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "TXT files (*.txt)|*.txt";
                openFileDialog.Multiselect = false;
                openFileDialog.InitialDirectory = applicationSettings["InitialDirectory"];
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;

                    File.Copy(fileName, Application.StartupPath + applicationSettings["pyScriptArgSourceLocation"] + "\\_up_" + openFileDialog.SafeFileName);

                    using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                    {
                        using (StreamReader streamReader = new StreamReader(fileStream))
                        {
                            txtInputText.Text = streamReader.ReadToEnd();
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);

            }




        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GlobalAcessData.ApplicationStartupPath = Application.StartupPath;
        }


    }
}
