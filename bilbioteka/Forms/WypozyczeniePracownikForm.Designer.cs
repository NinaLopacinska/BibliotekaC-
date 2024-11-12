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
            comboBox1 = new ComboBox();
            label1 = new Label();
            buttonOdswiez = new Button();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            buttonSzukaj = new Button();
            buttonZwroc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(96, 277);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(366, 47);
            label2.TabIndex = 8;
            label2.Text = "Login użytkownika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(96, 475);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 47);
            label3.TabIndex = 10;
            label3.Text = "Tytuł";
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(214, 833);
            buttonWypozycz.Margin = new Padding(4, 3, 4, 3);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(239, 103);
            buttonWypozycz.TabIndex = 11;
            buttonWypozycz.Text = "Wypożycz";
            buttonWypozycz.UseVisualStyleBackColor = true;
            buttonWypozycz.Click += buttonWypozycz_Click_1;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(96, 353);
            textBoxLogin.Margin = new Padding(4, 3, 4, 3);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(530, 60);
            textBoxLogin.TabIndex = 17;
            // 
            // textBoxTytul
            // 
            textBoxTytul.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(96, 545);
            textBoxTytul.Margin = new Padding(4, 3, 4, 3);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(530, 60);
            textBoxTytul.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(690, 545);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(951, 237);
            dataGridView1.TabIndex = 19;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(14, 15);
            buttonZalogujRej.Margin = new Padding(4, 3, 4, 3);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(110, 87);
            buttonZalogujRej.TabIndex = 165;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Film", "Książka", "Album" });
            comboBox1.Location = new Point(96, 733);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(530, 46);
            comboBox1.TabIndex = 166;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 665);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 47);
            label1.TabIndex = 167;
            label1.Text = "Typ";
            // 
            // buttonOdswiez
            // 
            buttonOdswiez.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdswiez.Location = new Point(1059, 833);
            buttonOdswiez.Margin = new Padding(4, 3, 4, 3);
            buttonOdswiez.Name = "buttonOdswiez";
            buttonOdswiez.Size = new Size(239, 103);
            buttonOdswiez.TabIndex = 168;
            buttonOdswiez.Text = "Odśwież";
            buttonOdswiez.UseVisualStyleBackColor = true;
            buttonOdswiez.Click += buttonOdswiez_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(690, 187);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(951, 352);
            dataGridView2.TabIndex = 172;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(690, 88);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(494, 60);
            textBox1.TabIndex = 171;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox2.Location = new Point(1193, 103);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(328, 43);
            comboBox2.TabIndex = 170;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1529, 92);
            buttonSzukaj.Margin = new Padding(4, 3, 4, 3);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(150, 72);
            buttonSzukaj.TabIndex = 169;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // buttonZwroc
            // 
            buttonZwroc.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZwroc.Location = new Point(699, 833);
            buttonZwroc.Margin = new Padding(4, 3, 4, 3);
            buttonZwroc.Name = "buttonZwroc";
            buttonZwroc.Size = new Size(239, 103);
            buttonZwroc.TabIndex = 173;
            buttonZwroc.Text = "Zwróć";
            buttonZwroc.UseVisualStyleBackColor = true;
            buttonZwroc.Click += buttonZwroc_Click;
            // 
            // WypozyczeniePracownikForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1727, 1003);
            Controls.Add(buttonZwroc);
            Controls.Add(dataGridView2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(buttonSzukaj);
            Controls.Add(buttonOdswiez);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(buttonZalogujRej);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxTytul);
            Controls.Add(textBoxLogin);
            Controls.Add(buttonWypozycz);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "WypozyczeniePracownikForm";
            Text = "WypozyczeniePracownikForm";
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
        private ComboBox comboBox1;
        private Label label1;
        private Button buttonOdswiez;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button buttonSzukaj;
        private Button buttonZwroc;
    }
}