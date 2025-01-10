namespace bilbioteka.Forms
{
    partial class WypozyczeniePracownikForm
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
            label2 = new Label();
            label3 = new Label();
            buttonWypozycz = new Button();
            textBoxLogin = new TextBox();
            textBoxTytul = new TextBox();
            dataGridView1 = new DataGridView();
            buttonZalogujRej = new Button();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            buttonSzukaj = new Button();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxTyp = new TextBox();
            textBoxSzukanaWartosc = new TextBox();
            comboBox1 = new ComboBox();
            buttonSzukaj2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 125);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 8;
            label2.Text = "Login ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 211);
            label3.Name = "label3";
            label3.Size = new Size(68, 28);
            label3.TabIndex = 10;
            label3.Text = "Tytuł";
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(49, 388);
            buttonWypozycz.Margin = new Padding(3, 2, 3, 2);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(167, 46);
            buttonWypozycz.TabIndex = 11;
            buttonWypozycz.Text = "Wypożycz";
            buttonWypozycz.UseVisualStyleBackColor = true;
            buttonWypozycz.Click += buttonWypozycz_Click_1;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(49, 163);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(251, 32);
            textBoxLogin.TabIndex = 17;
            // 
            // textBoxTytul
            // 
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(49, 247);
            textBoxTytul.Margin = new Padding(3, 2, 3, 2);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(251, 32);
            textBoxTytul.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(358, 401);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(615, 236);
            dataGridView1.TabIndex = 19;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(10, 10);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(80, 50);
            buttonZalogujRej.TabIndex = 165;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(358, 77);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(927, 238);
            dataGridView2.TabIndex = 172;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(358, 41);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(420, 36);
            textBox1.TabIndex = 171;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox2.Location = new Point(783, 47);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(231, 30);
            comboBox2.TabIndex = 170;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1018, 35);
            buttonSzukaj.Margin = new Padding(3, 2, 3, 2);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(100, 39);
            buttonSzukaj.TabIndex = 169;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(358, 6);
            label6.Name = "label6";
            label6.Size = new Size(733, 28);
            label6.TabIndex = 179;
            label6.Text = "Wybierz lub wyszukaj pozycje, którą użytkownik chce wypożyczyć:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(358, 326);
            label4.Name = "label4";
            label4.Size = new Size(600, 28);
            label4.TabIndex = 180;
            label4.Text = "Wybierz użytkownika, który chce wypożyczyć pozycję:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 302);
            label5.Name = "label5";
            label5.Size = new Size(227, 28);
            label5.TabIndex = 181;
            label5.Text = "Wybierz typ pozycji:";
            // 
            // textBoxTyp
            // 
            textBoxTyp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTyp.Location = new Point(49, 338);
            textBoxTyp.Margin = new Padding(3, 2, 3, 2);
            textBoxTyp.Name = "textBoxTyp";
            textBoxTyp.Size = new Size(251, 32);
            textBoxTyp.TabIndex = 182;
            // 
            // textBoxSzukanaWartosc
            // 
            textBoxSzukanaWartosc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxSzukanaWartosc.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSzukanaWartosc.Location = new Point(359, 365);
            textBoxSzukanaWartosc.Margin = new Padding(3, 2, 3, 2);
            textBoxSzukanaWartosc.Name = "textBoxSzukanaWartosc";
            textBoxSzukanaWartosc.Size = new Size(388, 36);
            textBoxSzukanaWartosc.TabIndex = 186;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Imie", "Nazwisko", "Login", "Numer telefonu", "Email", "Pesel" });
            comboBox1.Location = new Point(752, 366);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 30);
            comboBox1.TabIndex = 185;
            // 
            // buttonSzukaj2
            // 
            buttonSzukaj2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSzukaj2.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj2.Location = new Point(944, 359);
            buttonSzukaj2.Margin = new Padding(3, 2, 3, 2);
            buttonSzukaj2.Name = "buttonSzukaj2";
            buttonSzukaj2.Size = new Size(111, 38);
            buttonSzukaj2.TabIndex = 184;
            buttonSzukaj2.Text = "Szukaj";
            buttonSzukaj2.UseVisualStyleBackColor = true;
            buttonSzukaj2.Click += buttonSzukaj2_Click_1;
            // 
            // WypozyczeniePracownikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1323, 646);
            Controls.Add(textBoxSzukanaWartosc);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj2);
            Controls.Add(textBoxTyp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(buttonSzukaj);
            Controls.Add(buttonZalogujRej);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxTytul);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonWypozycz);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "WypozyczeniePracownikForm";
            Text = "Wypożyczenia";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button buttonWypozycz;
        private TextBox textBoxLogin;
        private TextBox textBoxTytul;
        private DataGridView dataGridView1;
        private Button buttonZalogujRej;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button buttonSzukaj;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox textBoxTyp;
        private TextBox textBoxSzukanaWartosc;
        private ComboBox comboBox1;
        private Button buttonSzukaj2;
    }
}