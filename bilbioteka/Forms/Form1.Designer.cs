namespace bilbioteka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonZaloguj = new Button();
            buttonRejstruj = new Button();
            buttonSzukaj = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2Nowosci = new Button();
            buttonUlubiency = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonZaloguj
            // 
            buttonZaloguj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZaloguj.Location = new Point(24, 17);
            buttonZaloguj.Margin = new Padding(3, 2, 3, 2);
            buttonZaloguj.Name = "buttonZaloguj";
            buttonZaloguj.Size = new Size(193, 56);
            buttonZaloguj.TabIndex = 0;
            buttonZaloguj.Text = "Zaloguj";
            buttonZaloguj.UseVisualStyleBackColor = true;
            buttonZaloguj.Click += buttonZaloguj_Click;
            // 
            // buttonRejstruj
            // 
            buttonRejstruj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRejstruj.Location = new Point(24, 88);
            buttonRejstruj.Margin = new Padding(3, 2, 3, 2);
            buttonRejstruj.Name = "buttonRejstruj";
            buttonRejstruj.Size = new Size(193, 58);
            buttonRejstruj.TabIndex = 1;
            buttonRejstruj.Text = "Zarejestruj";
            buttonRejstruj.UseVisualStyleBackColor = true;
            buttonRejstruj.Click += buttonRejstruj_Click;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(862, 212);
            buttonSzukaj.Margin = new Padding(3, 2, 3, 2);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(134, 38);
            buttonSzukaj.TabIndex = 2;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Numer katalogowy", "Typ produktu", "Ocena", "Ilość", "Kategoria", "Wydawnictwo" });
            comboBox1.Location = new Point(645, 220);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(237, 217);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 36);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Book Antiqua", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(237, 114);
            label1.Name = "label1";
            label1.Size = new Size(419, 58);
            label1.TabIndex = 5;
            label1.Text = "Witaj w bibliotece ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(237, 178);
            label2.Name = "label2";
            label2.Size = new Size(485, 32);
            label2.TabIndex = 6;
            label2.Text = "Wyszukaj pozycje, która Cie interesuje ";
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1146, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(52, 45);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 266);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(759, 269);
            dataGridView1.TabIndex = 8;
            // 
            // button2Nowosci
            // 
            button2Nowosci.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button2Nowosci.Location = new Point(24, 397);
            button2Nowosci.Margin = new Padding(3, 2, 3, 2);
            button2Nowosci.Name = "button2Nowosci";
            button2Nowosci.Size = new Size(193, 73);
            button2Nowosci.TabIndex = 9;
            button2Nowosci.Text = "Nowości ";
            button2Nowosci.UseVisualStyleBackColor = true;
            // 
            // buttonUlubiency
            // 
            buttonUlubiency.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUlubiency.Location = new Point(24, 304);
            buttonUlubiency.Margin = new Padding(3, 2, 3, 2);
            buttonUlubiency.Name = "buttonUlubiency";
            buttonUlubiency.Size = new Size(193, 73);
            buttonUlubiency.TabIndex = 10;
            buttonUlubiency.Text = "Ulubieńcy miesiąca";
            buttonUlubiency.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 602);
            Controls.Add(buttonUlubiency);
            Controls.Add(button2Nowosci);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj);
            Controls.Add(buttonRejstruj);
            Controls.Add(buttonZaloguj);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZaloguj;
        private Button buttonRejstruj;
        private Button buttonSzukaj;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2Nowosci;
        private Button buttonUlubiency;
    }
}