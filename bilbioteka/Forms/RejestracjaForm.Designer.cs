namespace bilbioteka.Forms
{
    partial class RejestracjaForm
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
            label1 = new Label();
            label2 = new Label();
            buttonZalogujRej = new Button();
            label3 = new Label();
            textBoxImie = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            textBoxPesel = new TextBox();
            textBoxNrLokalu = new TextBox();
            textBoxNrPosesji = new TextBox();
            textBoxUlica = new TextBox();
            textBoxKodPocztowy = new TextBox();
            textBoxHaslo = new TextBox();
            textBoxLogin = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxEmailOpiekuna = new TextBox();
            textBoxNrTelefonuOpiekuna = new TextBox();
            textBoxNazwiskoOpiekuna = new TextBox();
            textBoxImieOpiekuna = new TextBox();
            textBoxNrTelefonu = new TextBox();
            textBoxEmail = new TextBox();
            label19 = new Label();
            label20 = new Label();
            buttonRejstracja = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(447, 40);
            label1.Name = "label1";
            label1.Size = new Size(247, 58);
            label1.TabIndex = 0;
            label1.Text = "Rejestracja";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1011, 9);
            label2.Name = "label2";
            label2.Size = new Size(300, 28);
            label2.TabIndex = 1;
            label2.Text = "Masz już konto? Zaloguj się";
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Anchor = AnchorStyles.None;
            buttonZalogujRej.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(1092, 40);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(159, 45);
            buttonZalogujRej.TabIndex = 2;
            buttonZalogujRej.Text = "Zaloguj się!";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 137);
            label3.Name = "label3";
            label3.Size = new Size(77, 35);
            label3.TabIndex = 3;
            label3.Text = "Imie:";
            // 
            // textBoxImie
            // 
            textBoxImie.Anchor = AnchorStyles.None;
            textBoxImie.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImie.Location = new Point(202, 137);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(310, 38);
            textBoxImie.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(600, 309);
            label4.Name = "label4";
            label4.Size = new Size(170, 35);
            label4.TabIndex = 5;
            label4.Text = "Nr. telefonu:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(600, 394);
            label5.Name = "label5";
            label5.Size = new Size(200, 35);
            label5.TabIndex = 6;
            label5.Text = "Imie opiekuna:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(600, 450);
            label6.Name = "label6";
            label6.Size = new Size(270, 35);
            label6.TabIndex = 7;
            label6.Text = "Nazwisko opiekuna:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(600, 509);
            label7.Name = "label7";
            label7.Size = new Size(286, 35);
            label7.TabIndex = 8;
            label7.Text = "Nr telefonu opiekuna:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(600, 585);
            label8.Name = "label8";
            label8.Size = new Size(217, 35);
            label8.TabIndex = 9;
            label8.Text = "Email opiekuna:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(600, 252);
            label9.Name = "label9";
            label9.Size = new Size(94, 35);
            label9.TabIndex = 10;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(600, 197);
            label10.Name = "label10";
            label10.Size = new Size(213, 35);
            label10.TabIndex = 11;
            label10.Text = "Data urodzenia:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(600, 140);
            label11.Name = "label11";
            label11.Size = new Size(105, 35);
            label11.TabIndex = 12;
            label11.Text = "PESEL:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(119, 585);
            label12.Name = "label12";
            label12.Size = new Size(141, 35);
            label12.TabIndex = 13;
            label12.Text = "Nr lokalu:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(119, 509);
            label13.Name = "label13";
            label13.Size = new Size(147, 35);
            label13.TabIndex = 14;
            label13.Text = "Nr posesji:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(119, 453);
            label14.Name = "label14";
            label14.Size = new Size(86, 35);
            label14.TabIndex = 15;
            label14.Text = "Ulica:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(119, 391);
            label15.Name = "label15";
            label15.Size = new Size(202, 35);
            label15.TabIndex = 16;
            label15.Text = "Kod pocztowy:";
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(119, 306);
            label16.Name = "label16";
            label16.Size = new Size(94, 35);
            label16.TabIndex = 17;
            label16.Text = "Hasło:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(119, 252);
            label17.Name = "label17";
            label17.Size = new Size(94, 35);
            label17.TabIndex = 18;
            label17.Text = "Login:";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.None;
            label18.AutoSize = true;
            label18.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(119, 197);
            label18.Name = "label18";
            label18.Size = new Size(147, 35);
            label18.TabIndex = 19;
            label18.Text = "Nazwisko:";
            // 
            // textBoxPesel
            // 
            textBoxPesel.Anchor = AnchorStyles.None;
            textBoxPesel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesel.Location = new Point(711, 140);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(282, 38);
            textBoxPesel.TabIndex = 20;
            // 
            // textBoxNrLokalu
            // 
            textBoxNrLokalu.Anchor = AnchorStyles.None;
            textBoxNrLokalu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrLokalu.Location = new Point(266, 585);
            textBoxNrLokalu.Name = "textBoxNrLokalu";
            textBoxNrLokalu.Size = new Size(246, 38);
            textBoxNrLokalu.TabIndex = 21;
            // 
            // textBoxNrPosesji
            // 
            textBoxNrPosesji.Anchor = AnchorStyles.None;
            textBoxNrPosesji.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrPosesji.Location = new Point(272, 509);
            textBoxNrPosesji.Name = "textBoxNrPosesji";
            textBoxNrPosesji.Size = new Size(240, 38);
            textBoxNrPosesji.TabIndex = 22;
            // 
            // textBoxUlica
            // 
            textBoxUlica.Anchor = AnchorStyles.None;
            textBoxUlica.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUlica.Location = new Point(211, 450);
            textBoxUlica.Name = "textBoxUlica";
            textBoxUlica.Size = new Size(301, 38);
            textBoxUlica.TabIndex = 23;
            // 
            // textBoxKodPocztowy
            // 
            textBoxKodPocztowy.Anchor = AnchorStyles.None;
            textBoxKodPocztowy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKodPocztowy.Location = new Point(327, 391);
            textBoxKodPocztowy.Name = "textBoxKodPocztowy";
            textBoxKodPocztowy.Size = new Size(185, 38);
            textBoxKodPocztowy.TabIndex = 24;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Anchor = AnchorStyles.None;
            textBoxHaslo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(219, 306);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(293, 38);
            textBoxHaslo.TabIndex = 25;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(219, 249);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(293, 38);
            textBoxLogin.TabIndex = 26;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Anchor = AnchorStyles.None;
            textBoxNazwisko.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwisko.Location = new Point(272, 197);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(240, 38);
            textBoxNazwisko.TabIndex = 27;
            // 
            // textBoxEmailOpiekuna
            // 
            textBoxEmailOpiekuna.Anchor = AnchorStyles.None;
            textBoxEmailOpiekuna.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailOpiekuna.Location = new Point(823, 582);
            textBoxEmailOpiekuna.Name = "textBoxEmailOpiekuna";
            textBoxEmailOpiekuna.Size = new Size(293, 38);
            textBoxEmailOpiekuna.TabIndex = 29;
            // 
            // textBoxNrTelefonuOpiekuna
            // 
            textBoxNrTelefonuOpiekuna.Anchor = AnchorStyles.None;
            textBoxNrTelefonuOpiekuna.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrTelefonuOpiekuna.Location = new Point(892, 509);
            textBoxNrTelefonuOpiekuna.Name = "textBoxNrTelefonuOpiekuna";
            textBoxNrTelefonuOpiekuna.Size = new Size(224, 38);
            textBoxNrTelefonuOpiekuna.TabIndex = 30;
            // 
            // textBoxNazwiskoOpiekuna
            // 
            textBoxNazwiskoOpiekuna.Anchor = AnchorStyles.None;
            textBoxNazwiskoOpiekuna.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNazwiskoOpiekuna.Location = new Point(876, 447);
            textBoxNazwiskoOpiekuna.Name = "textBoxNazwiskoOpiekuna";
            textBoxNazwiskoOpiekuna.Size = new Size(240, 38);
            textBoxNazwiskoOpiekuna.TabIndex = 31;
            // 
            // textBoxImieOpiekuna
            // 
            textBoxImieOpiekuna.Anchor = AnchorStyles.None;
            textBoxImieOpiekuna.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxImieOpiekuna.Location = new Point(806, 394);
            textBoxImieOpiekuna.Name = "textBoxImieOpiekuna";
            textBoxImieOpiekuna.Size = new Size(310, 38);
            textBoxImieOpiekuna.TabIndex = 32;
            // 
            // textBoxNrTelefonu
            // 
            textBoxNrTelefonu.Anchor = AnchorStyles.None;
            textBoxNrTelefonu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNrTelefonu.Location = new Point(776, 309);
            textBoxNrTelefonu.Name = "textBoxNrTelefonu";
            textBoxNrTelefonu.Size = new Size(217, 38);
            textBoxNrTelefonu.TabIndex = 33;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(700, 249);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(293, 38);
            textBoxEmail.TabIndex = 34;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.AutoSize = true;
            label19.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(600, 370);
            label19.Name = "label19";
            label19.Size = new Size(568, 24);
            label19.TabIndex = 35;
            label19.Text = "Osoby poniżej 13 lat podają dane swojego opiekuna prawnego";
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.AutoSize = true;
            label20.Font = new Font("Book Antiqua", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(119, 561);
            label20.Name = "label20";
            label20.Size = new Size(119, 24);
            label20.TabIndex = 36;
            label20.Text = "Opcjonalnie";
            // 
            // buttonRejstracja
            // 
            buttonRejstracja.Anchor = AnchorStyles.None;
            buttonRejstracja.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRejstracja.Location = new Point(505, 692);
            buttonRejstracja.Name = "buttonRejstracja";
            buttonRejstracja.Size = new Size(169, 61);
            buttonRejstracja.TabIndex = 37;
            buttonRejstracja.Text = "Rejestruj";
            buttonRejstracja.UseVisualStyleBackColor = true;
            buttonRejstracja.Click += buttonRejstracja_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(819, 199);
            dateTimePicker1.Margin = new Padding(1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(269, 29);
            dateTimePicker1.TabIndex = 38;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(600, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 273);
            panel1.TabIndex = 39;
            // 
            // button1
            // 
            button1.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(88, 74);
            button1.TabIndex = 192;
            button1.Text = " ⬅";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RejestracjaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1323, 780);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonRejstracja);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNrTelefonu);
            Controls.Add(textBoxImieOpiekuna);
            Controls.Add(textBoxNazwiskoOpiekuna);
            Controls.Add(textBoxNrTelefonuOpiekuna);
            Controls.Add(textBoxEmailOpiekuna);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxLogin);
            Controls.Add(textBoxHaslo);
            Controls.Add(textBoxKodPocztowy);
            Controls.Add(textBoxUlica);
            Controls.Add(textBoxNrPosesji);
            Controls.Add(textBoxNrLokalu);
            Controls.Add(textBoxPesel);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxImie);
            Controls.Add(label3);
            Controls.Add(buttonZalogujRej);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RejestracjaForm";
            Text = "RejestracjaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonZalogujRej;
        private Label label3;
        private TextBox textBoxImie;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBoxPesel;
        private TextBox textBoxNrLokalu;
        private TextBox textBoxNrPosesji;
        private TextBox textBoxUlica;
        private TextBox textBoxKodPocztowy;
        private TextBox textBoxHaslo;
        private TextBox textBoxLogin;
        private TextBox textBoxNazwisko;
        private TextBox textBoxEmailOpiekuna;
        private TextBox textBoxNrTelefonuOpiekuna;
        private TextBox textBoxNazwiskoOpiekuna;
        private TextBox textBoxImieOpiekuna;
        private TextBox textBoxNrTelefonu;
        private TextBox textBoxEmail;
        private Label label19;
        private Label label20;
        private Button buttonRejstracja;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Button button1;
    }
}