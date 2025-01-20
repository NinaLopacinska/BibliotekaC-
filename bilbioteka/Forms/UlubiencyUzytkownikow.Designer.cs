namespace bilbioteka.Forms
{
    partial class UlubiencyUzytkownikow
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
            buttonZalogujRej = new Button();
            dataGridViewGatunki = new DataGridView();
            dataGridViewPozycja = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            checkBoxKsiazki = new CheckBox();
            checkBoxFilmy = new CheckBox();
            checkBoxAlbumy = new CheckBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGatunki).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPozycja).BeginInit();
            SuspendLayout();
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(12, 11);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 74);
            buttonZalogujRej.TabIndex = 177;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // dataGridViewGatunki
            // 
            dataGridViewGatunki.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewGatunki.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewGatunki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGatunki.Location = new Point(224, 542);
            dataGridViewGatunki.Margin = new Padding(2);
            dataGridViewGatunki.Name = "dataGridViewGatunki";
            dataGridViewGatunki.RowHeadersWidth = 62;
            dataGridViewGatunki.RowTemplate.Height = 33;
            dataGridViewGatunki.Size = new Size(663, 242);
            dataGridViewGatunki.TabIndex = 176;
            // 
            // dataGridViewPozycja
            // 
            dataGridViewPozycja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPozycja.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewPozycja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPozycja.Location = new Point(224, 211);
            dataGridViewPozycja.Margin = new Padding(2);
            dataGridViewPozycja.Name = "dataGridViewPozycja";
            dataGridViewPozycja.RowHeadersWidth = 62;
            dataGridViewPozycja.RowTemplate.Height = 33;
            dataGridViewPozycja.Size = new Size(663, 242);
            dataGridViewPozycja.TabIndex = 175;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(224, 482);
            label5.Name = "label5";
            label5.Size = new Size(652, 40);
            label5.TabIndex = 171;
            label5.Text = "Sprawdź nasze najlepiej oceniane pozycje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(278, 37);
            label4.Name = "label4";
            label4.Size = new Size(569, 58);
            label4.TabIndex = 170;
            label4.Text = "Ulubieńcy użytkowników";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(224, 136);
            label3.Name = "label3";
            label3.Size = new Size(676, 40);
            label3.TabIndex = 169;
            label3.Text = "Najchętniej wypożczamyni pozycjami w są:";
            // 
            // checkBoxKsiazki
            // 
            checkBoxKsiazki.AutoSize = true;
            checkBoxKsiazki.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxKsiazki.Location = new Point(905, 543);
            checkBoxKsiazki.Name = "checkBoxKsiazki";
            checkBoxKsiazki.Size = new Size(112, 32);
            checkBoxKsiazki.TabIndex = 178;
            checkBoxKsiazki.Text = "Ksiązki";
            checkBoxKsiazki.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilmy
            // 
            checkBoxFilmy.AutoSize = true;
            checkBoxFilmy.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFilmy.Location = new Point(905, 599);
            checkBoxFilmy.Name = "checkBoxFilmy";
            checkBoxFilmy.Size = new Size(94, 32);
            checkBoxFilmy.TabIndex = 179;
            checkBoxFilmy.Text = "Filmy";
            checkBoxFilmy.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlbumy
            // 
            checkBoxAlbumy.AutoSize = true;
            checkBoxAlbumy.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAlbumy.Location = new Point(905, 654);
            checkBoxAlbumy.Name = "checkBoxAlbumy";
            checkBoxAlbumy.Size = new Size(262, 32);
            checkBoxAlbumy.TabIndex = 180;
            checkBoxAlbumy.Text = "Albumy fotograficzne";
            checkBoxAlbumy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(905, 733);
            button1.Name = "button1";
            button1.Size = new Size(157, 51);
            button1.TabIndex = 181;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UlubiencyUzytkownikow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            ClientSize = new Size(1230, 804);
            Controls.Add(button1);
            Controls.Add(checkBoxAlbumy);
            Controls.Add(checkBoxFilmy);
            Controls.Add(checkBoxKsiazki);
            Controls.Add(buttonZalogujRej);
            Controls.Add(dataGridViewGatunki);
            Controls.Add(dataGridViewPozycja);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "UlubiencyUzytkownikow";
            Text = "Ulubiency użytkowników";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGatunki).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPozycja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZalogujRej;
        private DataGridView dataGridViewGatunki;
        private DataGridView dataGridViewPozycja;
        private Label label5;
        private Label label4;
        private Label label3;
        private CheckBox checkBoxKsiazki;
        private CheckBox checkBoxFilmy;
        private CheckBox checkBoxAlbumy;
        private Button button1;
    }
}