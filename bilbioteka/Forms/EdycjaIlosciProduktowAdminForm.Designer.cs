namespace bilbioteka.Forms
{
    partial class EdycjaProduktowAdminForm
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
            buttonDodaj = new Button();
            textBoxIlosc = new TextBox();
            label10 = new Label();
            textBoxNrKatalogowy = new TextBox();
            label8 = new Label();
            textBoxTytul = new TextBox();
            label7 = new Label();
            label6 = new Label();
            buttonZalogujRej = new Button();
            buttonUsun = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonDodaj
            // 
            buttonDodaj.Anchor = AnchorStyles.None;
            buttonDodaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(179, 297);
            buttonDodaj.Margin = new Padding(3, 2, 3, 2);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(148, 46);
            buttonDodaj.TabIndex = 163;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxIlosc
            // 
            textBoxIlosc.Anchor = AnchorStyles.None;
            textBoxIlosc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIlosc.Location = new Point(242, 167);
            textBoxIlosc.Margin = new Padding(3, 2, 3, 2);
            textBoxIlosc.Name = "textBoxIlosc";
            textBoxIlosc.Size = new Size(164, 32);
            textBoxIlosc.TabIndex = 162;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(174, 172);
            label10.Name = "label10";
            label10.Size = new Size(62, 27);
            label10.TabIndex = 161;
            label10.Text = "Ilość:";
            // 
            // textBoxNrKatalogowy
            // 
            textBoxNrKatalogowy.Anchor = AnchorStyles.None;
            textBoxNrKatalogowy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrKatalogowy.Location = new Point(242, 206);
            textBoxNrKatalogowy.Margin = new Padding(3, 2, 3, 2);
            textBoxNrKatalogowy.Name = "textBoxNrKatalogowy";
            textBoxNrKatalogowy.Size = new Size(164, 32);
            textBoxNrKatalogowy.TabIndex = 160;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(149, 211);
            label8.Name = "label8";
            label8.Size = new Size(87, 27);
            label8.TabIndex = 159;
            label8.Text = "Nr. kat:";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Anchor = AnchorStyles.None;
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(242, 124);
            textBoxTytul.Margin = new Padding(3, 2, 3, 2);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(273, 32);
            textBoxTytul.TabIndex = 158;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(167, 129);
            label7.Name = "label7";
            label7.Size = new Size(69, 27);
            label7.TabIndex = 157;
            label7.Text = "Tytuł:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(381, 44);
            label6.Name = "label6";
            label6.Size = new Size(388, 45);
            label6.TabIndex = 156;
            label6.Text = "Edycja ilości zasobów";
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(10, 9);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(77, 52);
            buttonZalogujRej.TabIndex = 164;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.Anchor = AnchorStyles.None;
            buttonUsun.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(179, 360);
            buttonUsun.Margin = new Padding(3, 2, 3, 2);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(148, 46);
            buttonUsun.TabIndex = 165;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(412, 167);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(661, 349);
            dataGridView1.TabIndex = 166;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(179, 420);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(148, 46);
            button1.TabIndex = 167;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EdycjaProduktowAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1219, 577);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonUsun);
            Controls.Add(buttonZalogujRej);
            Controls.Add(buttonDodaj);
            Controls.Add(textBoxIlosc);
            Controls.Add(label10);
            Controls.Add(textBoxNrKatalogowy);
            Controls.Add(label8);
            Controls.Add(textBoxTytul);
            Controls.Add(label7);
            Controls.Add(label6);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EdycjaProduktowAdminForm";
            Text = "EdycjaProduktowAdminForm";
            Load += EdycjaProduktowAdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDodaj;
        private TextBox textBoxIlosc;
        private Label label10;
        private TextBox textBoxNrKatalogowy;
        private Label label8;
        private TextBox textBoxTytul;
        private Label label7;
        private Label label6;
        private Button buttonZalogujRej;
        private Button buttonUsun;
        private DataGridView dataGridView1;
        private Button button1;
    }
}