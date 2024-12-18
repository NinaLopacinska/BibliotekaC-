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
            buttonDodaj = new Button();
            textBoxZaDzien = new TextBox();
            label10 = new Label();
            textBoxNowe = new TextBox();
            label8 = new Label();
            textBoxProdukt = new TextBox();
            label7 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(524, 153);
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
            // buttonDodaj
            // 
            buttonDodaj.Anchor = AnchorStyles.None;
            buttonDodaj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDodaj.Location = new Point(204, 375);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(169, 61);
            buttonDodaj.TabIndex = 199;
            buttonDodaj.Text = "Zapisz";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // textBoxZaDzien
            // 
            textBoxZaDzien.Anchor = AnchorStyles.None;
            textBoxZaDzien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxZaDzien.Location = new Point(310, 221);
            textBoxZaDzien.Name = "textBoxZaDzien";
            textBoxZaDzien.Size = new Size(187, 38);
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
            textBoxNowe.Location = new Point(310, 302);
            textBoxNowe.Name = "textBoxNowe";
            textBoxNowe.Size = new Size(187, 38);
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
            textBoxProdukt.Location = new Point(310, 150);
            textBoxProdukt.Name = "textBoxProdukt";
            textBoxProdukt.Size = new Size(187, 38);
            textBoxProdukt.TabIndex = 194;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(172, 150);
            label7.Name = "label7";
            label7.Size = new Size(117, 35);
            label7.TabIndex = 193;
            label7.Text = "Produkt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(258, 27);
            label4.Name = "label4";
            label4.Size = new Size(394, 58);
            label4.TabIndex = 200;
            label4.Text = "Edytuj cennik kar";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(204, 452);
            button1.Name = "button1";
            button1.Size = new Size(169, 61);
            button1.TabIndex = 201;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EdytujCennikAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            ClientSize = new Size(1008, 547);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(buttonDodaj);
            Controls.Add(textBoxZaDzien);
            Controls.Add(label10);
            Controls.Add(textBoxNowe);
            Controls.Add(label8);
            Controls.Add(textBoxProdukt);
            Controls.Add(label7);
            Controls.Add(buttonZalogujRej);
            Controls.Add(dataGridView1);
            Name = "EdytujCennikAdmin";
            Text = "EdytujCennikAdmin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonZalogujRej;
        private Button buttonDodaj;
        private TextBox textBoxZaDzien;
        private Label label10;
        private TextBox textBoxNowe;
        private Label label8;
        private TextBox textBoxProdukt;
        private Label label7;
        private Label label4;
        private Button button1;
    }
}