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
            SuspendLayout();
            // 
            // buttonZaloguj
            // 
            buttonZaloguj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZaloguj.Location = new Point(22, 24);
            buttonZaloguj.Name = "buttonZaloguj";
            buttonZaloguj.Size = new Size(192, 64);
            buttonZaloguj.TabIndex = 0;
            buttonZaloguj.Text = "Zaloguj";
            buttonZaloguj.UseVisualStyleBackColor = true;
            buttonZaloguj.Click += buttonZaloguj_Click;
            // 
            // buttonRejstruj
            // 
            buttonRejstruj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRejstruj.Location = new Point(249, 24);
            buttonRejstruj.Name = "buttonRejstruj";
            buttonRejstruj.Size = new Size(192, 64);
            buttonRejstruj.TabIndex = 1;
            buttonRejstruj.Text = "Rejstruj";
            buttonRejstruj.UseVisualStyleBackColor = true;
            buttonRejstruj.Click += buttonRejstruj_Click;
            // 
            // buttonSzukaj
            // 
            buttonSzukaj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSzukaj.Location = new Point(458, 508);
            buttonSzukaj.Name = "buttonSzukaj";
            buttonSzukaj.Size = new Size(192, 64);
            buttonSzukaj.TabIndex = 2;
            buttonSzukaj.Text = "Szukaj";
            buttonSzukaj.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Książka ", "Film", "Album ", "Autor", "Nr katalogowy ", "Rok wydania ", "Kategoria " });
            comboBox1.Location = new Point(667, 404);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 40);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(203, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(447, 51);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 229);
            label1.Name = "label1";
            label1.Size = new Size(728, 104);
            label1.TabIndex = 5;
            label1.Text = "Witaj w bibliotece ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 333);
            label2.Name = "label2";
            label2.Size = new Size(608, 40);
            label2.TabIndex = 6;
            label2.Text = "Wyszukaj pozycje, która Cie interesuje ";
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1120, 2);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSzukaj);
            Controls.Add(buttonRejstruj);
            Controls.Add(buttonZaloguj);
            Name = "Form1";
            Text = "Form1";
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
    }
}