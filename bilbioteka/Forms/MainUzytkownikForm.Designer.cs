namespace bilbioteka.Forms
{
    partial class MainUzytkownikForm
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            buttonSzukaj = new Button();
            button2 = new Button();
            buttonEdytujKonto = new Button();
            buttonHistoriaWypozyczen = new Button();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            labelNoActiveLoans = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1047, 663);
            dataGridView1.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(9, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 51);
            textBox1.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox1.Location = new Point(463, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 40);
            comboBox1.TabIndex = 27;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.BackColor = SystemColors.MenuBar;
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(707, 77);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(151, 57);
            buttonSzukaj.TabIndex = 26;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = false;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1355, 15);
            button2.Name = "button2";
            button2.Size = new Size(130, 43);
            button2.TabIndex = 25;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonEdytujKonto
            // 
            buttonEdytujKonto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdytujKonto.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujKonto.Location = new Point(1330, 63);
            buttonEdytujKonto.Name = "buttonEdytujKonto";
            buttonEdytujKonto.Size = new Size(155, 43);
            buttonEdytujKonto.TabIndex = 23;
            buttonEdytujKonto.Text = "Edytuj konto ";
            buttonEdytujKonto.UseVisualStyleBackColor = true;
            buttonEdytujKonto.Click += buttonEdytujKonto_Click;
            // 
            // buttonHistoriaWypozyczen
            // 
            buttonHistoriaWypozyczen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonHistoriaWypozyczen.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHistoriaWypozyczen.Location = new Point(1259, 384);
            buttonHistoriaWypozyczen.Name = "buttonHistoriaWypozyczen";
            buttonHistoriaWypozyczen.Size = new Size(230, 73);
            buttonHistoriaWypozyczen.TabIndex = 20;
            buttonHistoriaWypozyczen.Text = "Moje wypożyczenia:";
            buttonHistoriaWypozyczen.UseVisualStyleBackColor = true;
            buttonHistoriaWypozyczen.Click += buttonHistoriaWypozyczen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 15);
            label2.Name = "label2";
            label2.Size = new Size(214, 40);
            label2.TabIndex = 19;
            label2.Text = "Użytkownik:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(213, 15);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 18;
            label1.Text = "label1";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1063, 463);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(426, 212);
            dataGridView2.TabIndex = 32;
            // 
            // labelNoActiveLoans
            // 
            labelNoActiveLoans.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelNoActiveLoans.AutoSize = true;
            labelNoActiveLoans.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoActiveLoans.Location = new Point(1146, 697);
            labelNoActiveLoans.Name = "labelNoActiveLoans";
            labelNoActiveLoans.Size = new Size(381, 35);
            labelNoActiveLoans.TabIndex = 33;
            labelNoActiveLoans.Text = "Brak aktywnych wypożyczeń";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Book Antiqua", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1355, 752);
            button1.Name = "button1";
            button1.Size = new Size(134, 65);
            button1.TabIndex = 34;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainUzytkownikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1499, 832);
            Controls.Add(button1);
            Controls.Add(labelNoActiveLoans);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj);
            Controls.Add(button2);
            Controls.Add(buttonEdytujKonto);
            Controls.Add(buttonHistoriaWypozyczen);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "MainUzytkownikForm";
            Text = "MainUzytkownikForm";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button buttonSzukaj;
        private Button button2;
        private Button buttonEdytujKonto;
        private Button buttonHistoriaWypozyczen;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView2;
        private Label labelNoActiveLoans;
        private Button button1;
    }
}