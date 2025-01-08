namespace bilbioteka.Forms
{
    partial class EdytujCennikAdmin
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
            buttonEdytuj = new Button();
            textBoxZaDzien = new TextBox();
            label10 = new Label();
            textBoxNowe = new TextBox();
            label8 = new Label();
            textBoxProdukt = new TextBox();
            label7 = new Label();
            label4 = new Label();
            buttonOdswiez = new Button();
            label1 = new Label();
            buttonDodaj = new Button();
            buttonUsun = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(548, 153);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(414, 187);
            dataGridView1.TabIndex = 191;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(12, 11);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 74);
            buttonZalogujRej.TabIndex = 192;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click_1;
            // 
            // buttonEdytuj
            // 
            buttonEdytuj.Anchor = AnchorStyles.None;
            buttonEdytuj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytuj.Location = new Point(295, 367);
            buttonEdytuj.Name = "buttonEdytuj";
            buttonEdytuj.Size = new Size(214, 61);
            buttonEdytuj.TabIndex = 199;
            buttonEdytuj.Text = "Zapisz zmiany";
            buttonEdytuj.UseVisualStyleBackColor = true;
            buttonEdytuj.Click += buttonDodaj_Click;
            // 
            // textBoxZaDzien
            // 
            textBoxZaDzien.Anchor = AnchorStyles.None;
            textBoxZaDzien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxZaDzien.Location = new Point(295, 221);
            textBoxZaDzien.Name = "textBoxZaDzien";
            textBoxZaDzien.Size = new Size(214, 38);
            textBoxZaDzien.TabIndex = 198;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(101, 224);
            label10.Name = "label10";
            label10.Size = new Size(188, 35);
            label10.TabIndex = 197;
            label10.Text = "Cena za dzień";
            // 
            // textBoxNowe
            // 
            textBoxNowe.Anchor = AnchorStyles.None;
            textBoxNowe.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNowe.Location = new Point(295, 302);
            textBoxNowe.Name = "textBoxNowe";
            textBoxNowe.Size = new Size(214, 38);
            textBoxNowe.TabIndex = 196;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(49, 302);
            label8.Name = "label8";
            label8.Size = new Size(240, 35);
            label8.TabIndex = 195;
            label8.Text = "Cena za zgubienie";
            // 
            // textBoxProdukt
            // 
            textBoxProdukt.Anchor = AnchorStyles.None;
            textBoxProdukt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProdukt.Location = new Point(295, 150);
            textBoxProdukt.Name = "textBoxProdukt";
            textBoxProdukt.Size = new Size(214, 38);
            textBoxProdukt.TabIndex = 194;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(154, 150);
            label7.Name = "label7";
            label7.Size = new Size(135, 35);
            label7.TabIndex = 193;
            label7.Text = "Kategoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(246, 19);
            label4.Name = "label4";
            label4.Size = new Size(394, 58);
            label4.TabIndex = 200;
            label4.Text = "Edytuj cennik kar";
            // 
            // buttonOdswiez
            // 
            buttonOdswiez.Anchor = AnchorStyles.None;
            buttonOdswiez.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOdswiez.Location = new Point(295, 446);
            buttonOdswiez.Name = "buttonOdswiez";
            buttonOdswiez.Size = new Size(214, 62);
            buttonOdswiez.TabIndex = 201;
            buttonOdswiez.Text = "Odśwież";
            buttonOdswiez.UseVisualStyleBackColor = true;
            buttonOdswiez.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 98);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 202;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Anchor = AnchorStyles.None;
            buttonDodaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(101, 367);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(188, 61);
            buttonDodaj.TabIndex = 203;
            buttonDodaj.Text = "Dodaj nową";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click_1;
            // 
            // buttonUsun
            // 
            buttonUsun.Anchor = AnchorStyles.None;
            buttonUsun.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(101, 446);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(188, 62);
            buttonUsun.TabIndex = 204;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // EdytujCennikAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            ClientSize = new Size(1008, 547);
            Controls.Add(buttonUsun);
            Controls.Add(buttonDodaj);
            Controls.Add(label1);
            Controls.Add(buttonOdswiez);
            Controls.Add(label4);
            Controls.Add(buttonEdytuj);
            Controls.Add(textBoxZaDzien);
            Controls.Add(label10);
            Controls.Add(textBoxNowe);
            Controls.Add(label8);
            Controls.Add(textBoxProdukt);
            Controls.Add(label7);
            Controls.Add(buttonZalogujRej);
            Controls.Add(dataGridView1);
            Name = "EdytujCennikAdmin";
            Text = "Edycja cennika";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonZalogujRej;
        private Button buttonEdytuj;
        private TextBox textBoxZaDzien;
        private Label label10;
        private TextBox textBoxNowe;
        private Label label8;
        private TextBox textBoxProdukt;
        private Label label7;
        private Label label4;
        private Button buttonOdswiez;
        private Label label1;
        private Button buttonDodaj;
        private Button buttonUsun;
    }
}