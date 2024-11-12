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
            button1.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(218, 432);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(148, 46);
            button1.TabIndex = 179;
            button1.Text = "Odśwież";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(528, 164);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(655, 314);
            dataGridView1.TabIndex = 178;
            // 
            // buttonUsun
            // 
            buttonUsun.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsun.Location = new Point(218, 358);
            buttonUsun.Margin = new Padding(3, 2, 3, 2);
            buttonUsun.Name = "buttonUsun";
            buttonUsun.Size = new Size(148, 46);
            buttonUsun.TabIndex = 177;
            buttonUsun.Text = "Usuń";
            buttonUsun.UseVisualStyleBackColor = true;
            buttonUsun.Click += buttonUsun_Click;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(10, 9);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(77, 52);
            buttonZalogujRej.TabIndex = 176;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // textBoxImie
            // 
            textBoxImie.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(180, 232);
            textBoxImie.Margin = new Padding(3, 2, 3, 2);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(273, 32);
            textBoxImie.TabIndex = 174;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(103, 235);
            label10.Name = "label10";
            label10.Size = new Size(61, 27);
            label10.TabIndex = 173;
            label10.Text = "Imie:";
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwisko.Location = new Point(180, 291);
            textBoxNazwisko.Margin = new Padding(3, 2, 3, 2);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(273, 32);
            textBoxNazwisko.TabIndex = 172;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(43, 293);
            label8.Name = "label8";
            label8.Size = new Size(114, 27);
            label8.TabIndex = 171;
            label8.Text = "Nazwiska:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(180, 163);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(273, 32);
            textBoxLogin.TabIndex = 170;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(88, 165);
            label7.Name = "label7";
            label7.Size = new Size(74, 27);
            label7.TabIndex = 169;
            label7.Text = "Login:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(388, 58);
            label6.Name = "label6";
            label6.Size = new Size(343, 45);
            label6.TabIndex = 168;
            label6.Text = "Usuń użytkownika\r\n";
            // 
            // UsunUzytkownikaPracownikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1209, 602);
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
            Margin = new Padding(3, 2, 3, 2);
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