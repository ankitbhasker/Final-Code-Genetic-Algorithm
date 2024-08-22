namespace Steganography
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxEncryption = new System.Windows.Forms.GroupBox();
            this.buttonSaveAsGrey = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.pictureBoxSimple = new System.Windows.Forms.PictureBox();
            this.buttonBrowseSecret = new System.Windows.Forms.Button();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.buttonGenerateResult = new System.Windows.Forms.Button();
            this.pictureBoxSecret = new System.Windows.Forms.PictureBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.pictureBoxExtractedImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxEncryptedImage = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDekey = new System.Windows.Forms.TextBox();
            this.buttonSaveAsFinal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDecryption = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxEncryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryptedImage)).BeginInit();
            this.groupBoxDecryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEncryption
            // 
            this.groupBoxEncryption.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEncryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxEncryption.Controls.Add(this.buttonSaveAsGrey);
            this.groupBoxEncryption.Controls.Add(this.buttonSaveAs);
            this.groupBoxEncryption.Controls.Add(this.pictureBoxSimple);
            this.groupBoxEncryption.Controls.Add(this.buttonBrowseSecret);
            this.groupBoxEncryption.Controls.Add(this.pictureBoxResult);
            this.groupBoxEncryption.Controls.Add(this.buttonGenerateResult);
            this.groupBoxEncryption.Controls.Add(this.pictureBoxSecret);
            this.groupBoxEncryption.ForeColor = System.Drawing.Color.White;
            this.groupBoxEncryption.Location = new System.Drawing.Point(140, 118);
            this.groupBoxEncryption.Name = "groupBoxEncryption";
            this.groupBoxEncryption.Size = new System.Drawing.Size(904, 410);
            this.groupBoxEncryption.TabIndex = 1;
            this.groupBoxEncryption.TabStop = false;
            this.groupBoxEncryption.Text = "Image Steganography";
            // 
            // buttonSaveAsGrey
            // 
            this.buttonSaveAsGrey.Enabled = false;
            this.buttonSaveAsGrey.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveAsGrey.Location = new System.Drawing.Point(303, 350);
            this.buttonSaveAsGrey.Name = "buttonSaveAsGrey";
            this.buttonSaveAsGrey.Size = new System.Drawing.Size(87, 27);
            this.buttonSaveAsGrey.TabIndex = 9;
            this.buttonSaveAsGrey.Text = "Save As";
            this.buttonSaveAsGrey.UseVisualStyleBackColor = true;
            this.buttonSaveAsGrey.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Enabled = false;
            this.buttonSaveAs.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveAs.Location = new System.Drawing.Point(715, 340);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(169, 46);
            this.buttonSaveAs.TabIndex = 4;
            this.buttonSaveAs.Text = "Save Your \r\nEncrypted Image";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // pictureBoxSimple
            // 
            this.pictureBoxSimple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSimple.Location = new System.Drawing.Point(15, 23);
            this.pictureBoxSimple.Name = "pictureBoxSimple";
            this.pictureBoxSimple.Size = new System.Drawing.Size(282, 311);
            this.pictureBoxSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSimple.TabIndex = 1;
            this.pictureBoxSimple.TabStop = false;
            // 
            // buttonBrowseSecret
            // 
            this.buttonBrowseSecret.ForeColor = System.Drawing.Color.Black;
            this.buttonBrowseSecret.Location = new System.Drawing.Point(416, 340);
            this.buttonBrowseSecret.Name = "buttonBrowseSecret";
            this.buttonBrowseSecret.Size = new System.Drawing.Size(169, 46);
            this.buttonBrowseSecret.TabIndex = 2;
            this.buttonBrowseSecret.Text = "Browse your\r\n Secret Image";
            this.buttonBrowseSecret.UseVisualStyleBackColor = true;
            this.buttonBrowseSecret.Click += new System.EventHandler(this.buttonBrowseSecret_Click);
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxResult.Location = new System.Drawing.Point(602, 23);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(282, 311);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResult.TabIndex = 5;
            this.pictureBoxResult.TabStop = false;
            // 
            // buttonGenerateResult
            // 
            this.buttonGenerateResult.Enabled = false;
            this.buttonGenerateResult.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateResult.Location = new System.Drawing.Point(15, 340);
            this.buttonGenerateResult.Name = "buttonGenerateResult";
            this.buttonGenerateResult.Size = new System.Drawing.Size(169, 46);
            this.buttonGenerateResult.TabIndex = 3;
            this.buttonGenerateResult.Text = "Generate your Encrypted Image";
            this.buttonGenerateResult.UseVisualStyleBackColor = true;
            this.buttonGenerateResult.Click += new System.EventHandler(this.buttonGenerateResult_Click);
            // 
            // pictureBoxSecret
            // 
            this.pictureBoxSecret.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSecret.Location = new System.Drawing.Point(303, 22);
            this.pictureBoxSecret.Name = "pictureBoxSecret";
            this.pictureBoxSecret.Size = new System.Drawing.Size(282, 311);
            this.pictureBoxSecret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSecret.TabIndex = 2;
            this.pictureBoxSecret.TabStop = false;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(77, 481);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.PasswordChar = '*';
            this.textBoxKey.Size = new System.Drawing.Size(57, 22);
            this.textBoxKey.TabIndex = 7;
            this.textBoxKey.Visible = false;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(0, 383);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 32);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDecryption
            // 
            this.buttonDecryption.ForeColor = System.Drawing.Color.Black;
            this.buttonDecryption.Location = new System.Drawing.Point(0, 223);
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.Size = new System.Drawing.Size(134, 74);
            this.buttonDecryption.TabIndex = 7;
            this.buttonDecryption.Text = "Decrypt Your Image";
            this.buttonDecryption.UseVisualStyleBackColor = true;
            this.buttonDecryption.Click += new System.EventHandler(this.buttonDecryption_Click);
            // 
            // buttonEncryption
            // 
            this.buttonEncryption.ForeColor = System.Drawing.Color.Black;
            this.buttonEncryption.Location = new System.Drawing.Point(0, 128);
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.Size = new System.Drawing.Size(134, 74);
            this.buttonEncryption.TabIndex = 8;
            this.buttonEncryption.Text = "Encrypt Your Image";
            this.buttonEncryption.UseVisualStyleBackColor = true;
            this.buttonEncryption.Click += new System.EventHandler(this.buttonEncryption_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.ForeColor = System.Drawing.Color.Black;
            this.buttonDecrypt.Location = new System.Drawing.Point(303, 338);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(87, 27);
            this.buttonDecrypt.TabIndex = 3;
            this.buttonDecrypt.Text = "Generate";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBoxExtractedImage
            // 
            this.pictureBoxExtractedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxExtractedImage.Location = new System.Drawing.Point(303, 21);
            this.pictureBoxExtractedImage.Name = "pictureBoxExtractedImage";
            this.pictureBoxExtractedImage.Size = new System.Drawing.Size(282, 311);
            this.pictureBoxExtractedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExtractedImage.TabIndex = 5;
            this.pictureBoxExtractedImage.TabStop = false;
            // 
            // pictureBoxEncryptedImage
            // 
            this.pictureBoxEncryptedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEncryptedImage.Location = new System.Drawing.Point(15, 23);
            this.pictureBoxEncryptedImage.Name = "pictureBoxEncryptedImage";
            this.pictureBoxEncryptedImage.Size = new System.Drawing.Size(282, 311);
            this.pictureBoxEncryptedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEncryptedImage.TabIndex = 1;
            this.pictureBoxEncryptedImage.TabStop = false;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(15, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDekey
            // 
            this.textBoxDekey.Location = new System.Drawing.Point(136, 382);
            this.textBoxDekey.Name = "textBoxDekey";
            this.textBoxDekey.PasswordChar = '*';
            this.textBoxDekey.Size = new System.Drawing.Size(196, 22);
            this.textBoxDekey.TabIndex = 7;
            this.textBoxDekey.TextChanged += new System.EventHandler(this.textBoxDekey_TextChanged);
            this.textBoxDekey.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDekey_Validating);
            // 
            // buttonSaveAsFinal
            // 
            this.buttonSaveAsFinal.Enabled = false;
            this.buttonSaveAsFinal.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveAsFinal.Location = new System.Drawing.Point(396, 338);
            this.buttonSaveAsFinal.Name = "buttonSaveAsFinal";
            this.buttonSaveAsFinal.Size = new System.Drawing.Size(87, 27);
            this.buttonSaveAsFinal.TabIndex = 4;
            this.buttonSaveAsFinal.Text = "Save As";
            this.buttonSaveAsFinal.UseVisualStyleBackColor = true;
            this.buttonSaveAsFinal.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Decryption Key";
            // 
            // groupBoxDecryption
            // 
            this.groupBoxDecryption.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDecryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxDecryption.Controls.Add(this.label2);
            this.groupBoxDecryption.Controls.Add(this.buttonSaveAsFinal);
            this.groupBoxDecryption.Controls.Add(this.textBoxDekey);
            this.groupBoxDecryption.Controls.Add(this.button2);
            this.groupBoxDecryption.Controls.Add(this.pictureBoxEncryptedImage);
            this.groupBoxDecryption.Controls.Add(this.pictureBoxExtractedImage);
            this.groupBoxDecryption.Controls.Add(this.buttonDecrypt);
            this.groupBoxDecryption.ForeColor = System.Drawing.Color.White;
            this.groupBoxDecryption.Location = new System.Drawing.Point(140, 118);
            this.groupBoxDecryption.Name = "groupBoxDecryption";
            this.groupBoxDecryption.Size = new System.Drawing.Size(904, 410);
            this.groupBoxDecryption.TabIndex = 10;
            this.groupBoxDecryption.TabStop = false;
            this.groupBoxDecryption.Text = "Image Steganography";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Steganography.Properties.Resources.title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1055, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxEncryption);
            this.Controls.Add(this.buttonEncryption);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonDecryption);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxDecryption);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxEncryption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryptedImage)).EndInit();
            this.groupBoxDecryption.ResumeLayout(false);
            this.groupBoxDecryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSimple;
        private System.Windows.Forms.PictureBox pictureBoxSecret;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.GroupBox groupBoxEncryption;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonBrowseSecret;
        private System.Windows.Forms.Button buttonGenerateResult;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonDecryption;
        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.Button buttonSaveAsGrey;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBoxDecryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAsFinal;
        private System.Windows.Forms.TextBox textBoxDekey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxEncryptedImage;
        private System.Windows.Forms.PictureBox pictureBoxExtractedImage;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

