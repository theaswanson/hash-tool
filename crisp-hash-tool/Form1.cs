using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpTest.Net.Crypto;

namespace hashtool
{
    public partial class Form1 : Form
    {
        List<TextBox> myTextBoxes = new List<TextBox>();
        TextHasher textHasher = new TextHasher();
        FileHasher fileHasher = new FileHasher();

        public Form1()
        {
            InitializeComponent();
            myTextBoxes.Add(MD4TextBox);
            myTextBoxes.Add(MD5TextBox);
            myTextBoxes.Add(SHA1TextBox);
            myTextBoxes.Add(SHA256TextBox);
            myTextBoxes.Add(SHA512TextBox);
            myTextBoxes.Add(WhirlpoolTextBox);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;

            if (String.IsNullOrEmpty(inputText))
            {
                ClearTextBoxes();
                return;
            }

            UpdateTextHashes(inputText);
        }

        private void ClearTextBoxes()
        {
            foreach (TextBox textBox in myTextBoxes)
                textBox.Text = "";
        }

        private void UpdateTextHashes(string inputText)
        {
            if (String.IsNullOrEmpty(inputText))
            {
                ClearTextBoxes();
                return;
            }

            textHasher.textToHash = inputText;
            MD4TextBox.Text = textHasher.GetMD4();
            MD5TextBox.Text = textHasher.GetMD5();
            SHA1TextBox.Text = textHasher.GetSHA1();
            SHA256TextBox.Text = textHasher.GetSHA256();
            SHA512TextBox.Text = textHasher.GetSHA512();
            WhirlpoolTextBox.Text = textHasher.GetWhirlpool();
            UpdateHashTextCasing();
        }

        private void UpdateFileHashes(string filePath)
        {
            if (String.IsNullOrEmpty(filePath))
            {
                ClearTextBoxes();
                return;
            }

            fileHasher.SetFilePath(filePath);
            MD4TextBox.Text = fileHasher.GetMD4();
            MD5TextBox.Text = fileHasher.GetMD5();
            SHA1TextBox.Text = fileHasher.GetSHA1();
            SHA256TextBox.Text = fileHasher.GetSHA256();
            SHA512TextBox.Text = fileHasher.GetSHA512();
            WhirlpoolTextBox.Text = fileHasher.GetWhirlpool();
            UpdateHashTextCasing();
        }

        private void uppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHashTextCasing();
        }

        private void UpdateHashTextCasing()
        {
            foreach (TextBox textBox in myTextBoxes)
                textBox.Text = uppercaseCheckBox.Checked ? textBox.Text.ToUpper() : textBox.Text.ToLower();
        }

        private void TextBoxGainsFocus(object sender, EventArgs e)
        {
            SelectTextBoxText(sender);
        }

        private static void SelectTextBoxText(object sender)
        {
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.SelectAll();
            }
        }

        private void CopyTextBoxText(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.SelectAll();
                if (!String.IsNullOrEmpty(textBox.Text))
                    Clipboard.SetText(textBox.Text);
            }
        }

        private void TextBoxClicked(object sender, EventArgs e)
        {
            SelectTextBoxText(sender);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.Show(this);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";

            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
                else
                    return;
            }

            List<string> lines = new List<string>();
            lines.Add("// Generated with Hash Tool, developed by Layer 7");
            if (tabControl1.SelectedTab.Text == "Text")
                lines.Add("Input text: " + inputTextBox.Text);
            else
                lines.Add("Input file: " + filePathTextBox.Text);
            lines.Add("MD4: " + MD4TextBox.Text);
            lines.Add("MD5: " + MD5TextBox.Text);
            lines.Add("SHA1: " + SHA1TextBox.Text);
            lines.Add("SHA256: " + SHA256TextBox.Text);
            lines.Add("SHA512: " + SHA512TextBox.Text);
            lines.Add("Whirlpool: " + WhirlpoolTextBox.Text);

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, false))
                {
                    foreach (string line in lines)
                        file.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            string filePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            filePathTextBox.Text = filePath;
        }

        private void filePathTextBox_TextChanged(object sender, EventArgs e)
        {
            string filePath = filePathTextBox.Text;

            if (String.IsNullOrEmpty(filePath))
            {
                ClearTextBoxes();
                return;
            }

            UpdateFileHashes(filePath);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Text")
                UpdateTextHashes(inputTextBox.Text);
            else
                UpdateFileHashes(filePathTextBox.Text);
        }
    }
}
