
namespace ZXing.NET_QR_Code_C_Sharp_Example
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encodedText = new System.Windows.Forms.TextBox();
            this.textInfo = new System.Windows.Forms.Label();
            this.qrOutput = new System.Windows.Forms.PictureBox();
            this.saveQR = new System.Windows.Forms.Button();
            this.loadQR = new System.Windows.Forms.Button();
            this.copyQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // encodedText
            // 
            this.encodedText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encodedText.Location = new System.Drawing.Point(39, 46);
            this.encodedText.Multiline = true;
            this.encodedText.Name = "encodedText";
            this.encodedText.Size = new System.Drawing.Size(322, 111);
            this.encodedText.TabIndex = 0;
            this.encodedText.TextChanged += new System.EventHandler(this.encodedText_TextChanged);
            // 
            // textInfo
            // 
            this.textInfo.AutoSize = true;
            this.textInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInfo.Location = new System.Drawing.Point(39, 13);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(136, 30);
            this.textInfo.TabIndex = 1;
            this.textInfo.Text = "Encoded Text";
            // 
            // qrOutput
            // 
            this.qrOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrOutput.Location = new System.Drawing.Point(39, 163);
            this.qrOutput.Name = "qrOutput";
            this.qrOutput.Size = new System.Drawing.Size(322, 308);
            this.qrOutput.TabIndex = 2;
            this.qrOutput.TabStop = false;
            // 
            // saveQR
            // 
            this.saveQR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveQR.Location = new System.Drawing.Point(39, 477);
            this.saveQR.Name = "saveQR";
            this.saveQR.Size = new System.Drawing.Size(322, 40);
            this.saveQR.TabIndex = 3;
            this.saveQR.Text = "SAVE QR";
            this.saveQR.UseVisualStyleBackColor = true;
            this.saveQR.Click += new System.EventHandler(this.saveQR_Click);
            // 
            // loadQR
            // 
            this.loadQR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadQR.Location = new System.Drawing.Point(39, 523);
            this.loadQR.Name = "loadQR";
            this.loadQR.Size = new System.Drawing.Size(322, 40);
            this.loadQR.TabIndex = 4;
            this.loadQR.Text = "LOAD QR";
            this.loadQR.UseVisualStyleBackColor = true;
            this.loadQR.Click += new System.EventHandler(this.loadQR_Click);
            // 
            // copyQR
            // 
            this.copyQR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyQR.Location = new System.Drawing.Point(39, 569);
            this.copyQR.Name = "copyQR";
            this.copyQR.Size = new System.Drawing.Size(322, 40);
            this.copyQR.TabIndex = 5;
            this.copyQR.Text = "COPY QR";
            this.copyQR.UseVisualStyleBackColor = true;
            this.copyQR.Click += new System.EventHandler(this.copyQR_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 630);
            this.Controls.Add(this.copyQR);
            this.Controls.Add(this.loadQR);
            this.Controls.Add(this.saveQR);
            this.Controls.Add(this.qrOutput);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.encodedText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# QR Example";
            ((System.ComponentModel.ISupportInitialize)(this.qrOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encodedText;
        private System.Windows.Forms.Label textInfo;
        private System.Windows.Forms.PictureBox qrOutput;
        private System.Windows.Forms.Button saveQR;
        private System.Windows.Forms.Button loadQR;
        private System.Windows.Forms.Button copyQR;
    }
}

