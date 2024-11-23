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
            buttonUlubiency = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonZaloguj
            // 
            buttonZaloguj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonZaloguj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZaloguj.Location = new Point(1290, 77);
            buttonZaloguj.Name = "buttonZaloguj";
            buttonZaloguj.Size = new Size(138, 55);
            buttonZaloguj.TabIndex = 0;
            buttonZaloguj.Text = "Zaloguj";
            buttonZaloguj.UseVisualStyleBackColor = true;
            buttonZaloguj.Click += buttonZaloguj_Click;
            // 
            // buttonRejstruj
            // 
            buttonRejstruj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRejstruj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRejstruj.Location = new Point(1248, 137);
            buttonRejstruj.Name = "buttonRejstruj";
            buttonRejstruj.Size = new Size(181, 56);
            buttonRejstruj.TabIndex = 1;
            buttonRejstruj.Text = "Zarejestruj";
            buttonRejstruj.UseVisualStyleBackColor = true;
            buttonRejstruj.Click += buttonRejstruj_Click;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(751, 152);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(153, 51);
            buttonSzukaj.TabIndex = 2;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            buttonSzukaj.Click += buttonSzukaj_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Typ produktu", "Ocena", "Kategoria", "Wydawnictwo" });
            comboBox1.Location = new Point(497, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 32);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(11, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 43);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Book Antiqua", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(523, 75);
            label1.TabIndex = 5;
            label1.Text = "Witaj w bibliotece ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 99);
            label2.Name = "label2";
            label2.Size = new Size(608, 40);
            label2.TabIndex = 6;
            label2.Text = "Wyszukaj pozycje, która Cie interesuje ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1369, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 60);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1163, 592);
            dataGridView1.TabIndex = 8;
            // 
            // buttonUlubiency
            // 
            buttonUlubiency.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUlubiency.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUlubiency.Location = new Point(1196, 711);
            buttonUlubiency.Name = "buttonUlubiency";
            buttonUlubiency.Size = new Size(233, 97);
            buttonUlubiency.TabIndex = 10;
            buttonUlubiency.Text = "Ulubieńcy czytelników";
            buttonUlubiency.UseVisualStyleBackColor = true;
            buttonUlubiency.Click += buttonUlubiency_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1196, 598);
            button2.Name = "button2";
            button2.Size = new Size(233, 97);
            button2.TabIndex = 11;
            button2.Text = "Ulubieńcy miesiąca";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1441, 824);
            Controls.Add(button2);
            Controls.Add(buttonUlubiency);
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
        private Button buttonUlubiency;
        private Button button2;
    }
}