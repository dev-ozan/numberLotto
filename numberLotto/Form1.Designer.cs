namespace numberLotto
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
            listSayilar = new ListBox();
            btnSayilarOlustur = new Button();
            SuspendLayout();
            // 
            // listSayilar
            // 
            listSayilar.FormattingEnabled = true;
            listSayilar.ItemHeight = 21;
            listSayilar.Location = new Point(66, 55);
            listSayilar.Name = "listSayilar";
            listSayilar.Size = new Size(192, 256);
            listSayilar.TabIndex = 0;
            // 
            // btnSayilarOlustur
            // 
            btnSayilarOlustur.Location = new Point(66, 333);
            btnSayilarOlustur.Name = "btnSayilarOlustur";
            btnSayilarOlustur.Size = new Size(192, 52);
            btnSayilarOlustur.TabIndex = 1;
            btnSayilarOlustur.Text = "Sayiları Oluştur";
            btnSayilarOlustur.UseVisualStyleBackColor = true;
            btnSayilarOlustur.Click += btnSayilarOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 484);
            Controls.Add(btnSayilarOlustur);
            Controls.Add(listSayilar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listSayilar;
        private Button btnSayilarOlustur;
    }
}