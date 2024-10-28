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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(342, 264);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1024, 529);
            dataGridView1.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(342, 110);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 60);
            textBox1.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Książka ", "Film", "Album ", "Autor", "Nr katalogowy ", "Rok wydania ", "Kategoria " });
            comboBox1.Location = new Point(342, 181);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 46);
            comboBox1.TabIndex = 27;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(882, 110);
            buttonSzukaj.Margin = new Padding(4);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(130, 64);
            buttonSzukaj.TabIndex = 26;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1300, 15);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(162, 74);
            button2.TabIndex = 25;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonEdytujKonto
            // 
            buttonEdytujKonto.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujKonto.Location = new Point(31, 424);
            buttonEdytujKonto.Margin = new Padding(4);
            buttonEdytujKonto.Name = "buttonEdytujKonto";
            buttonEdytujKonto.Size = new Size(276, 121);
            buttonEdytujKonto.TabIndex = 23;
            buttonEdytujKonto.Text = "Edytuj konto ";
            buttonEdytujKonto.UseVisualStyleBackColor = true;
            // 
            // buttonHistoriaWypozyczen
            // 
            buttonHistoriaWypozyczen.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHistoriaWypozyczen.Location = new Point(31, 268);
            buttonHistoriaWypozyczen.Margin = new Padding(4);
            buttonHistoriaWypozyczen.Name = "buttonHistoriaWypozyczen";
            buttonHistoriaWypozyczen.Size = new Size(276, 121);
            buttonHistoriaWypozyczen.TabIndex = 20;
            buttonHistoriaWypozyczen.Text = "Historia wypożyczeń";
            buttonHistoriaWypozyczen.UseVisualStyleBackColor = true;
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
            wypożycz.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            wypożycz.Location = new Point(31, 573);
            wypożycz.Margin = new Padding(4);
            wypożycz.Name = "wypożycz";
            wypożycz.Size = new Size(276, 121);
            wypożycz.TabIndex = 30;
            wypożycz.Text = "wypożycz";
            wypożycz.UseVisualStyleBackColor = true;
            wypożycz.Click += wypożycz_Click;
            // 
            // MainUzytkownikForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(1478, 941);
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
            Margin = new Padding(4);
            Name = "MainUzytkownikForm";
            Text = "MainUzytkownikForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}