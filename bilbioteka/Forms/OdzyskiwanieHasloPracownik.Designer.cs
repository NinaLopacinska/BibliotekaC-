namespace bilbioteka.Forms
{
    partial class OdzyskiwanieHasloPracownik
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
            buttonZalogujRej = new Button();
            buttonDodaj = new Button();
            textBoxHaslo = new TextBox();
            label10 = new Label();
            textBoxTytul = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(459, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(757, 376);
            dataGridView1.TabIndex = 178;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(12, 12);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 69);
            buttonZalogujRej.TabIndex = 176;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Anchor = AnchorStyles.None;
            buttonDodaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(162, 455);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(198, 61);
            buttonDodaj.TabIndex = 175;
            buttonDodaj.Text = "Zapisz";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Anchor = AnchorStyles.None;
            textBoxHaslo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(162, 302);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(252, 38);
            textBoxHaslo.TabIndex = 174;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(159, 255);
            label10.Name = "label10";
            label10.Size = new Size(255, 35);
            label10.TabIndex = 173;
            label10.Text = "Tymczasowe hasło:";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Anchor = AnchorStyles.None;
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(162, 195);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(252, 38);
            textBoxTytul.TabIndex = 170;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(159, 140);
            label7.Name = "label7";
            label7.Size = new Size(94, 35);
            label7.TabIndex = 169;
            label7.Text = "Login:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(159, 23);
            label6.Name = "label6";
            label6.Size = new Size(976, 58);
            label6.TabIndex = 168;
            label6.Text = "Generuj tymaczasowe hasło dla użytkownika";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(159, 373);
            button2.Name = "button2";
            button2.Size = new Size(201, 61);
            button2.TabIndex = 180;
            button2.Text = "Generuj hasło";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OdzyskiwanieHasloPracownik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            ClientSize = new Size(1441, 673);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonZalogujRej);
            Controls.Add(buttonDodaj);
            Controls.Add(textBoxHaslo);
            Controls.Add(label10);
            Controls.Add(textBoxTytul);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "OdzyskiwanieHasloPracownik";
            Text = "Hasło tymczasowe dla użytkownika";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button buttonZalogujRej;
        private Button buttonDodaj;
        private TextBox textBoxHaslo;
        private Label label10;
        private TextBox textBoxTytul;
        private Label label7;
        private Label label6;
        private Button button2;
    }
}