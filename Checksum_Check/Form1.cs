using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checksum_Check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbHashAlgorithm.Items.Add("MD5");
            cmbHashAlgorithm.Items.Add("SHA1");
            cmbHashAlgorithm.Items.Add("SHA256");
            cmbHashAlgorithm.Items.Add("SHA512");
            cmbHashAlgorithm.SelectedIndex = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            string expectedChecksum = txtExpectedChecksum.Text;
            string hashAlgorithm = cmbHashAlgorithm.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(filePath) || string.IsNullOrWhiteSpace(hashAlgorithm))
            {
                MessageBox.Show("Bitte wählen Sie eine Datei und einen Hash-Algorithmus aus.");
                return;
            }

            string calculatedChecksum = GetFileChecksum(filePath, hashAlgorithm);
            txtCalculatedChecksum.Text = calculatedChecksum;

            if (calculatedChecksum.Equals(expectedChecksum, StringComparison.OrdinalIgnoreCase))
            {
                lblResult.Text = "Die Prüfsumme stimmt überein.";
            }
            else
            {
                lblResult.Text = "Die Prüfsumme stimmt nicht überein.";
            }
        }

        private string GetFileChecksum(string filePath, string hashAlgorithm)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("certutil.exe")
            {
                Arguments = $"-hashfile \"{filePath}\" {hashAlgorithm}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string output = reader.ReadToEnd();
                    string[] lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    if (lines.Length > 1)
                    {
                        return lines[1].Replace(" ", ""); // Remove spaces from checksum
                    }
                }
            }

            return string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbHashAlgorithm.Items.Add("MD5");
            cmbHashAlgorithm.Items.Add("SHA1");
            cmbHashAlgorithm.Items.Add("SHA256");
            cmbHashAlgorithm.Items.Add("SHA512");
            cmbHashAlgorithm.SelectedIndex = 0;

        }
    }
}
