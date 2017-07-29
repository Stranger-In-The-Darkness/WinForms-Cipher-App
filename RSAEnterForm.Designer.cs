namespace Cipher
{
    partial class RSAEnterForm
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
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eTextBox
            // 
            this.eTextBox.Location = new System.Drawing.Point(12, 25);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(160, 20);
            this.eTextBox.TabIndex = 0;
            this.eTextBox.Tag = "\"e\"";
            this.eTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter e:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter n:";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(12, 73);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(160, 20);
            this.nTextBox.TabIndex = 5;
            this.nTextBox.Tag = "\"n\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter p:";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(12, 121);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(160, 20);
            this.pTextBox.TabIndex = 10;
            this.pTextBox.Tag = "\"p\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter q:";
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(12, 169);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(160, 20);
            this.qTextBox.TabIndex = 15;
            this.qTextBox.Tag = "\"q\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RSAEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 229);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eTextBox);
            this.Name = "RSAEnterForm";
            this.Text = "RSAEnterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}