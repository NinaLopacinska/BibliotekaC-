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
            buttonEdytujKontoUzytkownika.Location = new Point(80, 256);
            buttonEdytujKontoUzytkownika.Name = "buttonEdytujKontoUzytkownika";
            buttonEdytujKontoUzytkownika.Size = new Size(221, 97);
            buttonEdytujKontoUzytkownika.TabIndex = 11;
            buttonEdytujKontoUzytkownika.Text = "Edytuj konto użytkownika ";
            buttonEdytujKontoUzytkownika.UseVisualStyleBackColor = true;
            // 
            // buttonPrzyjmijOplate
            // 
            buttonPrzyjmijOplate.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrzyjmijOplate.Location = new Point(80, 385);
            buttonPrzyjmijOplate.Name = "buttonPrzyjmijOplate";
            buttonPrzyjmijOplate.Size = new Size(221, 97);
            buttonPrzyjmijOplate.TabIndex = 10;
            buttonPrzyjmijOplate.Text = "Przyjmij opłatę";
            buttonPrzyjmijOplate.UseVisualStyleBackColor = true;
            // 
            // buttonWydłuzTermin
            // 
            buttonWydłuzTermin.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWydłuzTermin.Location = new Point(80, 634);
            buttonWydłuzTermin.Name = "buttonWydłuzTermin";
            buttonWydłuzTermin.Size = new Size(221, 97);
            buttonWydłuzTermin.TabIndex = 9;
            buttonWydłuzTermin.Text = "Wydłuż termin";
            buttonWydłuzTermin.UseVisualStyleBackColor = true;
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(80, 131);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(221, 97);
            buttonWypozycz.TabIndex = 8;
            buttonWypozycz.Text = "Wypożycz";
            buttonWypozycz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(289, 40);
            label2.TabIndex = 7;
            label2.Text = "Witaj Pracowniku";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(295, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // buttonEdytujSwojeKonto
            // 
            buttonEdytujSwojeKonto.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujSwojeKonto.Location = new Point(80, 513);
            buttonEdytujSwojeKonto.Name = "buttonEdytujSwojeKonto";
            buttonEdytujSwojeKonto.Size = new Size(221, 97);
            buttonEdytujSwojeKonto.TabIndex = 12;
            buttonEdytujSwojeKonto.Text = "Edytuj swoje konto";
            buttonEdytujSwojeKonto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1240, 20);
            button2.Name = "button2";
            button2.Size = new Size(130, 59);
            button2.TabIndex = 13;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(393, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(819, 475);
            dataGridView1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(393, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 51);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria" });
            comboBox1.Location = new Point(823, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 40);
            comboBox1.TabIndex = 15;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1092, 179);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(120, 57);
            buttonSzukaj.TabIndex = 14;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // MainPracownikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(1382, 803);
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