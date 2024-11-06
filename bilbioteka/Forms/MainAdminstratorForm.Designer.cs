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
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(344, 40);
            label2.TabIndex = 1;
            label2.Text = "Witaj Admnistratorze";
            // 
            // buttonEdycjaZbioru
            // 
            buttonEdycjaZbioru.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdycjaZbioru.Location = new Point(314, 198);
            buttonEdycjaZbioru.Name = "buttonEdycjaZbioru";
            buttonEdycjaZbioru.Size = new Size(221, 97);
            buttonEdycjaZbioru.TabIndex = 2;
            buttonEdycjaZbioru.Text = "Edytuj zbiór";
            buttonEdycjaZbioru.UseVisualStyleBackColor = true;
            buttonEdycjaZbioru.Click += buttonEdycjaZbioru_Click;
            // 
            // buttonGenerujRaport
            // 
            buttonGenerujRaport.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerujRaport.Location = new Point(566, 198);
            buttonGenerujRaport.Name = "buttonGenerujRaport";
            buttonGenerujRaport.Size = new Size(221, 97);
            buttonGenerujRaport.TabIndex = 4;
            buttonGenerujRaport.Text = "Generuj raport";
            buttonGenerujRaport.UseVisualStyleBackColor = true;
            // 
            // buttonUsunPracownika
            // 
            buttonUsunPracownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsunPracownika.Location = new Point(566, 317);
            buttonUsunPracownika.Name = "buttonUsunPracownika";
            buttonUsunPracownika.Size = new Size(221, 97);
            buttonUsunPracownika.TabIndex = 5;
            buttonUsunPracownika.Text = "Usuń pracownika";
            buttonUsunPracownika.UseVisualStyleBackColor = true;
            // 
            // buttonDodajPracownika
            // 
            buttonDodajPracownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajPracownika.Location = new Point(314, 317);
            buttonDodajPracownika.Name = "buttonDodajPracownika";
            buttonDodajPracownika.Size = new Size(221, 97);
            buttonDodajPracownika.TabIndex = 6;
            buttonDodajPracownika.Text = "Dodaj pracownika";
            buttonDodajPracownika.UseVisualStyleBackColor = true;
            buttonDodajPracownika.Click += buttonDodajPracownika_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1234, 23);
            button2.Name = "button2";
            button2.Size = new Size(136, 60);
            button2.TabIndex = 14;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonDodajProdukt
            // 
            buttonDodajProdukt.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajProdukt.Location = new Point(314, 434);
            buttonDodajProdukt.Name = "buttonDodajProdukt";
            buttonDodajProdukt.Size = new Size(221, 97);
            buttonDodajProdukt.TabIndex = 15;
            buttonDodajProdukt.Text = "Dodaj nowy produkt";
            buttonDodajProdukt.UseVisualStyleBackColor = true;
            buttonDodajProdukt.Click += buttonDodajProdukt_Click;
            // 
            // MainAdminstratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(1382, 803);
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
    }
}