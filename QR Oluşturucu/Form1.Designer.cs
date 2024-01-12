namespace QR_Oluşturucu
{
    partial class Form1
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
            textBoxData = new TextBox();
            buttonGenerate = new Button();
            pictureBoxQRCode = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(447, 32);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(341, 23);
            textBoxData.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(543, 79);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(142, 64);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "QR Kod'u Oluştur!";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Dock = DockStyle.Left;
            pictureBoxQRCode.Location = new Point(0, 0);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(441, 450);
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxQRCode.TabIndex = 2;
            pictureBoxQRCode.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Franklin Gothic Medium", 10.75F, FontStyle.Bold);
            label1.Location = new Point(441, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 20);
            label1.TabIndex = 3;
            label1.Text = "Lütfen QR Oluşturulacak İçeriği Giriniz..";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(632, 435);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(169, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://linktr.ee/dogukanersan";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(543, 161);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(142, 52);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "QR Kod'u Kaydet!";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxData);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Form1";
            Text = "QR Oluşturucu v0.02 - Ersan Software";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxData;
        private Button buttonGenerate;
        private PictureBox pictureBoxQRCode;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button buttonSave;
    }
}
