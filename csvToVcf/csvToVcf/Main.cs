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

namespace csvToVcf
{
    public partial class Main : Form
    {
        private string filePath = string.Empty;
        private string fileContent = string.Empty;
        private string[] allLines;
        public Main()
        {
            InitializeComponent();
        }
            
        private void btnDosyaYukle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    allLines = File.ReadAllLines(filePath);
                    string[] path = filePath.Split('\\');
                    lblDosyaAdi.Text = path[path.Length - 1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.DefaultExt = ".vcf";
            saveFileDialog.Filter = "VCF files (*.vcf)|*.vcf";
            string contacts = "";
            try
            {
                foreach (var line in allLines)
                {
                    contacts += Util.writeToVcfFile(Util.saveMemberToVector(line), txtBoxOrgName.Text, txtBoxYear.Text);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
           
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(contacts);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
