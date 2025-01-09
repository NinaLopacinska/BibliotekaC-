namespace bilbioteka.Forms
{
    partial class DodajNwoyProduktAdminForm
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
            buttonDodajProdukt = new Button();
            textBoxAutor = new TextBox();
            textBoxRokWydania = new TextBox();
            textBoxNrKatagolowy = new TextBox();
            textBoxOcena = new TextBox();
            textBoxIlosc = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            textBoxTytul = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonZalogujRej = new Button();
            comboBox2 = new ComboBox();
            textBoxWydawnictwo = new TextBox();
            label4 = new Label();
            textBoxTyp = new TextBox();
            SuspendLayout();
            // 
            // buttonDodajProdukt
            // 
            buttonDodajProdukt.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodajProdukt.Location = new Point(430, 427);
            buttonDodajProdukt.Margin = new Padding(3, 2, 3, 2);
            buttonDodajProdukt.Name = "buttonDodajProdukt";
            buttonDodajProdukt.Size = new Size(148, 46);
            buttonDodajProdukt.TabIndex = 143;
            buttonDodajProdukt.Text = "Dodaj";
            buttonDodajProdukt.UseVisualStyleBackColor = true;
            buttonDodajProdukt.Click += buttonDodajProdukt_Click_1;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutor.Location = new Point(189, 177);
            textBoxAutor.Margin = new Padding(3, 2, 3, 2);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(284, 32);
            textBoxAutor.TabIndex = 139;
            // 
            // textBoxRokWydania
            // 
            textBoxRokWydania.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRokWydania.Location = new Point(268, 228);
            textBoxRokWydania.Margin = new Padding(3, 2, 3, 2);
            textBoxRokWydania.Name = "textBoxRokWydania";
            textBoxRokWydania.Size = new Size(205, 32);
            textBoxRokWydania.TabIndex = 138;
            // 
            // textBoxNrKatagolowy
            // 
            textBoxNrKatagolowy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrKatagolowy.Location = new Point(298, 278);
            textBoxNrKatagolowy.Margin = new Padding(3, 2, 3, 2);
            textBoxNrKatagolowy.Name = "textBoxNrKatagolowy";
            textBoxNrKatagolowy.Size = new Size(168, 32);
            textBoxNrKatagolowy.TabIndex = 137;
            // 
            // textBoxOcena
            // 
            textBoxOcena.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOcena.Location = new Point(613, 278);
            textBoxOcena.Margin = new Padding(3, 2, 3, 2);
            textBoxOcena.Name = "textBoxOcena";
            textBoxOcena.Size = new Size(266, 32);
            textBoxOcena.TabIndex = 135;
            // 
            // textBoxIlosc
            // 
            textBoxIlosc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIlosc.Location = new Point(595, 130);
            textBoxIlosc.Margin = new Padding(3, 2, 3, 2);
            textBoxIlosc.Name = "textBoxIlosc";
            textBoxIlosc.Size = new Size(284, 32);
            textBoxIlosc.TabIndex = 134;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(99, 179);
            label18.Name = "label18";
            label18.Size = new Size(76, 27);
            label18.TabIndex = 131;
            label18.Text = "Autor:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(99, 228);
            label17.Name = "label17";
            label17.Size = new Size(147, 27);
            label17.TabIndex = 130;
            label17.Text = "Rok wydania:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(99, 278);
            label16.Name = "label16";
            label16.Size = new Size(170, 27);
            label16.TabIndex = 129;
            label16.Text = "Nr. katalogowy:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(522, 231);
            label15.Name = "label15";
            label15.Size = new Size(56, 27);
            label15.TabIndex = 128;
            label15.Text = "Typ:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(522, 278);
            label14.Name = "label14";
            label14.Size = new Size(80, 27);
            label14.TabIndex = 127;
            label14.Text = "Ocena:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(522, 130);
            label13.Name = "label13";
            label13.Size = new Size(62, 27);
            label13.TabIndex = 126;
            label13.Text = "Ilość:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(522, 182);
            label12.Name = "label12";
            label12.Size = new Size(113, 27);
            label12.TabIndex = 125;
            label12.Text = "Kategoria:";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(184, 128);
            textBoxTytul.Margin = new Padding(3, 2, 3, 2);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(289, 32);
            textBoxTytul.TabIndex = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 130);
            label3.Name = "label3";
            label3.Size = new Size(69, 27);
            label3.TabIndex = 119;
            label3.Text = "Tytuł:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, -112);
            label2.Name = "label2";
            label2.Size = new Size(218, 46);
            label2.TabIndex = 117;
            label2.Text = "Jeśli posiadasz już konto\r\n zaloguj się";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(268, 16);
            label1.Name = "label1";
            label1.Size = new Size(375, 45);
            label1.TabIndex = 116;
            label1.Text = "Dodaj nowy produkt";
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(14, 8);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(77, 52);
            buttonZalogujRej.TabIndex = 114;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Fikcja ", "Fantastyka", "Kryminał", "Romans", "Dramat ", "Horror ", "Komedia ", "Dziecięca ", "Dokumentalny", "Edukacja ", "Lektury szkolne" });
            comboBox2.Location = new Point(651, 182);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 30);
            comboBox2.TabIndex = 146;
            // 
            // textBoxWydawnictwo
            // 
            textBoxWydawnictwo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWydawnictwo.Location = new Point(704, 320);
            textBoxWydawnictwo.Margin = new Padding(3, 2, 3, 2);
            textBoxWydawnictwo.Name = "textBoxWydawnictwo";
            textBoxWydawnictwo.Size = new Size(175, 32);
            textBoxWydawnictwo.TabIndex = 148;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(522, 322);
            label4.Name = "label4";
            label4.Size = new Size(160, 27);
            label4.TabIndex = 147;
            label4.Text = "Wydawnictwo:";
            // 
            // textBoxTyp
            // 
            textBoxTyp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTyp.Location = new Point(590, 231);
            textBoxTyp.Margin = new Padding(3, 2, 3, 2);
            textBoxTyp.Name = "textBoxTyp";
            textBoxTyp.Size = new Size(289, 32);
            textBoxTyp.TabIndex = 149;
            // 
            // DodajNwoyProduktAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1048, 538);
            Controls.Add(textBoxTyp);
            Controls.Add(textBoxWydawnictwo);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(buttonDodajProdukt);
            Controls.Add(textBoxAutor);
            Controls.Add(textBoxRokWydania);
            Controls.Add(textBoxNrKatagolowy);
            Controls.Add(textBoxOcena);
            Controls.Add(textBoxIlosc);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBoxTytul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonZalogujRej);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DodajNwoyProduktAdminForm";
            Text = "Dodaj nowy produkt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDodajProdukt;
        private TextBox textBoxAutor;
        private TextBox textBoxRokWydania;
        private TextBox textBoxNrKatagolowy;
        private TextBox textBoxOcena;
        private TextBox textBoxIlosc;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox textBoxTytul;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonZalogujRej;
        private ComboBox comboBox2;
        private TextBox textBoxWydawnictwo;
        private Label label4;
        private TextBox textBoxTyp;
    }
}