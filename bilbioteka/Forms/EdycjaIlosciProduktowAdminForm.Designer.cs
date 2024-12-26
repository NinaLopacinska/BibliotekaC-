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
            buttonDodaj.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(155, 392);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(169, 61);
            buttonDodaj.TabIndex = 163;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxIlosc
            // 
            textBoxIlosc.Anchor = AnchorStyles.None;
            textBoxIlosc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIlosc.Location = new Point(122, 223);
            textBoxIlosc.Name = "textBoxIlosc";
            textBoxIlosc.Size = new Size(322, 38);
            textBoxIlosc.TabIndex = 162;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(38, 226);
            label10.Name = "label10";
            label10.Size = new Size(78, 35);
            label10.TabIndex = 161;
            label10.Text = "Ilość:";
            // 
            // textBoxNrKatalogowy
            // 
            textBoxNrKatalogowy.Anchor = AnchorStyles.None;
            textBoxNrKatalogowy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrKatalogowy.Location = new Point(260, 285);
            textBoxNrKatalogowy.Name = "textBoxNrKatalogowy";
            textBoxNrKatalogowy.Size = new Size(184, 38);
            textBoxNrKatalogowy.TabIndex = 160;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(38, 288);
            label8.Name = "label8";
            label8.Size = new Size(216, 35);
            label8.TabIndex = 159;
            label8.Text = "Nr. katalogowy:";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Anchor = AnchorStyles.None;
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(133, 168);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(311, 38);
            textBoxTytul.TabIndex = 158;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(38, 168);
            label7.Name = "label7";
            label7.Size = new Size(89, 35);
            label7.TabIndex = 157;
            label7.Text = "Tytuł:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(422, 23);
            label6.Name = "label6";
            label6.Size = new Size(551, 67);
            label6.TabIndex = 156;
            label6.Text = "Edycja ilości zasobów";
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(11, 12);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 69);
            buttonZalogujRej.TabIndex = 164;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.Anchor = AnchorStyles.None;
            buttonUsun.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(155, 476);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(169, 61);
            buttonUsun.TabIndex = 165;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(496, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(755, 465);
            dataGridView1.TabIndex = 166;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(155, 556);
            button1.Name = "button1";
            button1.Size = new Size(169, 61);
            button1.TabIndex = 167;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EdycjaProduktowAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1393, 769);
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