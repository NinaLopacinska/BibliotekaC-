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
            buttonWypozycz = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonEdytujSwojeKonto = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            buttonSzukaj = new Button();
            btnStatystyki = new Button();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonEdytujKontoUzytkownika
            // 
            buttonEdytujKontoUzytkownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujKontoUzytkownika.Location = new Point(20, 400);
            buttonEdytujKontoUzytkownika.Name = "buttonEdytujKontoUzytkownika";
            buttonEdytujKontoUzytkownika.Size = new Size(209, 83);
            buttonEdytujKontoUzytkownika.TabIndex = 11;
            buttonEdytujKontoUzytkownika.Text = "Użytkownicy";
            buttonEdytujKontoUzytkownika.UseVisualStyleBackColor = true;
            buttonEdytujKontoUzytkownika.Click += buttonEdytujKontoUzytkownika_Click;
            // 
            // buttonPrzyjmijOplate
            // 
            buttonPrzyjmijOplate.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrzyjmijOplate.Location = new Point(20, 292);
            buttonPrzyjmijOplate.Name = "buttonPrzyjmijOplate";
            buttonPrzyjmijOplate.Size = new Size(209, 83);
            buttonPrzyjmijOplate.TabIndex = 10;
            buttonPrzyjmijOplate.Text = "Przyjmij opłatę";
            buttonPrzyjmijOplate.UseVisualStyleBackColor = true;
            buttonPrzyjmijOplate.Click += buttonPrzyjmijOplate_Click;
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(20, 87);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(209, 83);
            buttonWypozycz.TabIndex = 8;
            buttonWypozycz.Text = "Wypożycz";
            buttonWypozycz.UseVisualStyleBackColor = true;
            buttonWypozycz.Click += buttonWypozycz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 20);
            label2.Name = "label2";
            label2.Size = new Size(188, 40);
            label2.TabIndex = 7;
            label2.Text = "Pracownik:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(191, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // buttonEdytujSwojeKonto
            // 
            buttonEdytujSwojeKonto.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujSwojeKonto.Location = new Point(20, 707);
            buttonEdytujSwojeKonto.Name = "buttonEdytujSwojeKonto";
            buttonEdytujSwojeKonto.Size = new Size(209, 83);
            buttonEdytujSwojeKonto.TabIndex = 12;
            buttonEdytujSwojeKonto.Text = "Edytuj swoje konto";
            buttonEdytujSwojeKonto.UseVisualStyleBackColor = true;
            buttonEdytujSwojeKonto.Click += buttonEdytujSwojeKonto_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1420, 20);
            button2.Name = "button2";
            button2.Size = new Size(130, 44);
            button2.TabIndex = 13;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(275, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1251, 621);
            dataGridView1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(275, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(431, 51);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox1.Location = new Point(714, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 40);
            comboBox1.TabIndex = 15;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1027, 87);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(120, 57);
            buttonSzukaj.TabIndex = 14;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // btnStatystyki
            // 
            btnStatystyki.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnStatystyki.Location = new Point(20, 607);
            btnStatystyki.Name = "btnStatystyki";
            btnStatystyki.Size = new Size(209, 83);
            btnStatystyki.TabIndex = 18;
            btnStatystyki.Text = "Statystyki";
            btnStatystyki.UseVisualStyleBackColor = true;
            btnStatystyki.Click += btnStatystyki_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(20, 504);
            button1.Name = "button1";
            button1.Size = new Size(209, 83);
            button1.TabIndex = 19;
            button1.Text = "Zmiana hasła";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(20, 189);
            button3.Name = "button3";
            button3.Size = new Size(209, 83);
            button3.TabIndex = 20;
            button3.Text = "Zwróć";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MainPracownikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1562, 830);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(btnStatystyki);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj);
            Controls.Add(button2);
            Controls.Add(buttonEdytujSwojeKonto);
            Controls.Add(buttonEdytujKontoUzytkownika);
            Controls.Add(buttonPrzyjmijOplate);
            Controls.Add(buttonWypozycz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainPracownikForm";
            Text = "Menu Pracownik";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdytujKontoUzytkownika;
        private Button buttonPrzyjmijOplate;
        private Button buttonWypozycz;
        private Label label2;
        private Label label1;
        private Button buttonEdytujSwojeKonto;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button buttonSzukaj;
        private Button btnStatystyki;
        private Button button1;
        private Button button3;
    }
}