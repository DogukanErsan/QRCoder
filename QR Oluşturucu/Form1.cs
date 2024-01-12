using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace QR_Oluşturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string data = textBoxData.Text;

            if (!string.IsNullOrEmpty(data))
            {
                GenerateQRCode(data);
            }
            else
            {
                MessageBox.Show("Lütfen bir metin girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateQRCode(string data)
        {
            // QRCodeGenerator sınıfını kullanarak QR kodu oluşturun
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);

            // QR kodunu bir bitmap olarak elde edin
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // PictureBox'a QR kodu göster
            pictureBoxQRCode.Image = qrCodeImage;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // PictureBox'tan resmi al
            Bitmap bmp = pictureBoxQRCode.Image as Bitmap;

            // Eğer resim varsa, SaveFileDialog'u göster
            if (bmp != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG dosyaları (*.png)|*.png|Tüm dosyalar (*.*)|*.*";
                saveFileDialog.Title = "QR Kodunu Kaydet";
                saveFileDialog.FileName = "QRCode - Ersan Software.png"; // Varsayılan dosya adı

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Seçilen dosya yoluna resmi kaydet
                    bmp.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);

                    MessageBox.Show("QR kodu başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("QR kodu oluşturulmadı. Önce bir QR kodu oluşturun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Belirtilen web sitesini varsayılan tarayıcıda aç
                Process.Start(new ProcessStartInfo
                {
                    FileName = linkLabel1.Text,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
