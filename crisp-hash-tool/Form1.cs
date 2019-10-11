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

namespace crisp_hash_tool
{
    public partial class Form1 : Form
    {
        List<TextBox> myTextBoxes = new List<TextBox>();
        TextHasher textHasher = new TextHasher();

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
                ClearTextboxes();
                return;
            }

            UpdateHashes(inputText);
            UpdateHashTextCasing();
        }

        private void ClearTextboxes()
        {
            foreach (TextBox textBox in myTextBoxes)
                textBox.Text = "";
        }

        private void UpdateHashes(string inputText)
        {
            textHasher.textToHash = inputText;
            MD4TextBox.Text = textHasher.GetMD4();
            MD5TextBox.Text = textHasher.GetMD5();
            SHA1TextBox.Text = textHasher.GetSHA1();
            SHA256TextBox.Text = textHasher.GetSHA256();
            SHA512TextBox.Text = textHasher.GetSHA512();
            WhirlpoolTextBox.Text = textHasher.GetWhirlpool();
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
            Form aboutForm = new About();
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
            lines.Add("// Generated with crisp's Hash Tool");
            lines.Add(inputTextBox.Text);
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
    }
}
