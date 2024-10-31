namespace bilbioteka.Forms
{
    partial class WypozyczeniePracownikForm
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
            label2 = new Label();
            label3 = new Label();
            buttonWypozycz = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(584, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(307, 47);
            label2.TabIndex = 8;
            label2.Text = "ID użytkownika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(660, 373);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 47);
            label3.TabIndex = 10;
            label3.Text = "Tytuł";
            // 
            // buttonWypozycz
            // 
            buttonWypozycz.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWypozycz.Location = new Point(584, 623);
            buttonWypozycz.Margin = new Padding(4);
            buttonWypozycz.Name = "buttonWypozycz";
            buttonWypozycz.Size = new Size(276, 121);
            buttonWypozycz.TabIndex = 11;
            buttonWypozycz.Text = "Wypożycz";
            buttonWypozycz.UseVisualStyleBackColor = true;
            buttonWypozycz.Click += buttonWypozycz_Click_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(480, 238);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(529, 60);
            textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(480, 477);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(529, 60);
            textBox2.TabIndex = 18;
            // 
            // WypozyczeniePracownikForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1728, 1004);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonWypozycz);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "WypozyczeniePracownikForm";
            Text = "WypozyczeniePracownikForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Button buttonWypozycz;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}