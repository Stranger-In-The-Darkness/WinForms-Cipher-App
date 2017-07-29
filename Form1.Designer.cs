namespace Cipher
{
    partial class Cipher_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cipher_Main_Form));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.codeCheck = new System.Windows.Forms.RadioButton();
            this.decodeCheck = new System.Windows.Forms.RadioButton();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.doItButton = new System.Windows.Forms.Button();
            this.enterKeyButton = new System.Windows.Forms.Button();
            this.generateKeyButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openKeyFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveKeyFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(12, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(600, 23);
            this.textBox2.TabIndex = 2;
            // 
            // codeCheck
            // 
            this.codeCheck.AutoSize = true;
            this.codeCheck.BackColor = System.Drawing.Color.Transparent;
            this.codeCheck.Enabled = false;
            this.codeCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.codeCheck.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeCheck.Location = new System.Drawing.Point(12, 16);
            this.codeCheck.Name = "codeCheck";
            this.codeCheck.Size = new System.Drawing.Size(67, 24);
            this.codeCheck.TabIndex = 3;
            this.codeCheck.TabStop = true;
            this.codeCheck.Text = "Code";
            this.codeCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.codeCheck.UseVisualStyleBackColor = false;
            this.codeCheck.CheckedChanged += new System.EventHandler(this.codeCheck_CheckedChanged);
            // 
            // decodeCheck
            // 
            this.decodeCheck.AutoSize = true;
            this.decodeCheck.BackColor = System.Drawing.Color.Transparent;
            this.decodeCheck.Enabled = false;
            this.decodeCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.decodeCheck.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodeCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.decodeCheck.Location = new System.Drawing.Point(12, 46);
            this.decodeCheck.Name = "decodeCheck";
            this.decodeCheck.Size = new System.Drawing.Size(82, 24);
            this.decodeCheck.TabIndex = 4;
            this.decodeCheck.TabStop = true;
            this.decodeCheck.Text = "Decode";
            this.decodeCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.decodeCheck.UseVisualStyleBackColor = false;
            this.decodeCheck.CheckedChanged += new System.EventHandler(this.decodeCheck_CheckedChanged);
            // 
            // comboBox
            // 
            this.comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox.Enabled = false;
            this.comboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Caesar",
            "Substitution",
            "Fence",
            "Rail fence",
            "Vigenere",
            "Autokey",
            "Polimorphic (Вроде работает...)",
            "Bigram",
            "Matrix",
            "Cardani ",
            "One-use notebook",
            "ADFGWX",
            "RSA"});
            this.comboBox.Location = new System.Drawing.Point(312, 139);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(300, 23);
            this.comboBox.TabIndex = 6;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // doItButton
            // 
            this.doItButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doItButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doItButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doItButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.doItButton.FlatAppearance.BorderSize = 5;
            this.doItButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doItButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doItButton.Location = new System.Drawing.Point(471, 172);
            this.doItButton.Name = "doItButton";
            this.doItButton.Size = new System.Drawing.Size(141, 60);
            this.doItButton.TabIndex = 7;
            this.doItButton.Text = "Do It!";
            this.doItButton.UseVisualStyleBackColor = false;
            this.doItButton.Click += new System.EventHandler(this.doItButton_Click);
            // 
            // enterKeyButton
            // 
            this.enterKeyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enterKeyButton.Enabled = false;
            this.enterKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enterKeyButton.FlatAppearance.BorderSize = 5;
            this.enterKeyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enterKeyButton.Location = new System.Drawing.Point(12, 137);
            this.enterKeyButton.Name = "enterKeyButton";
            this.enterKeyButton.Size = new System.Drawing.Size(145, 40);
            this.enterKeyButton.TabIndex = 8;
            this.enterKeyButton.Text = "Enter Key";
            this.enterKeyButton.UseVisualStyleBackColor = false;
            this.enterKeyButton.Click += new System.EventHandler(this.enterKeyButton_Click);
            // 
            // generateKeyButton
            // 
            this.generateKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateKeyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generateKeyButton.Enabled = false;
            this.generateKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generateKeyButton.FlatAppearance.BorderSize = 5;
            this.generateKeyButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generateKeyButton.Location = new System.Drawing.Point(12, 183);
            this.generateKeyButton.Name = "generateKeyButton";
            this.generateKeyButton.Size = new System.Drawing.Size(145, 40);
            this.generateKeyButton.TabIndex = 9;
            this.generateKeyButton.Text = "Generate Key";
            this.generateKeyButton.UseVisualStyleBackColor = false;
            this.generateKeyButton.Click += new System.EventHandler(this.generateKeyButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Enabled = false;
            this.keyTextBox.Location = new System.Drawing.Point(12, 243);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(600, 23);
            this.keyTextBox.TabIndex = 10;
            this.keyTextBox.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuStrip.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.keyToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveKeyToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.keyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.keyToolStripMenuItem.Text = "Open key";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.keyToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveKeyToolStripMenuItem
            // 
            this.saveKeyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveKeyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveKeyToolStripMenuItem.Name = "saveKeyToolStripMenuItem";
            this.saveKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveKeyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.saveKeyToolStripMenuItem.Text = "Save key";
            this.saveKeyToolStripMenuItem.Click += new System.EventHandler(this.saveKeyToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files|*.txt|All files|*.*";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // openKeyFileDialog
            // 
            this.openKeyFileDialog.Filter = "Text files|*.txt|All files|*.*";
            this.openKeyFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openKeyFileDialog_FileOk);
            // 
            // saveKeyFileDialog
            // 
            this.saveKeyFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveKeyFileDialog_FileOk);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 27);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(600, 104);
            this.textBox.TabIndex = 12;
            this.textBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.codeCheck);
            this.panel1.Controls.Add(this.decodeCheck);
            this.panel1.Location = new System.Drawing.Point(163, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 86);
            this.panel1.TabIndex = 13;
            // 
            // Cipher_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(624, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.generateKeyButton);
            this.Controls.Add(this.enterKeyButton);
            this.Controls.Add(this.doItButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Cipher_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cipher";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton codeCheck;
        private System.Windows.Forms.RadioButton decodeCheck;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button doItButton;
        private System.Windows.Forms.Button enterKeyButton;
        private System.Windows.Forms.Button generateKeyButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveKeyToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.OpenFileDialog openKeyFileDialog;
        private System.Windows.Forms.SaveFileDialog saveKeyFileDialog;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Panel panel1;
    }
}

