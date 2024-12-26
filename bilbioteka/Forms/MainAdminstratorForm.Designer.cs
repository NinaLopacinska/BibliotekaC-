namespace bilbioteka.Forms
{
    partial class MainAdminstratorForm
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
            label1 = new Label();
            label2 = new Label();
            buttonEdycjaZbioru = new Button();
            buttonGenerujRaport = new Button();
            buttonUsunPracownika = new Button();
            buttonDodajPracownika = new Button();
            button2 = new Button();
            buttonDodajProdukt = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 17);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 17);
            label2.Name = "label2";
            label2.Size = new Size(133, 40);
            label2.TabIndex = 1;
            label2.Text = "Admin:";
            // 
            // buttonEdycjaZbioru
            // 
            buttonEdycjaZbioru.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdycjaZbioru.Location = new Point(50, 83);
            buttonEdycjaZbioru.Name = "buttonEdycjaZbioru";
            buttonEdycjaZbioru.Size = new Size(221, 71);
            buttonEdycjaZbioru.TabIndex = 2;
            buttonEdycjaZbioru.Text = "Edytuj zbiór";
            buttonEdycjaZbioru.UseVisualStyleBackColor = true;
            buttonEdycjaZbioru.Click += buttonEdycjaZbioru_Click;
            // 
            // buttonGenerujRaport
            // 
            buttonGenerujRaport.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerujRaport.Location = new Point(340, 83);
            buttonGenerujRaport.Name = "buttonGenerujRaport";
            buttonGenerujRaport.Size = new Size(221, 71);
            buttonGenerujRaport.TabIndex = 4;
            buttonGenerujRaport.Text = "Generuj raport";
            buttonGenerujRaport.UseVisualStyleBackColor = true;
            buttonGenerujRaport.Click += buttonGenerujRaport_Click;
            // 
            // buttonUsunPracownika
            // 
            buttonUsunPracownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsunPracownika.Location = new Point(340, 198);
            buttonUsunPracownika.Name = "buttonUsunPracownika";
            buttonUsunPracownika.Size = new Size(221, 92);
            buttonUsunPracownika.TabIndex = 5;
            buttonUsunPracownika.Text = "Usuń pracownika";
            buttonUsunPracownika.UseVisualStyleBackColor = true;
            buttonUsunPracownika.Click += buttonUsunPracownika_Click;
            // 
            // buttonDodajPracownika
            // 
            buttonDodajPracownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajPracownika.Location = new Point(52, 198);
            buttonDodajPracownika.Name = "buttonDodajPracownika";
            buttonDodajPracownika.Size = new Size(221, 92);
            buttonDodajPracownika.TabIndex = 6;
            buttonDodajPracownika.Text = "Dodaj pracownika";
            buttonDodajPracownika.UseVisualStyleBackColor = true;
            buttonDodajPracownika.Click += buttonDodajPracownika_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(425, 20);
            button2.Name = "button2";
            button2.Size = new Size(136, 43);
            button2.TabIndex = 14;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonDodajProdukt
            // 
            buttonDodajProdukt.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajProdukt.Location = new Point(50, 327);
            buttonDodajProdukt.Name = "buttonDodajProdukt";
            buttonDodajProdukt.Size = new Size(221, 97);
            buttonDodajProdukt.TabIndex = 15;
            buttonDodajProdukt.Text = "Dodaj nowy produkt";
            buttonDodajProdukt.UseVisualStyleBackColor = true;
            buttonDodajProdukt.Click += buttonDodajProdukt_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(340, 332);
            button1.Name = "button1";
            button1.Size = new Size(221, 92);
            button1.TabIndex = 16;
            button1.Text = "Edytuj cennik";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainAdminstratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(715, 571);
            Controls.Add(button1);
            Controls.Add(buttonDodajProdukt);
            Controls.Add(button2);
            Controls.Add(buttonDodajPracownika);
            Controls.Add(buttonUsunPracownika);
            Controls.Add(buttonGenerujRaport);
            Controls.Add(buttonEdycjaZbioru);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainAdminstratorForm";
            Text = "MainAdminstratorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonEdycjaZbioru;
        private Button buttonGenerujRaport;
        private Button buttonUsunPracownika;
        private Button buttonDodajPracownika;
        private Button button2;
        private Button buttonDodajProdukt;
        private Button button1;
    }
}