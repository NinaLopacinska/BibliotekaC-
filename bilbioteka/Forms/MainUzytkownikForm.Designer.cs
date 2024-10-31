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
            wypożycz = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(294, 346);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(741, 588);
            dataGridView1.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(294, 190);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(556, 60);
            textBox1.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria" });
            comboBox1.Location = new Point(294, 278);
            comboBox1.Margin = new Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 46);
            comboBox1.TabIndex = 27;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(880, 190);
            buttonSzukaj.Margin = new Padding(4, 4, 4, 4);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(155, 70);
            buttonSzukaj.TabIndex = 26;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1550, 15);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(162, 74);
            button2.TabIndex = 25;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonEdytujKonto
            // 
            buttonEdytujKonto.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujKonto.Location = new Point(15, 346);
            buttonEdytujKonto.Margin = new Padding(4, 4, 4, 4);
            buttonEdytujKonto.Name = "buttonEdytujKonto";
            buttonEdytujKonto.Size = new Size(238, 100);
            buttonEdytujKonto.TabIndex = 23;
            buttonEdytujKonto.Text = "Edytuj konto ";
            buttonEdytujKonto.UseVisualStyleBackColor = true;
            // 
            // buttonHistoriaWypozyczen
            // 
            buttonHistoriaWypozyczen.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHistoriaWypozyczen.Location = new Point(15, 190);
            buttonHistoriaWypozyczen.Margin = new Padding(4, 4, 4, 4);
            buttonHistoriaWypozyczen.Name = "buttonHistoriaWypozyczen";
            buttonHistoriaWypozyczen.Size = new Size(238, 100);
            buttonHistoriaWypozyczen.TabIndex = 20;
            buttonHistoriaWypozyczen.Text = "Historia wypożyczeń";
            buttonHistoriaWypozyczen.UseVisualStyleBackColor = true;
            buttonHistoriaWypozyczen.Click += buttonHistoriaWypozyczen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(368, 47);
            label2.TabIndex = 19;
            label2.Text = "Witaj Użytkowniku";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(404, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 47);
            label1.TabIndex = 18;
            label1.Text = "label1";
            // 
            // wypożycz
            // 
            wypożycz.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            wypożycz.Location = new Point(15, 495);
            wypożycz.Margin = new Padding(4, 4, 4, 4);
            wypożycz.Name = "wypożycz";
            wypożycz.Size = new Size(238, 100);
            wypożycz.TabIndex = 30;
            wypożycz.Text = "wypożycz";
            wypożycz.UseVisualStyleBackColor = true;
            wypożycz.Click += wypożycz_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1172, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(337, 41);
            label3.TabIndex = 31;
            label3.Text = "Twoje wypożyczenia:";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1059, 346);
            dataGridView2.Margin = new Padding(4, 4, 4, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(654, 290);
            dataGridView2.TabIndex = 32;
            // 
            // MainUzytkownikForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(1728, 1004);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(wypożycz);
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
            Margin = new Padding(4, 4, 4, 4);
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
        private Button wypożycz;
        private Label label3;
        private DataGridView dataGridView2;
    }
}