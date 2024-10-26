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
            SuspendLayout();
            // 
            // buttonDodaj
            // 
            buttonDodaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(419, 525);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(169, 62);
            buttonDodaj.TabIndex = 163;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxIlosc
            // 
            textBoxIlosc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIlosc.Location = new Point(532, 355);
            textBoxIlosc.Name = "textBoxIlosc";
            textBoxIlosc.Size = new Size(179, 38);
            textBoxIlosc.TabIndex = 162;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(427, 358);
            label10.Name = "label10";
            label10.Size = new Size(78, 35);
            label10.TabIndex = 161;
            label10.Text = "Ilość:";
            // 
            // textBoxNrKatalogowy
            // 
            textBoxNrKatalogowy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrKatalogowy.Location = new Point(532, 433);
            textBoxNrKatalogowy.Name = "textBoxNrKatalogowy";
            textBoxNrKatalogowy.Size = new Size(179, 38);
            textBoxNrKatalogowy.TabIndex = 160;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(241, 436);
            label8.Name = "label8";
            label8.Size = new Size(264, 35);
            label8.TabIndex = 159;
            label8.Text = "Numer katalogowy:";
            // 
            // textBoxTytul
            // 
            textBoxTytul.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTytul.Location = new Point(532, 262);
            textBoxTytul.Name = "textBoxTytul";
            textBoxTytul.Size = new Size(179, 38);
            textBoxTytul.TabIndex = 158;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(427, 265);
            label7.Name = "label7";
            label7.Size = new Size(89, 35);
            label7.TabIndex = 157;
            label7.Text = "Tytuł:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(418, 137);
            label6.Name = "label6";
            label6.Size = new Size(372, 58);
            label6.TabIndex = 156;
            label6.Text = "Edytuj produkty";
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(12, 12);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 69);
            buttonZalogujRej.TabIndex = 164;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // buttonUsun
            // 
            buttonUsun.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(607, 525);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(169, 62);
            buttonUsun.TabIndex = 165;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // EdycjaProduktowAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(1182, 753);
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
    }
}