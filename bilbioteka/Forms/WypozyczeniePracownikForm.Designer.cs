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
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 176);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 8;
            label2.Text = "Login ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 239);
            label3.Name = "label3";
            label3.Size = new Size(83, 36);
            label3.TabIndex = 10;
            label3.Text = "Tytuł";
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(13, 362);
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
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(116, 176);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(272, 38);
            textBoxLogin.TabIndex = 17;
            // 
            // textBoxTytul
            // 
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(102, 239);
            textBoxTytul.Margin = new Padding(3, 2, 3, 2);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(286, 38);
            textBoxTytul.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 472);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(835, 357);
            dataGridView1.TabIndex = 19;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(11, 14);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(92, 66);
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
            comboBox1.Location = new Point(85, 293);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(303, 40);
            comboBox1.TabIndex = 166;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 293);
            label1.Name = "label1";
            label1.Size = new Size(66, 36);
            label1.TabIndex = 167;
            label1.Text = "Typ";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(436, 82);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1059, 367);
            dataGridView2.TabIndex = 172;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(436, 27);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 47);
            textBox1.TabIndex = 171;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox2.Location = new Point(923, 39);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(263, 36);
            comboBox2.TabIndex = 170;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1194, 21);
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
            buttonZwroc.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZwroc.Location = new Point(952, 684);
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
            buttonWydluzTermin.Location = new Point(953, 767);
            buttonWydluzTermin.Margin = new Padding(3, 2, 3, 2);
            buttonWydluzTermin.Name = "buttonWydluzTermin";
            buttonWydluzTermin.Size = new Size(241, 62);
            buttonWydluzTermin.TabIndex = 174;
            buttonWydluzTermin.Text = "Wydłuż termin";
            buttonWydluzTermin.UseVisualStyleBackColor = true;
            buttonWydluzTermin.Click += buttonWydluzTermin_Click;
            // 
            // textBoxTyt
            // 
            textBoxTyt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTyt.Location = new Point(969, 616);
            textBoxTyt.Margin = new Padding(3, 2, 3, 2);
            textBoxTyt.Name = "textBoxTyt";
            textBoxTyt.Size = new Size(305, 38);
            textBoxTyt.TabIndex = 178;
            // 
            // textBoxLog
            // 
            textBoxLog.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLog.Location = new Point(977, 558);
            textBoxLog.Margin = new Padding(3, 2, 3, 2);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(297, 38);
            textBoxLog.TabIndex = 177;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(880, 616);
            label4.Name = "label4";
            label4.Size = new Size(83, 36);
            label4.TabIndex = 176;
            label4.Text = "Tytuł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(881, 558);
            label5.Name = "label5";
            label5.Size = new Size(90, 36);
            label5.TabIndex = 175;
            label5.Text = "Login";
            // 
            // buttonOdswiez
            // 
            buttonOdswiez.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOdswiez.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOdswiez.Location = new Point(1124, 684);
            buttonOdswiez.Margin = new Padding(3, 2, 3, 2);
            buttonOdswiez.Name = "buttonOdswiez";
            buttonOdswiez.Size = new Size(70, 62);
            buttonOdswiez.TabIndex = 168;
            buttonOdswiez.Text = "⟲";
            buttonOdswiez.UseVisualStyleBackColor = true;
            buttonOdswiez.Click += buttonOdswiez_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(11, 101);
            label6.Name = "label6";
            label6.Size = new Size(377, 37);
            label6.TabIndex = 179;
            label6.Text = "Wypożycz użytkownikowi";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(879, 495);
            label7.Name = "label7";
            label7.Size = new Size(395, 37);
            label7.TabIndex = 180;
            label7.Text = "Zwróć pozycje użytkownika";
            // 
            // WypozyczeniePracownikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1561, 840);
            Controls.Add(label7);
            Controls.Add(label6);
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
        private Label label6;
        private Label label7;
    }
}