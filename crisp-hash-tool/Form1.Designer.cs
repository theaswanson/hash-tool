namespace crisp_hash_tool
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.md4TextBox = new System.Windows.Forms.TextBox();
            this.md4Label = new System.Windows.Forms.Label();
            this.md5Label = new System.Windows.Forms.Label();
            this.md5TextBox = new System.Windows.Forms.TextBox();
            this.sha1Label = new System.Windows.Forms.Label();
            this.sha1TextBox = new System.Windows.Forms.TextBox();
            this.sha256Label = new System.Windows.Forms.Label();
            this.sha256TextBox = new System.Windows.Forms.TextBox();
            this.sha512Label = new System.Windows.Forms.Label();
            this.sha512TextBox = new System.Windows.Forms.TextBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.whirlpoolLabel = new System.Windows.Forms.Label();
            this.whirlpoolTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleclickHashToCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(88, 35);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(384, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // md4TextBox
            // 
            this.md4TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.md4TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.md4TextBox.Location = new System.Drawing.Point(88, 103);
            this.md4TextBox.Name = "md4TextBox";
            this.md4TextBox.ReadOnly = true;
            this.md4TextBox.Size = new System.Drawing.Size(384, 23);
            this.md4TextBox.TabIndex = 1;
            this.md4TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.md4TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.md4TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // md4Label
            // 
            this.md4Label.AutoSize = true;
            this.md4Label.Location = new System.Drawing.Point(12, 107);
            this.md4Label.Name = "md4Label";
            this.md4Label.Size = new System.Drawing.Size(33, 13);
            this.md4Label.TabIndex = 2;
            this.md4Label.Text = "MD4:";
            // 
            // md5Label
            // 
            this.md5Label.AutoSize = true;
            this.md5Label.Location = new System.Drawing.Point(12, 136);
            this.md5Label.Name = "md5Label";
            this.md5Label.Size = new System.Drawing.Size(33, 13);
            this.md5Label.TabIndex = 4;
            this.md5Label.Text = "MD5:";
            // 
            // md5TextBox
            // 
            this.md5TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.md5TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.md5TextBox.Location = new System.Drawing.Point(88, 132);
            this.md5TextBox.Name = "md5TextBox";
            this.md5TextBox.ReadOnly = true;
            this.md5TextBox.Size = new System.Drawing.Size(384, 23);
            this.md5TextBox.TabIndex = 3;
            this.md5TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.md5TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.md5TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // sha1Label
            // 
            this.sha1Label.AutoSize = true;
            this.sha1Label.Location = new System.Drawing.Point(12, 165);
            this.sha1Label.Name = "sha1Label";
            this.sha1Label.Size = new System.Drawing.Size(38, 13);
            this.sha1Label.TabIndex = 6;
            this.sha1Label.Text = "SHA1:";
            // 
            // sha1TextBox
            // 
            this.sha1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha1TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha1TextBox.Location = new System.Drawing.Point(88, 161);
            this.sha1TextBox.Name = "sha1TextBox";
            this.sha1TextBox.ReadOnly = true;
            this.sha1TextBox.Size = new System.Drawing.Size(384, 23);
            this.sha1TextBox.TabIndex = 5;
            this.sha1TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.sha1TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.sha1TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // sha256Label
            // 
            this.sha256Label.AutoSize = true;
            this.sha256Label.Location = new System.Drawing.Point(12, 194);
            this.sha256Label.Name = "sha256Label";
            this.sha256Label.Size = new System.Drawing.Size(50, 13);
            this.sha256Label.TabIndex = 8;
            this.sha256Label.Text = "SHA256:";
            // 
            // sha256TextBox
            // 
            this.sha256TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha256TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha256TextBox.Location = new System.Drawing.Point(88, 190);
            this.sha256TextBox.Name = "sha256TextBox";
            this.sha256TextBox.ReadOnly = true;
            this.sha256TextBox.Size = new System.Drawing.Size(384, 23);
            this.sha256TextBox.TabIndex = 7;
            this.sha256TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.sha256TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.sha256TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // sha512Label
            // 
            this.sha512Label.AutoSize = true;
            this.sha512Label.Location = new System.Drawing.Point(12, 223);
            this.sha512Label.Name = "sha512Label";
            this.sha512Label.Size = new System.Drawing.Size(50, 13);
            this.sha512Label.TabIndex = 10;
            this.sha512Label.Text = "SHA512:";
            // 
            // sha512TextBox
            // 
            this.sha512TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sha512TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sha512TextBox.Location = new System.Drawing.Point(88, 219);
            this.sha512TextBox.Name = "sha512TextBox";
            this.sha512TextBox.ReadOnly = true;
            this.sha512TextBox.Size = new System.Drawing.Size(384, 23);
            this.sha512TextBox.TabIndex = 9;
            this.sha512TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.sha512TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.sha512TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Checked = true;
            this.uppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseCheckBox.Location = new System.Drawing.Point(88, 61);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(117, 17);
            this.uppercaseCheckBox.TabIndex = 11;
            this.uppercaseCheckBox.Text = "Uppercase Hashes";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            this.uppercaseCheckBox.CheckedChanged += new System.EventHandler(this.uppercaseCheckBox_CheckedChanged);
            // 
            // whirlpoolLabel
            // 
            this.whirlpoolLabel.AutoSize = true;
            this.whirlpoolLabel.Location = new System.Drawing.Point(12, 252);
            this.whirlpoolLabel.Name = "whirlpoolLabel";
            this.whirlpoolLabel.Size = new System.Drawing.Size(54, 13);
            this.whirlpoolLabel.TabIndex = 13;
            this.whirlpoolLabel.Text = "Whirlpool:";
            // 
            // whirlpoolTextBox
            // 
            this.whirlpoolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whirlpoolTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whirlpoolTextBox.Location = new System.Drawing.Point(88, 248);
            this.whirlpoolTextBox.Name = "whirlpoolTextBox";
            this.whirlpoolTextBox.ReadOnly = true;
            this.whirlpoolTextBox.Size = new System.Drawing.Size(384, 23);
            this.whirlpoolTextBox.TabIndex = 12;
            this.whirlpoolTextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.whirlpoolTextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.whirlpoolTextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doubleclickHashToCopyToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // doubleclickHashToCopyToolStripMenuItem
            // 
            this.doubleclickHashToCopyToolStripMenuItem.Name = "doubleclickHashToCopyToolStripMenuItem";
            this.doubleclickHashToCopyToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.doubleclickHashToCopyToolStripMenuItem.Text = "Double-click hash to copy";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter text:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.whirlpoolLabel);
            this.Controls.Add(this.whirlpoolTextBox);
            this.Controls.Add(this.uppercaseCheckBox);
            this.Controls.Add(this.sha512Label);
            this.Controls.Add(this.sha512TextBox);
            this.Controls.Add(this.sha256Label);
            this.Controls.Add(this.sha256TextBox);
            this.Controls.Add(this.sha1Label);
            this.Controls.Add(this.sha1TextBox);
            this.Controls.Add(this.md5Label);
            this.Controls.Add(this.md5TextBox);
            this.Controls.Add(this.md4Label);
            this.Controls.Add(this.md4TextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 325);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "crisp\'s Hash Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox md4TextBox;
        private System.Windows.Forms.Label md4Label;
        private System.Windows.Forms.Label md5Label;
        private System.Windows.Forms.TextBox md5TextBox;
        private System.Windows.Forms.Label sha1Label;
        private System.Windows.Forms.TextBox sha1TextBox;
        private System.Windows.Forms.Label sha256Label;
        private System.Windows.Forms.TextBox sha256TextBox;
        private System.Windows.Forms.Label sha512Label;
        private System.Windows.Forms.TextBox sha512TextBox;
        private System.Windows.Forms.CheckBox uppercaseCheckBox;
        private System.Windows.Forms.Label whirlpoolLabel;
        private System.Windows.Forms.TextBox whirlpoolTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleclickHashToCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label2;
    }
}

