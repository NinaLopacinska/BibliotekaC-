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
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            buttonSzukaj = new Button();
            buttonZwroc = new Button();
            buttonWydluzTermin = new Button();
            textBoxTyt = new TextBox();
            textBoxLog = new TextBox();
            label4 = new Label();
            label5 = new Label();
            buttonOdswiez = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 82);
            label2.Name = "label2";
            label2.Size = new Size(266, 36);
            label2.TabIndex = 8;
            label2.Text = "Login użytkownika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 189);
            label3.Name = "label3";
            label3.Size = new Size(83, 36);
            label3.TabIndex = 10;
            label3.Text = "Tytuł";
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(10, 377);
            buttonWypozycz.Margin = new Padding(3, 2, 3, 2);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(191, 62);
            buttonWypozycz.TabIndex = 11;
            buttonWypozycz.Text = "Wypożycz";
            buttonWypozycz.UseVisualStyleBackColor = true;
            buttonWypozycz.Click += buttonWypozycz_Click_1;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(10, 122);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(413, 46);
            textBoxLogin.TabIndex = 17;
            // 
            // textBoxTytul
            // 
            textBoxTytul.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(10, 229);
            textBoxTytul.Margin = new Padding(3, 2, 3, 2);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(413, 46);
            textBoxTytul.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 523);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(797, 297);
            dataGridView1.TabIndex = 19;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(11, 14);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(99, 66);
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
            comboBox1.Location = new Point(10, 328);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(412, 40);
            comboBox1.TabIndex = 166;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 288);
            label1.Name = "label1";
            label1.Size = new Size(66, 36);
            label1.TabIndex = 167;
            label1.Text = "Typ";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(430, 82);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1097, 408);
            dataGridView2.TabIndex = 172;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(427, 20);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 51);
            textBox1.TabIndex = 171;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox2.Location = new Point(841, 32);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(263, 36);
            comboBox2.TabIndex = 170;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1112, 14);
            buttonSzukaj.Margin = new Padding(3, 2, 3, 2);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(120, 62);
            buttonSzukaj.TabIndex = 169;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // buttonZwroc
            // 
            buttonZwroc.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZwroc.Location = new Point(820, 743);
            buttonZwroc.Margin = new Padding(3, 2, 3, 2);
            buttonZwroc.Name = "buttonZwroc";
            buttonZwroc.Size = new Size(166, 62);
            buttonZwroc.TabIndex = 173;
            buttonZwroc.Text = "Zwróć";
            buttonZwroc.UseVisualStyleBackColor = true;
            buttonZwroc.Click += buttonZwroc_Click;
            // 
            // buttonWydluzTermin
            // 
            buttonWydluzTermin.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWydluzTermin.Location = new Point(1005, 743);
            buttonWydluzTermin.Margin = new Padding(3, 2, 3, 2);
            buttonWydluzTermin.Name = "buttonWydluzTermin";
            buttonWydluzTermin.Size = new Size(227, 62);
            buttonWydluzTermin.TabIndex = 174;
            buttonWydluzTermin.Text = "Wydłuż termin";
            buttonWydluzTermin.UseVisualStyleBackColor = true;
            buttonWydluzTermin.Click += buttonWydluzTermin_Click;
            // 
            // textBoxTyt
            // 
            textBoxTyt.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTyt.Location = new Point(819, 671);
            textBoxTyt.Margin = new Padding(3, 2, 3, 2);
            textBoxTyt.Name = "textBoxTyt";
            textBoxTyt.Size = new Size(413, 46);
            textBoxTyt.TabIndex = 178;
            // 
            // textBoxLog
            // 
            textBoxLog.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLog.Location = new Point(819, 564);
            textBoxLog.Margin = new Padding(3, 2, 3, 2);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(413, 45);
            textBoxLog.TabIndex = 177;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(820, 631);
            label4.Name = "label4";
            label4.Size = new Size(83, 36);
            label4.TabIndex = 176;
            label4.Text = "Tytuł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(820, 524);
            label5.Name = "label5";
            label5.Size = new Size(266, 36);
            label5.TabIndex = 175;
            label5.Text = "Login użytkownika";
            // 
            // buttonOdswiez
            // 
            buttonOdswiez.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOdswiez.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOdswiez.Location = new Point(1248, 743);
            buttonOdswiez.Margin = new Padding(3, 2, 3, 2);
            buttonOdswiez.Name = "buttonOdswiez";
            buttonOdswiez.Size = new Size(70, 62);
            buttonOdswiez.TabIndex = 168;
            buttonOdswiez.Text = "⟲";
            buttonOdswiez.UseVisualStyleBackColor = true;
            buttonOdswiez.Click += buttonOdswiez_Click;
            // 
            // WypozyczeniePracownikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1539, 840);
            Controls.Add(textBoxTyt);
            Controls.Add(textBoxLog);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(buttonWydluzTermin);
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
            Margin = new Padding(2);
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
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button buttonSzukaj;
        private Button buttonZwroc;
        private Button buttonWydluzTermin;
        private TextBox textBoxTyt;
        private TextBox textBoxLog;
        private Label label4;
        private Label label5;
        private Button buttonOdswiez;
    }
}