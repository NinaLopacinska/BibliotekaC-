namespace bilbioteka.Forms
{
    partial class UzytkownicyPracownik
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            buttonUsun = new Button();
            buttonZalogujRej = new Button();
            textBoxImie = new TextBox();
            label10 = new Label();
            textBoxNazwisko = new TextBox();
            label8 = new Label();
            textBoxLogin = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            buttonSzukaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(112, 474);
            button1.Name = "button1";
            button1.Size = new Size(169, 61);
            button1.TabIndex = 179;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(472, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(796, 452);
            dataGridView1.TabIndex = 178;
            // 
            // buttonUsun
            // 
            buttonUsun.Anchor = AnchorStyles.None;
            buttonUsun.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(112, 395);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(169, 61);
            buttonUsun.TabIndex = 177;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Anchor = AnchorStyles.None;
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(12, 12);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 69);
            buttonZalogujRej.TabIndex = 176;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // textBoxImie
            // 
            textBoxImie.Anchor = AnchorStyles.None;
            textBoxImie.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(112, 283);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(321, 38);
            textBoxImie.TabIndex = 174;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(29, 283);
            label10.Name = "label10";
            label10.Size = new Size(77, 35);
            label10.TabIndex = 173;
            label10.Text = "Imie:";
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Anchor = AnchorStyles.None;
            textBoxNazwisko.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwisko.Location = new Point(182, 332);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(251, 38);
            textBoxNazwisko.TabIndex = 172;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(29, 335);
            label8.Name = "label8";
            label8.Size = new Size(147, 35);
            label8.TabIndex = 171;
            label8.Text = "Nazwisko:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(129, 230);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(304, 38);
            textBoxLogin.TabIndex = 170;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 233);
            label7.Name = "label7";
            label7.Size = new Size(94, 35);
            label7.TabIndex = 169;
            label7.Text = "Login:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(367, 17);
            label6.Name = "label6";
            label6.Size = new Size(518, 58);
            label6.TabIndex = 168;
            label6.Text = "Wyszukaj użytkownika";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 170);
            label1.Name = "label1";
            label1.Size = new Size(404, 40);
            label1.TabIndex = 180;
            label1.Text = "Usuń konto użytkownika";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(472, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 43);
            textBox1.TabIndex = 183;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Imie", "Nazwisko", "Login", "Numer telefonu", "Email", "Pesel" });
            comboBox1.Location = new Point(921, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 36);
            comboBox1.TabIndex = 182;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1141, 113);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(127, 51);
            buttonSzukaj.TabIndex = 181;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // UzytkownicyPracownik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1332, 709);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonUsun);
            Controls.Add(buttonZalogujRej);
            Controls.Add(textBoxImie);
            Controls.Add(label10);
            Controls.Add(textBoxNazwisko);
            Controls.Add(label8);
            Controls.Add(textBoxLogin);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "UzytkownicyPracownik";
            Text = "UsunUzytkownikaPracownik";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button buttonUsun;
        private Button buttonZalogujRej;
        private TextBox textBoxImie;
        private Label label10;
        private TextBox textBoxNazwisko;
        private Label label8;
        private TextBox textBoxLogin;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button buttonSzukaj;
    }
}