namespace bilbioteka.Forms
{
    partial class MainAdminstratorForm
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
            buttonEdycjaZbioru = new Button();
            buttonWyloguj = new Button();
            buttonGenerujRaport = new Button();
            buttonEdytujPracownika = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(333, 40);
            label2.TabIndex = 1;
            label2.Text = "Witaj Admnisratorze";
            // 
            // buttonEdycjaZbioru
            // 
            buttonEdycjaZbioru.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdycjaZbioru.Location = new Point(314, 198);
            buttonEdycjaZbioru.Name = "buttonEdycjaZbioru";
            buttonEdycjaZbioru.Size = new Size(221, 97);
            buttonEdycjaZbioru.TabIndex = 2;
            buttonEdycjaZbioru.Text = "Edytuj zbiór";
            buttonEdycjaZbioru.UseVisualStyleBackColor = true;
            // 
            // buttonWyloguj
            // 
            buttonWyloguj.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWyloguj.Location = new Point(566, 335);
            buttonWyloguj.Name = "buttonWyloguj";
            buttonWyloguj.Size = new Size(221, 97);
            buttonWyloguj.TabIndex = 3;
            buttonWyloguj.Text = "Wyloguj";
            buttonWyloguj.UseVisualStyleBackColor = true;
            buttonWyloguj.Click += buttonWyloguj_Click;
            // 
            // buttonGenerujRaport
            // 
            buttonGenerujRaport.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerujRaport.Location = new Point(314, 335);
            buttonGenerujRaport.Name = "buttonGenerujRaport";
            buttonGenerujRaport.Size = new Size(221, 97);
            buttonGenerujRaport.TabIndex = 4;
            buttonGenerujRaport.Text = "Generuj raport";
            buttonGenerujRaport.UseVisualStyleBackColor = true;
            // 
            // buttonEdytujPracownika
            // 
            buttonEdytujPracownika.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdytujPracownika.Location = new Point(566, 198);
            buttonEdytujPracownika.Name = "buttonEdytujPracownika";
            buttonEdytujPracownika.Size = new Size(221, 97);
            buttonEdytujPracownika.TabIndex = 5;
            buttonEdytujPracownika.Text = "Edytuj pracownika";
            buttonEdytujPracownika.UseVisualStyleBackColor = true;
            // 
            // MainAdminstratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(buttonEdytujPracownika);
            Controls.Add(buttonGenerujRaport);
            Controls.Add(buttonWyloguj);
            Controls.Add(buttonEdycjaZbioru);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainAdminstratorForm";
            Text = "MainAdminstratorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonEdycjaZbioru;
        private Button buttonWyloguj;
        private Button buttonGenerujRaport;
        private Button buttonEdytujPracownika;
    }
}