namespace hashtool
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
            this.MD4TextBox = new System.Windows.Forms.TextBox();
            this.md4Label = new System.Windows.Forms.Label();
            this.md5Label = new System.Windows.Forms.Label();
            this.MD5TextBox = new System.Windows.Forms.TextBox();
            this.sha1Label = new System.Windows.Forms.Label();
            this.SHA1TextBox = new System.Windows.Forms.TextBox();
            this.sha256Label = new System.Windows.Forms.Label();
            this.SHA256TextBox = new System.Windows.Forms.TextBox();
            this.sha512Label = new System.Windows.Forms.Label();
            this.SHA512TextBox = new System.Windows.Forms.TextBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.whirlpoolLabel = new System.Windows.Forms.Label();
            this.WhirlpoolTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleclickHashToCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textPage = new System.Windows.Forms.TabPage();
            this.filePage = new System.Windows.Forms.TabPage();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.textPage.SuspendLayout();
            this.filePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(113, 7);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(448, 22);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // MD4TextBox
            // 
            this.MD4TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MD4TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD4TextBox.Location = new System.Drawing.Point(117, 134);
            this.MD4TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MD4TextBox.Name = "MD4TextBox";
            this.MD4TextBox.ReadOnly = true;
            this.MD4TextBox.Size = new System.Drawing.Size(448, 27);
            this.MD4TextBox.TabIndex = 1;
            this.MD4TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.MD4TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.MD4TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // md4Label
            // 
            this.md4Label.AutoSize = true;
            this.md4Label.Location = new System.Drawing.Point(16, 139);
            this.md4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.md4Label.Name = "md4Label";
            this.md4Label.Size = new System.Drawing.Size(41, 17);
            this.md4Label.TabIndex = 2;
            this.md4Label.Text = "MD4:";
            // 
            // md5Label
            // 
            this.md5Label.AutoSize = true;
            this.md5Label.Location = new System.Drawing.Point(16, 174);
            this.md5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.md5Label.Name = "md5Label";
            this.md5Label.Size = new System.Drawing.Size(41, 17);
            this.md5Label.TabIndex = 4;
            this.md5Label.Text = "MD5:";
            // 
            // MD5TextBox
            // 
            this.MD5TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MD5TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5TextBox.Location = new System.Drawing.Point(117, 169);
            this.MD5TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MD5TextBox.Name = "MD5TextBox";
            this.MD5TextBox.ReadOnly = true;
            this.MD5TextBox.Size = new System.Drawing.Size(448, 27);
            this.MD5TextBox.TabIndex = 3;
            this.MD5TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.MD5TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.MD5TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // sha1Label
            // 
            this.sha1Label.AutoSize = true;
            this.sha1Label.Location = new System.Drawing.Point(16, 210);
            this.sha1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sha1Label.Name = "sha1Label";
            this.sha1Label.Size = new System.Drawing.Size(48, 17);
            this.sha1Label.TabIndex = 6;
            this.sha1Label.Text = "SHA1:";
            // 
            // SHA1TextBox
            // 
            this.SHA1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA1TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA1TextBox.Location = new System.Drawing.Point(117, 205);
            this.SHA1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SHA1TextBox.Name = "SHA1TextBox";
            this.SHA1TextBox.ReadOnly = true;
            this.SHA1TextBox.Size = new System.Drawing.Size(448, 27);
            this.SHA1TextBox.TabIndex = 5;
            this.SHA1TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.SHA1TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.SHA1TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // sha256Label
            // 
            this.sha256Label.AutoSize = true;
            this.sha256Label.Location = new System.Drawing.Point(16, 246);
            this.sha256Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sha256Label.Name = "sha256Label";
            this.sha256Label.Size = new System.Drawing.Size(64, 17);
            this.sha256Label.TabIndex = 8;
            this.sha256Label.Text = "SHA256:";
            // 
            // SHA256TextBox
            // 
            this.SHA256TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA256TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA256TextBox.Location = new System.Drawing.Point(117, 241);
            this.SHA256TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SHA256TextBox.Name = "SHA256TextBox";
            this.SHA256TextBox.ReadOnly = true;
            this.SHA256TextBox.Size = new System.Drawing.Size(448, 27);
            this.SHA256TextBox.TabIndex = 7;
            this.SHA256TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.SHA256TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.SHA256TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // sha512Label
            // 
            this.sha512Label.AutoSize = true;
            this.sha512Label.Location = new System.Drawing.Point(16, 281);
            this.sha512Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sha512Label.Name = "sha512Label";
            this.sha512Label.Size = new System.Drawing.Size(64, 17);
            this.sha512Label.TabIndex = 10;
            this.sha512Label.Text = "SHA512:";
            // 
            // SHA512TextBox
            // 
            this.SHA512TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SHA512TextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA512TextBox.Location = new System.Drawing.Point(117, 277);
            this.SHA512TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SHA512TextBox.Name = "SHA512TextBox";
            this.SHA512TextBox.ReadOnly = true;
            this.SHA512TextBox.Size = new System.Drawing.Size(448, 27);
            this.SHA512TextBox.TabIndex = 9;
            this.SHA512TextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.SHA512TextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.SHA512TextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Checked = true;
            this.uppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseCheckBox.Location = new System.Drawing.Point(117, 105);
            this.uppercaseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(151, 21);
            this.uppercaseCheckBox.TabIndex = 11;
            this.uppercaseCheckBox.Text = "Uppercase Hashes";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            this.uppercaseCheckBox.CheckedChanged += new System.EventHandler(this.uppercaseCheckBox_CheckedChanged);
            // 
            // whirlpoolLabel
            // 
            this.whirlpoolLabel.AutoSize = true;
            this.whirlpoolLabel.Location = new System.Drawing.Point(16, 317);
            this.whirlpoolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.whirlpoolLabel.Name = "whirlpoolLabel";
            this.whirlpoolLabel.Size = new System.Drawing.Size(71, 17);
            this.whirlpoolLabel.TabIndex = 13;
            this.whirlpoolLabel.Text = "Whirlpool:";
            // 
            // WhirlpoolTextBox
            // 
            this.WhirlpoolTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WhirlpoolTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhirlpoolTextBox.Location = new System.Drawing.Point(117, 312);
            this.WhirlpoolTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WhirlpoolTextBox.Name = "WhirlpoolTextBox";
            this.WhirlpoolTextBox.ReadOnly = true;
            this.WhirlpoolTextBox.Size = new System.Drawing.Size(448, 27);
            this.WhirlpoolTextBox.TabIndex = 12;
            this.WhirlpoolTextBox.Click += new System.EventHandler(this.TextBoxClicked);
            this.WhirlpoolTextBox.DoubleClick += new System.EventHandler(this.CopyTextBoxText);
            this.WhirlpoolTextBox.Enter += new System.EventHandler(this.TextBoxGainsFocus);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doubleclickHashToCopyToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // doubleclickHashToCopyToolStripMenuItem
            // 
            this.doubleclickHashToCopyToolStripMenuItem.Name = "doubleclickHashToCopyToolStripMenuItem";
            this.doubleclickHashToCopyToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.doubleclickHashToCopyToolStripMenuItem.Text = "Double-click hash to copy";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter text:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.textPage);
            this.tabControl1.Controls.Add(this.filePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 70);
            this.tabControl1.TabIndex = 18;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // textPage
            // 
            this.textPage.Controls.Add(this.inputTextBox);
            this.textPage.Controls.Add(this.label2);
            this.textPage.Location = new System.Drawing.Point(4, 25);
            this.textPage.Name = "textPage";
            this.textPage.Padding = new System.Windows.Forms.Padding(3);
            this.textPage.Size = new System.Drawing.Size(574, 41);
            this.textPage.TabIndex = 0;
            this.textPage.Text = "Text";
            this.textPage.UseVisualStyleBackColor = true;
            // 
            // filePage
            // 
            this.filePage.Controls.Add(this.chooseFileButton);
            this.filePage.Controls.Add(this.filePathTextBox);
            this.filePage.Controls.Add(this.label1);
            this.filePage.Location = new System.Drawing.Point(4, 25);
            this.filePage.Name = "filePage";
            this.filePage.Padding = new System.Windows.Forms.Padding(3);
            this.filePage.Size = new System.Drawing.Size(574, 41);
            this.filePage.TabIndex = 1;
            this.filePage.Text = "File";
            this.filePage.UseVisualStyleBackColor = true;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(113, 9);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(75, 23);
            this.chooseFileButton.TabIndex = 20;
            this.chooseFileButton.Text = "Open";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(195, 9);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(367, 22);
            this.filePathTextBox.TabIndex = 18;
            this.filePathTextBox.TextChanged += new System.EventHandler(this.filePathTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Choose file:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 363);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.whirlpoolLabel);
            this.Controls.Add(this.uppercaseCheckBox);
            this.Controls.Add(this.WhirlpoolTextBox);
            this.Controls.Add(this.sha512Label);
            this.Controls.Add(this.SHA512TextBox);
            this.Controls.Add(this.sha256Label);
            this.Controls.Add(this.SHA256TextBox);
            this.Controls.Add(this.sha1Label);
            this.Controls.Add(this.SHA1TextBox);
            this.Controls.Add(this.md5Label);
            this.Controls.Add(this.MD5TextBox);
            this.Controls.Add(this.md4Label);
            this.Controls.Add(this.MD4TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(394, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.textPage.ResumeLayout(false);
            this.textPage.PerformLayout();
            this.filePage.ResumeLayout(false);
            this.filePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox MD4TextBox;
        private System.Windows.Forms.Label md4Label;
        private System.Windows.Forms.Label md5Label;
        private System.Windows.Forms.TextBox MD5TextBox;
        private System.Windows.Forms.Label sha1Label;
        private System.Windows.Forms.TextBox SHA1TextBox;
        private System.Windows.Forms.Label sha256Label;
        private System.Windows.Forms.TextBox SHA256TextBox;
        private System.Windows.Forms.Label sha512Label;
        private System.Windows.Forms.TextBox SHA512TextBox;
        private System.Windows.Forms.CheckBox uppercaseCheckBox;
        private System.Windows.Forms.Label whirlpoolLabel;
        private System.Windows.Forms.TextBox WhirlpoolTextBox;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage textPage;
        private System.Windows.Forms.TabPage filePage;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
    }
}

