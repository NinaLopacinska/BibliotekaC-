namespace bilbioteka.Forms
{
    partial class UsunUzytkownikaPracownikForm
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            buttonUsun = new Button();
            buttonZalogujRej = new Button();
            textBoxImie = new TextBox();
            label10 = new Label();
            textBoxNazwisko = new TextBox();
            label8 = new Label();
            textBoxLogin = new TextBox();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(879, 188);
            button1.Name = "button1";
            button1.Size = new Size(169, 61);
            button1.TabIndex = 179;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1034, 327);
            dataGridView1.TabIndex = 178;
            // 
            // buttonUsun
            // 
            buttonUsun.Anchor = AnchorStyles.None;
            buttonUsun.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(703, 188);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(169, 61);
            buttonUsun.TabIndex = 177;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Anchor = AnchorStyles.None;
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(10, 19);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 69);
            buttonZalogujRej.TabIndex = 176;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // textBoxImie
            // 
            textBoxImie.Anchor = AnchorStyles.None;
            textBoxImie.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(90, 155);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(366, 38);
            textBoxImie.TabIndex = 174;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(14, 161);
            label10.Name = "label10";
            label10.Size = new Size(77, 35);
            label10.TabIndex = 173;
            label10.Text = "Imie:";
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Anchor = AnchorStyles.None;
            textBoxNazwisko.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwisko.Location = new Point(152, 207);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(305, 38);
            textBoxNazwisko.TabIndex = 172;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 213);
            label8.Name = "label8";
            label8.Size = new Size(147, 35);
            label8.TabIndex = 171;
            label8.Text = "Nazwisko:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(105, 104);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(351, 38);
            textBoxLogin.TabIndex = 170;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 111);
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
            label6.Location = new Point(105, 24);
            label6.Name = "label6";
            label6.Size = new Size(424, 58);
            label6.TabIndex = 168;
            label6.Text = "Usuń użytkownika\r\n";
            // 
            // UsunUzytkownikaPracownikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1072, 709);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonUsun);
            Controls.Add(buttonZalogujRej);
            Controls.Add(textBoxImie);
            Controls.Add(label10);
            Controls.Add(textBoxNazwisko);
            Controls.Add(label8);
            Controls.Add(textBoxLogin);
            Controls.Add(label7);
            Controls.Add(label6);
            Name = "UsunUzytkownikaPracownikForm";
            Text = "UsunUzytkownikaPracownik";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button buttonUsun;
        private Button buttonZalogujRej;
        private TextBox textBoxImie;
        private Label label10;
        private TextBox textBoxNazwisko;
        private Label label8;
        private TextBox textBoxLogin;
        private Label label7;
        private Label label6;
    }
}