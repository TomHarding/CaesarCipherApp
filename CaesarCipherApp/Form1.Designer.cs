namespace CaesarCipherApp
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
            this.textToEncrypt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.charShift = new System.Windows.Forms.TextBox();
            this.cipher = new System.Windows.Forms.RichTextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decryptRB = new System.Windows.Forms.RadioButton();
            this.encryptRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textToEncrypt
            // 
            this.textToEncrypt.Location = new System.Drawing.Point(12, 38);
            this.textToEncrypt.Name = "textToEncrypt";
            this.textToEncrypt.Size = new System.Drawing.Size(260, 110);
            this.textToEncrypt.TabIndex = 0;
            this.textToEncrypt.Text = "Text to encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Caesar Cipher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Character shift:";
            // 
            // charShift
            // 
            this.charShift.Location = new System.Drawing.Point(96, 152);
            this.charShift.Name = "charShift";
            this.charShift.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.charShift.Size = new System.Drawing.Size(42, 20);
            this.charShift.TabIndex = 3;
            this.charShift.Text = "1";
            // 
            // cipher
            // 
            this.cipher.Location = new System.Drawing.Point(12, 240);
            this.cipher.Name = "cipher";
            this.cipher.Size = new System.Drawing.Size(260, 108);
            this.cipher.TabIndex = 4;
            this.cipher.Text = "";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptBtn.Location = new System.Drawing.Point(144, 155);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(128, 79);
            this.encryptBtn.TabIndex = 5;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decryptRB);
            this.groupBox1.Controls.Add(this.encryptRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 56);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // decryptRB
            // 
            this.decryptRB.AutoSize = true;
            this.decryptRB.Location = new System.Drawing.Point(6, 30);
            this.decryptRB.Name = "decryptRB";
            this.decryptRB.Size = new System.Drawing.Size(62, 17);
            this.decryptRB.TabIndex = 1;
            this.decryptRB.TabStop = true;
            this.decryptRB.Text = "Decrypt";
            this.decryptRB.UseVisualStyleBackColor = true;
            this.decryptRB.Click += new System.EventHandler(this.radioButtons_Click);
            // 
            // encryptRB
            // 
            this.encryptRB.AutoSize = true;
            this.encryptRB.Checked = true;
            this.encryptRB.Location = new System.Drawing.Point(6, 7);
            this.encryptRB.Name = "encryptRB";
            this.encryptRB.Size = new System.Drawing.Size(61, 17);
            this.encryptRB.TabIndex = 0;
            this.encryptRB.TabStop = true;
            this.encryptRB.Text = "Encrypt";
            this.encryptRB.UseVisualStyleBackColor = true;
            this.encryptRB.Click += new System.EventHandler(this.radioButtons_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 359);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.cipher);
            this.Controls.Add(this.charShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textToEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textToEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox charShift;
        private System.Windows.Forms.RichTextBox cipher;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton decryptRB;
        private System.Windows.Forms.RadioButton encryptRB;
    }
}

