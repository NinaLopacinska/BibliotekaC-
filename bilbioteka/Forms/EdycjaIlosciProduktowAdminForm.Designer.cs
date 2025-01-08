namespace bilbioteka.Forms
{
    partial class EdycjaProduktowAdminForm
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
            buttonDodaj = new Button();
            textBoxIlosc = new TextBox();
            label10 = new Label();
            textBoxNrKatalogowy = new TextBox();
            label8 = new Label();
            textBoxTytul = new TextBox();
            label7 = new Label();
            label6 = new Label();
            buttonZalogujRej = new Button();
            buttonUsun = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            buttonSzukaj = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonDodaj
            // 
            buttonDodaj.Anchor = AnchorStyles.None;
            buttonDodaj.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(131, 388);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(169, 61);
            buttonDodaj.TabIndex = 163;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxIlosc
            // 
            textBoxIlosc.Anchor = AnchorStyles.None;
            textBoxIlosc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIlosc.Location = new Point(98, 219);
            textBoxIlosc.Name = "textBoxIlosc";
            textBoxIlosc.Size = new Size(322, 38);
            textBoxIlosc.TabIndex = 162;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(14, 222);
            label10.Name = "label10";
            label10.Size = new Size(78, 35);
            label10.TabIndex = 161;
            label10.Text = "Ilość:";
            // 
            // textBoxNrKatalogowy
            // 
            textBoxNrKatalogowy.Anchor = AnchorStyles.None;
            textBoxNrKatalogowy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrKatalogowy.Location = new Point(236, 281);
            textBoxNrKatalogowy.Name = "textBoxNrKatalogowy";
            textBoxNrKatalogowy.Size = new Size(184, 38);
            textBoxNrKatalogowy.TabIndex = 160;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 284);
            label8.Name = "label8";
            label8.Size = new Size(216, 35);
            label8.TabIndex = 159;
            label8.Text = "Nr. katalogowy:";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Anchor = AnchorStyles.None;
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(109, 164);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(311, 38);
            textBoxTytul.TabIndex = 158;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 164);
            label7.Name = "label7";
            label7.Size = new Size(89, 35);
            label7.TabIndex = 157;
            label7.Text = "Tytuł:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(482, 14);
            label6.Name = "label6";
            label6.Size = new Size(551, 67);
            label6.TabIndex = 156;
            label6.Text = "Edycja ilości zasobów";
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(11, 12);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 69);
            buttonZalogujRej.TabIndex = 164;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.Anchor = AnchorStyles.None;
            buttonUsun.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(131, 472);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(169, 61);
            buttonUsun.TabIndex = 165;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(439, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1026, 465);
            dataGridView1.TabIndex = 166;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(131, 552);
            button1.Name = "button1";
            button1.Size = new Size(169, 61);
            button1.TabIndex = 167;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(439, 116);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(421, 43);
            textBox1.TabIndex = 174;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox2.Location = new Point(866, 123);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(263, 36);
            comboBox2.TabIndex = 173;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(1135, 107);
            buttonSzukaj.Margin = new Padding(3, 2, 3, 2);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(114, 52);
            buttonSzukaj.TabIndex = 172;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // EdycjaProduktowAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1475, 673);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(buttonSzukaj);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonUsun);
            Controls.Add(buttonZalogujRej);
            Controls.Add(buttonDodaj);
            Controls.Add(textBoxIlosc);
            Controls.Add(label10);
            Controls.Add(textBoxNrKatalogowy);
            Controls.Add(label8);
            Controls.Add(textBoxTytul);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "EdycjaProduktowAdminForm";
            Text = "Edycja zasobów";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDodaj;
        private TextBox textBoxIlosc;
        private Label label10;
        private TextBox textBoxNrKatalogowy;
        private Label label8;
        private TextBox textBoxTytul;
        private Label label7;
        private Label label6;
        private Button buttonZalogujRej;
        private Button buttonUsun;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Button buttonSzukaj;
    }
}