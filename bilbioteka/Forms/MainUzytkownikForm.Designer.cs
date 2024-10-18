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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(274, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(819, 423);
            dataGridView1.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(274, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 51);
            textBox1.TabIndex = 28;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Książka ", "Film", "Album ", "Autor", "Nr katalogowy ", "Rok wydania ", "Kategoria " });
            comboBox1.Location = new Point(274, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 40);
            comboBox1.TabIndex = 27;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(706, 88);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(104, 51);
            buttonSzukaj.TabIndex = 26;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1040, 12);
            button2.Name = "button2";
            button2.Size = new Size(130, 59);
            button2.TabIndex = 25;
            button2.Text = "Wyloguj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonEdytujKonto
            // 
            buttonEdytujKonto.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujKonto.Location = new Point(25, 339);
            buttonEdytujKonto.Name = "buttonEdytujKonto";
            buttonEdytujKonto.Size = new Size(221, 97);
            buttonEdytujKonto.TabIndex = 23;
            buttonEdytujKonto.Text = "Edytuj konto ";
            buttonEdytujKonto.UseVisualStyleBackColor = true;
            // 
            // buttonHistoriaWypozyczen
            // 
            buttonHistoriaWypozyczen.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHistoriaWypozyczen.Location = new Point(25, 214);
            buttonHistoriaWypozyczen.Name = "buttonHistoriaWypozyczen";
            buttonHistoriaWypozyczen.Size = new Size(221, 97);
            buttonHistoriaWypozyczen.TabIndex = 20;
            buttonHistoriaWypozyczen.Text = "Historia wypożyczeń";
            buttonHistoriaWypozyczen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(315, 40);
            label2.TabIndex = 19;
            label2.Text = "Witaj Użytkowniku";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 88);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 18;
            label1.Text = "label1";
            // 
            // MainUzytkownikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj);
            Controls.Add(button2);
            Controls.Add(buttonEdytujKonto);
            Controls.Add(buttonHistoriaWypozyczen);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}