namespace bilbioteka.Forms
{
    partial class MainPracownikForm
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
            buttonEdytujKontoUzytkownika = new Button();
            buttonPrzyjmijOplate = new Button();
            buttonWydłuzTermin = new Button();
            buttonWypozycz = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonEdytujSwojeKonto = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            buttonSzukaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonEdytujKontoUzytkownika
            // 
            buttonEdytujKontoUzytkownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujKontoUzytkownika.Location = new Point(100, 320);
            buttonEdytujKontoUzytkownika.Margin = new Padding(4, 3, 4, 3);
            buttonEdytujKontoUzytkownika.Name = "buttonEdytujKontoUzytkownika";
            buttonEdytujKontoUzytkownika.Size = new Size(276, 122);
            buttonEdytujKontoUzytkownika.TabIndex = 11;
            buttonEdytujKontoUzytkownika.Text = "Usuń konto użytkownika ";
            buttonEdytujKontoUzytkownika.UseVisualStyleBackColor = true;
            buttonEdytujKontoUzytkownika.Click += buttonEdytujKontoUzytkownika_Click;
            // 
            // buttonPrzyjmijOplate
            // 
            buttonPrzyjmijOplate.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrzyjmijOplate.Location = new Point(100, 482);
            buttonPrzyjmijOplate.Margin = new Padding(4, 3, 4, 3);
            buttonPrzyjmijOplate.Name = "buttonPrzyjmijOplate";
            buttonPrzyjmijOplate.Size = new Size(276, 122);
            buttonPrzyjmijOplate.TabIndex = 10;
            buttonPrzyjmijOplate.Text = "Przyjmij opłatę";
            buttonPrzyjmijOplate.UseVisualStyleBackColor = true;
            // 
            // buttonWydłuzTermin
            // 
            buttonWydłuzTermin.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWydłuzTermin.Location = new Point(100, 793);
            buttonWydłuzTermin.Margin = new Padding(4, 3, 4, 3);
            buttonWydłuzTermin.Name = "buttonWydłuzTermin";
            buttonWydłuzTermin.Size = new Size(276, 122);
            buttonWydłuzTermin.TabIndex = 9;
            buttonWydłuzTermin.Text = "Wydłuż termin";
            buttonWydłuzTermin.UseVisualStyleBackColor = true;
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(100, 163);
            buttonWypozycz.Margin = new Padding(4, 3, 4, 3);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(276, 122);
            buttonWypozycz.TabIndex = 8;
            buttonWypozycz.Text = "Wypożyczenia";
            buttonWypozycz.UseVisualStyleBackColor = true;
            buttonWypozycz.Click += buttonWypozycz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 25);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(338, 47);
            label2.TabIndex = 7;
            label2.Text = "Witaj Pracowniku";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(369, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 47);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // buttonEdytujSwojeKonto
            // 
            buttonEdytujSwojeKonto.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujSwojeKonto.Location = new Point(100, 642);
            buttonEdytujSwojeKonto.Margin = new Padding(4, 3, 4, 3);
            buttonEdytujSwojeKonto.Name = "buttonEdytujSwojeKonto";
            buttonEdytujSwojeKonto.Size = new Size(276, 122);
            buttonEdytujSwojeKonto.TabIndex = 12;
            buttonEdytujSwojeKonto.Text = "Edytuj swoje konto";
            buttonEdytujSwojeKonto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1550, 25);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(163, 73);
            button2.TabIndex = 13;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(491, 327);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1024, 593);
            dataGridView1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(491, 222);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(530, 60);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox1.Location = new Point(1029, 235);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(328, 46);
            comboBox1.TabIndex = 15;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1366, 223);
            buttonSzukaj.Margin = new Padding(4, 3, 4, 3);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(150, 72);
            buttonSzukaj.TabIndex = 14;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // MainPracownikForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1727, 1003);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj);
            Controls.Add(button2);
            Controls.Add(buttonEdytujSwojeKonto);
            Controls.Add(buttonEdytujKontoUzytkownika);
            Controls.Add(buttonPrzyjmijOplate);
            Controls.Add(buttonWydłuzTermin);
            Controls.Add(buttonWypozycz);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainPracownikForm";
            Text = "MainPracownikForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdytujKontoUzytkownika;
        private Button buttonPrzyjmijOplate;
        private Button buttonWydłuzTermin;
        private Button buttonWypozycz;
        private Label label2;
        private Label label1;
        private Button buttonEdytujSwojeKonto;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button buttonSzukaj;
    }
}