namespace bilbioteka.Forms
{
    partial class StatystykiPracownik
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelIloscUzytkownikow = new Label();
            labelIloscWypozyczen = new Label();
            labelUzytkownik = new Label();
            dataGridViewPozycja = new DataGridView();
            dataGridViewGatunki = new DataGridView();
            buttonZalogujRej = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPozycja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGatunki).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 39);
            label2.Name = "label2";
            label2.Size = new Size(334, 40);
            label2.TabIndex = 8;
            label2.Text = "Ilość użytkowników:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(173, 110);
            label1.Name = "label1";
            label1.Size = new Size(492, 40);
            label1.TabIndex = 9;
            label1.Text = "Ilość dokonanych wypożyczeń:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(173, 261);
            label3.Name = "label3";
            label3.Size = new Size(423, 40);
            label3.TabIndex = 10;
            label3.Text = "Najpopularniejsze pozycje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(173, 180);
            label4.Name = "label4";
            label4.Size = new Size(621, 40);
            label4.TabIndex = 11;
            label4.Text = "Najczęściej wypożyczający użytkownik:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(173, 538);
            label5.Name = "label5";
            label5.Size = new Size(417, 40);
            label5.TabIndex = 12;
            label5.Text = "Najpopularniejsze gatunki\r\n";
            // 
            // labelIloscUzytkownikow
            // 
            labelIloscUzytkownikow.AutoSize = true;
            labelIloscUzytkownikow.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelIloscUzytkownikow.Location = new Point(517, 39);
            labelIloscUzytkownikow.Name = "labelIloscUzytkownikow";
            labelIloscUzytkownikow.Size = new Size(334, 40);
            labelIloscUzytkownikow.TabIndex = 13;
            labelIloscUzytkownikow.Text = "Ilość użytkowników:";
            // 
            // labelIloscWypozyczen
            // 
            labelIloscWypozyczen.AutoSize = true;
            labelIloscWypozyczen.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelIloscWypozyczen.Location = new Point(657, 110);
            labelIloscWypozyczen.Name = "labelIloscWypozyczen";
            labelIloscWypozyczen.Size = new Size(334, 40);
            labelIloscWypozyczen.TabIndex = 14;
            labelIloscWypozyczen.Text = "Ilość użytkowników:";
            // 
            // labelUzytkownik
            // 
            labelUzytkownik.AutoSize = true;
            labelUzytkownik.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            labelUzytkownik.Location = new Point(778, 180);
            labelUzytkownik.Name = "labelUzytkownik";
            labelUzytkownik.Size = new Size(334, 40);
            labelUzytkownik.TabIndex = 15;
            labelUzytkownik.Text = "Ilość użytkowników:";
            // 
            // dataGridViewPozycja
            // 
            dataGridViewPozycja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPozycja.Location = new Point(173, 326);
            dataGridViewPozycja.Margin = new Padding(2, 2, 2, 2);
            dataGridViewPozycja.Name = "dataGridViewPozycja";
            dataGridViewPozycja.RowHeadersWidth = 62;
            dataGridViewPozycja.RowTemplate.Height = 33;
            dataGridViewPozycja.Size = new Size(796, 180);
            dataGridViewPozycja.TabIndex = 16;
            // 
            // dataGridViewGatunki
            // 
            dataGridViewGatunki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGatunki.Location = new Point(173, 596);
            dataGridViewGatunki.Margin = new Padding(2, 2, 2, 2);
            dataGridViewGatunki.Name = "dataGridViewGatunki";
            dataGridViewGatunki.RowHeadersWidth = 62;
            dataGridViewGatunki.RowTemplate.Height = 33;
            dataGridViewGatunki.Size = new Size(796, 180);
            dataGridViewGatunki.TabIndex = 17;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(10, 15);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 74);
            buttonZalogujRej.TabIndex = 166;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // StatystykiPracownik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            ClientSize = new Size(1385, 804);
            Controls.Add(buttonZalogujRej);
            Controls.Add(dataGridViewGatunki);
            Controls.Add(dataGridViewPozycja);
            Controls.Add(labelUzytkownik);
            Controls.Add(labelIloscWypozyczen);
            Controls.Add(labelIloscUzytkownikow);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "StatystykiPracownik";
            Text = "StatystykiPracownik";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPozycja).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGatunki).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelIloscUzytkownikow;
        private Label labelIloscWypozyczen;
        private Label labelUzytkownik;
        private DataGridView dataGridViewPozycja;
        private DataGridView dataGridViewGatunki;
        private Button buttonZalogujRej;
    }
}