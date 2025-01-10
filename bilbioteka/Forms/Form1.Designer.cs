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
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonZaloguj
            // 
            buttonZaloguj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonZaloguj.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZaloguj.Location = new Point(1130, 57);
            buttonZaloguj.Margin = new Padding(3, 2, 3, 2);
            buttonZaloguj.Name = "buttonZaloguj";
            buttonZaloguj.Size = new Size(121, 41);
            buttonZaloguj.TabIndex = 0;
            buttonZaloguj.Text = "Zaloguj";
            buttonZaloguj.UseVisualStyleBackColor = true;
            buttonZaloguj.Click += buttonZaloguj_Click;
            // 
            // buttonRejstruj
            // 
            buttonRejstruj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRejstruj.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRejstruj.Location = new Point(1092, 103);
            buttonRejstruj.Margin = new Padding(3, 2, 3, 2);
            buttonRejstruj.Name = "buttonRejstruj";
            buttonRejstruj.Size = new Size(158, 42);
            buttonRejstruj.TabIndex = 1;
            buttonRejstruj.Text = "Zarejestruj";
            buttonRejstruj.UseVisualStyleBackColor = true;
            buttonRejstruj.Click += buttonRejstruj_Click;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSzukaj.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(657, 114);
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
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "   ", "Tytuł", "Autor", "Rok wydania", "Typ produktu", "Ocena", "Kategoria", "Wydawnictwo" });
            comboBox1.Location = new Point(435, 124);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(216, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(10, 116);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 36);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ScrollBar;
            label1.Font = new Font("Book Antiqua", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(419, 58);
            label1.TabIndex = 5;
            label1.Text = "Witaj w bibliotece ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(485, 32);
            label2.TabIndex = 6;
            label2.Text = "Wyszukaj pozycje, która Cie interesuje ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1198, 9);
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
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 162);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(948, 444);
            dataGridView1.TabIndex = 8;
            // 
            // buttonUlubiency
            // 
            buttonUlubiency.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUlubiency.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUlubiency.Location = new Point(1046, 533);
            buttonUlubiency.Margin = new Padding(3, 2, 3, 2);
            buttonUlubiency.Name = "buttonUlubiency";
            buttonUlubiency.Size = new Size(204, 73);
            buttonUlubiency.TabIndex = 10;
            buttonUlubiency.Text = "Ulubieńcy czytelników";
            buttonUlubiency.UseVisualStyleBackColor = true;
            buttonUlubiency.Click += buttonUlubiency_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(1046, 448);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(204, 73);
            button2.TabIndex = 11;
            button2.Text = "Ulubieńcy miesiąca";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1046, 394);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(204, 50);
            button3.TabIndex = 12;
            button3.Text = "Regulamin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1261, 618);
            Controls.Add(button3);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Menu";
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
        private Button button3;
    }
}