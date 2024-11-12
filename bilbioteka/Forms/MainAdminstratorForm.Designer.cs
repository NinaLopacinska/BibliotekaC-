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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 47);
            label1.Name = "label1";
            label1.Size = new Size(86, 32);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 17);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 1;
            label2.Text = "Witaj Admnistratorze";
            // 
            // buttonEdycjaZbioru
            // 
            buttonEdycjaZbioru.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdycjaZbioru.Location = new Point(275, 148);
            buttonEdycjaZbioru.Margin = new Padding(3, 2, 3, 2);
            buttonEdycjaZbioru.Name = "buttonEdycjaZbioru";
            buttonEdycjaZbioru.Size = new Size(193, 73);
            buttonEdycjaZbioru.TabIndex = 2;
            buttonEdycjaZbioru.Text = "Edytuj zbiór";
            buttonEdycjaZbioru.UseVisualStyleBackColor = true;
            buttonEdycjaZbioru.Click += buttonEdycjaZbioru_Click;
            // 
            // buttonGenerujRaport
            // 
            buttonGenerujRaport.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerujRaport.Location = new Point(495, 148);
            buttonGenerujRaport.Margin = new Padding(3, 2, 3, 2);
            buttonGenerujRaport.Name = "buttonGenerujRaport";
            buttonGenerujRaport.Size = new Size(193, 73);
            buttonGenerujRaport.TabIndex = 4;
            buttonGenerujRaport.Text = "Generuj raport";
            buttonGenerujRaport.UseVisualStyleBackColor = true;
            // 
            // buttonUsunPracownika
            // 
            buttonUsunPracownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsunPracownika.Location = new Point(495, 238);
            buttonUsunPracownika.Margin = new Padding(3, 2, 3, 2);
            buttonUsunPracownika.Name = "buttonUsunPracownika";
            buttonUsunPracownika.Size = new Size(193, 73);
            buttonUsunPracownika.TabIndex = 5;
            buttonUsunPracownika.Text = "Usuń pracownika";
            buttonUsunPracownika.UseVisualStyleBackColor = true;
            // 
            // buttonDodajPracownika
            // 
            buttonDodajPracownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajPracownika.Location = new Point(275, 238);
            buttonDodajPracownika.Margin = new Padding(3, 2, 3, 2);
            buttonDodajPracownika.Name = "buttonDodajPracownika";
            buttonDodajPracownika.Size = new Size(193, 73);
            buttonDodajPracownika.TabIndex = 6;
            buttonDodajPracownika.Text = "Dodaj pracownika";
            buttonDodajPracownika.UseVisualStyleBackColor = true;
            buttonDodajPracownika.Click += buttonDodajPracownika_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1080, 17);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(119, 45);
            button2.TabIndex = 14;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonDodajProdukt
            // 
            buttonDodajProdukt.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajProdukt.Location = new Point(275, 326);
            buttonDodajProdukt.Margin = new Padding(3, 2, 3, 2);
            buttonDodajProdukt.Name = "buttonDodajProdukt";
            buttonDodajProdukt.Size = new Size(193, 73);
            buttonDodajProdukt.TabIndex = 15;
            buttonDodajProdukt.Text = "Dodaj nowy produkt";
            buttonDodajProdukt.UseVisualStyleBackColor = true;
            buttonDodajProdukt.Click += buttonDodajProdukt_Click;
            // 
            // MainAdminstratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 602);
            Controls.Add(buttonDodajProdukt);
            Controls.Add(button2);
            Controls.Add(buttonDodajPracownika);
            Controls.Add(buttonUsunPracownika);
            Controls.Add(buttonGenerujRaport);
            Controls.Add(buttonEdycjaZbioru);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}