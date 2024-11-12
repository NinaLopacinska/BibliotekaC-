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
            buttonRejestrujLog.Location = new Point(30, 63);
            buttonRejestrujLog.Margin = new Padding(3, 2, 3, 2);
            buttonRejestrujLog.Name = "buttonRejestrujLog";
            buttonRejestrujLog.Size = new Size(168, 48);
            buttonRejestrujLog.TabIndex = 0;
            buttonRejestrujLog.Text = "Rejestruj";
            buttonRejestrujLog.UseVisualStyleBackColor = true;
            buttonRejestrujLog.Click += buttonRejestrujLog_Click;
            // 
            // buttonZaloguj
            // 
            buttonZaloguj.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZaloguj.Location = new Point(421, 362);
            buttonZaloguj.Margin = new Padding(3, 2, 3, 2);
            buttonZaloguj.Name = "buttonZaloguj";
            buttonZaloguj.Size = new Size(168, 48);
            buttonZaloguj.TabIndex = 1;
            buttonZaloguj.Text = "Zaloguj";
            buttonZaloguj.UseVisualStyleBackColor = true;
            buttonZaloguj.Click += buttonZaloguj_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 244);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 2;
            label1.Text = "Podaj login:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 20);
            label2.Name = "label2";
            label2.Size = new Size(377, 27);
            label2.TabIndex = 3;
            label2.Text = "Jeśli nie posiadasz konta zarejstruj się";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(300, 293);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 4;
            label3.Text = "Podaj hasło:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(398, 178);
            label4.Name = "label4";
            label4.Size = new Size(187, 41);
            label4.TabIndex = 5;
            label4.Text = "Zaloguj się";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(483, 244);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(174, 36);
            textBoxLogin.TabIndex = 6;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(483, 293);
            textBoxHaslo.Margin = new Padding(3, 2, 3, 2);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(174, 36);
            textBoxHaslo.TabIndex = 7;
            // 
            // LogowanieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1034, 565);
            Controls.Add(textBoxHaslo);
            Controls.Add(textBoxLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonZaloguj);
            Controls.Add(buttonRejestrujLog);
            Margin = new Padding(3, 2, 3, 2);
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