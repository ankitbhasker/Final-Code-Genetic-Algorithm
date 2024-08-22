namespace Steganography
{
    partial class ImagDecrypt
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
            this.groupBoxDecryption = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveAsFinal = new System.Windows.Forms.Button();
            this.textBoxDekey = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.pictureBoxEncryptedImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxExtractedImage = new System.Windows.Forms.PictureBox();
            this.groupBoxDecryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryptedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedImage)).BeginInit();
            this.SuspendLayout();
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
            this.groupBoxDecryption.Location = new System.Drawing.Point(131, 76);
            this.groupBoxDecryption.Name = "groupBoxDecryption";
            this.groupBoxDecryption.Size = new System.Drawing.Size(646, 307);
            this.groupBoxDecryption.TabIndex = 11;
            this.groupBoxDecryption.TabStop = false;
            this.groupBoxDecryption.Text = "Image Steganography";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Decryption Key";
            // 
            // buttonSaveAsFinal
            // 
            this.buttonSaveAsFinal.Enabled = false;
            this.buttonSaveAsFinal.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveAsFinal.Location = new System.Drawing.Point(334, 212);
            this.buttonSaveAsFinal.Name = "buttonSaveAsFinal";
            this.buttonSaveAsFinal.Size = new System.Drawing.Size(87, 27);
            this.buttonSaveAsFinal.TabIndex = 4;
            this.buttonSaveAsFinal.Text = "Save As";
            this.buttonSaveAsFinal.UseVisualStyleBackColor = true;
            // 
            // textBoxDekey
            // 
            this.textBoxDekey.Location = new System.Drawing.Point(17, 267);
            this.textBoxDekey.Name = "textBoxDekey";
            this.textBoxDekey.PasswordChar = '*';
            this.textBoxDekey.Size = new System.Drawing.Size(196, 20);
            this.textBoxDekey.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(127, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.ForeColor = System.Drawing.Color.Black;
            this.buttonDecrypt.Location = new System.Drawing.Point(243, 264);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(87, 27);
            this.buttonDecrypt.TabIndex = 3;
            this.buttonDecrypt.Text = "Generate";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // pictureBoxEncryptedImage
            // 
            this.pictureBoxEncryptedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEncryptedImage.Location = new System.Drawing.Point(17, 22);
            this.pictureBoxEncryptedImage.Name = "pictureBoxEncryptedImage";
            this.pictureBoxEncryptedImage.Size = new System.Drawing.Size(196, 183);
            this.pictureBoxEncryptedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEncryptedImage.TabIndex = 1;
            this.pictureBoxEncryptedImage.TabStop = false;
            // 
            // pictureBoxExtractedImage
            // 
            this.pictureBoxExtractedImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxExtractedImage.Location = new System.Drawing.Point(224, 22);
            this.pictureBoxExtractedImage.Name = "pictureBoxExtractedImage";
            this.pictureBoxExtractedImage.Size = new System.Drawing.Size(196, 183);
            this.pictureBoxExtractedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExtractedImage.TabIndex = 5;
            this.pictureBoxExtractedImage.TabStop = false;
            // 
            // ImagDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 458);
            this.Controls.Add(this.groupBoxDecryption);
            this.Name = "ImagDecrypt";
            this.Text = "ImagDecrypt";
            this.groupBoxDecryption.ResumeLayout(false);
            this.groupBoxDecryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncryptedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExtractedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDecryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveAsFinal;
        private System.Windows.Forms.TextBox textBoxDekey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxEncryptedImage;
        private System.Windows.Forms.PictureBox pictureBoxExtractedImage;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}