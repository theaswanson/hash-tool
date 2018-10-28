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

        public Form1()
        {
            InitializeComponent();
            myTextBoxes.Add(md4TextBox);
            myTextBoxes.Add(md5TextBox);
            myTextBoxes.Add(sha1TextBox);
            myTextBoxes.Add(sha256TextBox);
            myTextBoxes.Add(sha512TextBox);
            myTextBoxes.Add(whirlpoolTextBox);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = inputTextBox.Text;

            // if input is blank, display blank hashes
            if (String.IsNullOrEmpty(text))
            {
                foreach (TextBox textBox in myTextBoxes)
                    textBox.Text = "";

                return;
            }

            md4TextBox.Text = GetMd4Hash(text);
            md5TextBox.Text = GetMd5Hash(text);
            sha1TextBox.Text = GetSha1Hash(text);
            sha256TextBox.Text = GetSha256Hash(text);
            sha512TextBox.Text = GetSha512Hash(text);
            whirlpoolTextBox.Text = GetWhirlpoolHash(text);

            // display uppercase hashes
            if (uppercaseCheckBox.Checked == true)
                foreach (TextBox textBox in myTextBoxes)
                    textBox.Text = textBox.Text.ToUpper();
        }

        static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            return BytesToHash(data);
        }

        static string GetSha1Hash(string input)
        {
            SHA1 sha1Hash = SHA1.Create();
            byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            return BytesToHash(data);
        }

        static string GetSha256Hash(string input)
        {
            SHA256 sha256Hash = SHA256.Create();
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            return BytesToHash(data);
        }

        static string GetSha512Hash(string input)
        {
            SHA512 sha512Hash = SHA512.Create();
            byte[] data = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            return BytesToHash(data);
        }

        static string GetMd4Hash(string input)
        {
            // get padded uints from bytes
            List<byte> bytes = Encoding.ASCII.GetBytes(input).ToList();
            uint bitCount = (uint)(bytes.Count) * 8;
            bytes.Add(128);
            while (bytes.Count % 64 != 56) bytes.Add(0);
            var uints = new List<uint>();
            for (int i = 0; i + 3 < bytes.Count; i += 4)
                uints.Add(bytes[i] | (uint)bytes[i + 1] << 8 | (uint)bytes[i + 2] << 16 | (uint)bytes[i + 3] << 24);
            uints.Add(bitCount);
            uints.Add(0);

            // run rounds
            uint a = 0x67452301, b = 0xefcdab89, c = 0x98badcfe, d = 0x10325476;
            Func<uint, uint, uint> rol = (x, y) => x << (int)y | x >> 32 - (int)y;
            for (int q = 0; q + 15 < uints.Count; q += 16)
            {
                var chunk = uints.GetRange(q, 16);
                uint aa = a, bb = b, cc = c, dd = d;
                Action<Func<uint, uint, uint, uint>, uint[]> round = (f, y) =>
                {
                    foreach (uint i in new[] { y[0], y[1], y[2], y[3] })
                    {
                        a = rol(a + f(b, c, d) + chunk[(int)(i + y[4])] + y[12], y[8]);
                        d = rol(d + f(a, b, c) + chunk[(int)(i + y[5])] + y[12], y[9]);
                        c = rol(c + f(d, a, b) + chunk[(int)(i + y[6])] + y[12], y[10]);
                        b = rol(b + f(c, d, a) + chunk[(int)(i + y[7])] + y[12], y[11]);
                    }
                };
                round((x, y, z) => (x & y) | (~x & z), new uint[] { 0, 4, 8, 12, 0, 1, 2, 3, 3, 7, 11, 19, 0 });
                round((x, y, z) => (x & y) | (x & z) | (y & z), new uint[] { 0, 1, 2, 3, 0, 4, 8, 12, 3, 5, 9, 13, 0x5a827999 });
                round((x, y, z) => x ^ y ^ z, new uint[] { 0, 2, 1, 3, 0, 8, 4, 12, 3, 9, 11, 15, 0x6ed9eba1 });
                a += aa; b += bb; c += cc; d += dd;
            }

            // return hex encoded string
            byte[] outBytes = new[] { a, b, c, d }.SelectMany(BitConverter.GetBytes).ToArray();
            return BitConverter.ToString(outBytes).Replace("-", "").ToLower();
        }

        static string GetWhirlpoolHash(string input)
        {
            WhirlpoolManaged whirlpoolHash = new WhirlpoolManaged();
            byte[] data = whirlpoolHash.ComputeHash(Encoding.UTF8.GetBytes(input));

            return BytesToHash(data);
        }

        static string BytesToHash(byte[] data)
        {
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void uppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            foreach (TextBox textBox in myTextBoxes)
            {
                if (uppercaseCheckBox.Checked == true)
                    textBox.Text = textBox.Text.ToUpper();
                else
                    textBox.Text = textBox.Text.ToLower();
            }
        }

        private void TextBoxGainsFocus(object sender, EventArgs e)
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
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.SelectAll();
            }
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
            lines.Add("MD4: " + md4TextBox.Text);
            lines.Add("MD5: " + md5TextBox.Text);
            lines.Add("SHA1: " + sha1TextBox.Text);
            lines.Add("SHA256: " + sha256TextBox.Text);
            lines.Add("SHA512: " + sha512TextBox.Text);
            lines.Add("Whirlpool: " + whirlpoolTextBox.Text);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
