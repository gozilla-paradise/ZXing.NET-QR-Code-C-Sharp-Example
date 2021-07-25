using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZXing.NET_QR_Code_C_Sharp_Example
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void encodedText_TextChanged(object sender, EventArgs e)
        {
            if (encodedText.Text.Length == 0)
            {
                qrOutput.Image = null;
                return;
            }
            var writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE, Options = {
                    Width = qrOutput.Width,
                    Height = qrOutput.Height
                }
            };
            writer.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "utf-8");

            var barcode = writer.Write(encodedText.Text);
            qrOutput.Image = barcode;
        }

        private void saveQR_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "QR Code Output | *.jpg";
                if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length !=0)
                {
                    qrOutput.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                
            }
        }

        private void loadQR_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "QR Code Input | *.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length != 0)
                {
                    var reader = new BarcodeReader();
                    var bitmap = new Bitmap(ofd.FileName);
                    var result = reader.Decode(bitmap);
                    encodedText.Text = result.Text;
                }
            }
        }

        private void copyQR_Click(object sender, EventArgs e)
        {
            if (qrOutput.Image != null)
            {
                Clipboard.SetImage(qrOutput.Image);
            }
        }
    }
}
