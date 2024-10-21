namespace bilbioteka.Forms
{
    partial class LogowanieForm
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
            buttonRejestrujLog = new Button();
            buttonZaloguj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxLogin = new TextBox();
            textBoxHaslo = new TextBox();
            SuspendLayout();
            // 
            // buttonRejestrujLog
            // 
            buttonRejestrujLog.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRejestrujLog.Location = new Point(34, 84);
            buttonRejestrujLog.Name = "buttonRejestrujLog";
            buttonRejestrujLog.Size = new Size(192, 64);
            buttonRejestrujLog.TabIndex = 0;
            buttonRejestrujLog.Text = "Rejestruj";
            buttonRejestrujLog.UseVisualStyleBackColor = true;
            buttonRejestrujLog.Click += buttonRejestrujLog_Click;
            // 
            // buttonZaloguj
            // 
            buttonZaloguj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZaloguj.Location = new Point(481, 483);
            buttonZaloguj.Name = "buttonZaloguj";
            buttonZaloguj.Size = new Size(192, 64);
            buttonZaloguj.TabIndex = 1;
            buttonZaloguj.Text = "Zaloguj";
            buttonZaloguj.UseVisualStyleBackColor = true;
            buttonZaloguj.Click += buttonZaloguj_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 326);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 2;
            label1.Text = "Podaj login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 26);
            label2.Name = "label2";
            label2.Size = new Size(478, 35);
            label2.TabIndex = 3;
            label2.Text = "Jeśli nie posiadasz konta zarejstruj się";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(343, 391);
            label3.Name = "label3";
            label3.Size = new Size(201, 40);
            label3.TabIndex = 4;
            label3.Text = "Podaj hasło:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(455, 238);
            label4.Name = "label4";
            label4.Size = new Size(236, 54);
            label4.TabIndex = 5;
            label4.Text = "Zaloguj się";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(552, 326);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(198, 43);
            textBoxLogin.TabIndex = 6;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(552, 391);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(198, 43);
            textBoxHaslo.TabIndex = 7;
            // 
            // LogowanieForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(1182, 753);
            Controls.Add(textBoxHaslo);
            Controls.Add(textBoxLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonZaloguj);
            Controls.Add(buttonRejestrujLog);
            Name = "LogowanieForm";
            Text = "LogowanieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonRejestrujLog;
        private Button buttonZaloguj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxLogin;
        private TextBox textBoxHaslo;
    }
}