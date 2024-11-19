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
            buttonEdytujKontoUzytkownika.Location = new Point(18, 621);
            buttonEdytujKontoUzytkownika.Margin = new Padding(4, 4, 4, 4);
            buttonEdytujKontoUzytkownika.Name = "buttonEdytujKontoUzytkownika";
            buttonEdytujKontoUzytkownika.Size = new Size(261, 114);
            buttonEdytujKontoUzytkownika.TabIndex = 11;
            buttonEdytujKontoUzytkownika.Text = "Usuń konto użytkownika ";
            buttonEdytujKontoUzytkownika.UseVisualStyleBackColor = true;
            buttonEdytujKontoUzytkownika.Click += buttonEdytujKontoUzytkownika_Click;
            // 
            // buttonPrzyjmijOplate
            // 
            buttonPrzyjmijOplate.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrzyjmijOplate.Location = new Point(18, 364);
            buttonPrzyjmijOplate.Margin = new Padding(4, 4, 4, 4);
            buttonPrzyjmijOplate.Name = "buttonPrzyjmijOplate";
            buttonPrzyjmijOplate.Size = new Size(261, 85);
            buttonPrzyjmijOplate.TabIndex = 10;
            buttonPrzyjmijOplate.Text = "Przyjmij opłatę";
            buttonPrzyjmijOplate.UseVisualStyleBackColor = true;
            // 
            // buttonWydłuzTermin
            // 
            buttonWydłuzTermin.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWydłuzTermin.Location = new Point(18, 240);
            buttonWydłuzTermin.Margin = new Padding(4, 4, 4, 4);
            buttonWydłuzTermin.Name = "buttonWydłuzTermin";
            buttonWydłuzTermin.Size = new Size(261, 96);
            buttonWydłuzTermin.TabIndex = 9;
            buttonWydłuzTermin.Text = "Wydłuż termin";
            buttonWydłuzTermin.UseVisualStyleBackColor = true;
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(18, 126);
            buttonWypozycz.Margin = new Padding(4, 4, 4, 4);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(261, 84);
            buttonWypozycz.TabIndex = 8;
            buttonWypozycz.Text = "Wypożycz";
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
            label2.Size = new Size(220, 47);
            label2.TabIndex = 7;
            label2.Text = "Pracownik:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 47);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // buttonEdytujSwojeKonto
            // 
            buttonEdytujSwojeKonto.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujSwojeKonto.Location = new Point(18, 479);
            buttonEdytujSwojeKonto.Margin = new Padding(4, 4, 4, 4);
            buttonEdytujSwojeKonto.Name = "buttonEdytujSwojeKonto";
            buttonEdytujSwojeKonto.Size = new Size(261, 106);
            buttonEdytujSwojeKonto.TabIndex = 12;
            buttonEdytujSwojeKonto.Text = "Edytuj swoje konto";
            buttonEdytujSwojeKonto.UseVisualStyleBackColor = true;
            buttonEdytujSwojeKonto.Click += buttonEdytujSwojeKonto_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1536, 25);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(162, 55);
            button2.TabIndex = 13;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(322, 240);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1376, 704);
            dataGridView1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(322, 139);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(538, 60);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox1.Location = new Point(871, 151);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(382, 46);
            comboBox1.TabIndex = 15;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1262, 139);
            buttonSzukaj.Margin = new Padding(4, 4, 4, 4);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(150, 71);
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
            ClientSize = new Size(1731, 1005);
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
            Margin = new Padding(4, 4, 4, 4);
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