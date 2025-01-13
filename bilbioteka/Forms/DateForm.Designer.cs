namespace bilbioteka.Forms
{
    partial class DateForm
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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            buttonGenerujRaport = new Button();
            buttonZalogujRej = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 199);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(435, 199);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(265, 27);
            dateTimePicker2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 94);
            label2.Name = "label2";
            label2.Size = new Size(770, 37);
            label2.TabIndex = 2;
            label2.Text = "Wybierz zakres dla którego chcesz wygenerować raport:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 144);
            label1.Name = "label1";
            label1.Size = new Size(67, 37);
            label1.TabIndex = 3;
            label1.Text = "Od:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(494, 144);
            label3.Name = "label3";
            label3.Size = new Size(64, 37);
            label3.TabIndex = 4;
            label3.Text = "Do:";
            // 
            // buttonGenerujRaport
            // 
            buttonGenerujRaport.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerujRaport.Location = new Point(297, 252);
            buttonGenerujRaport.Name = "buttonGenerujRaport";
            buttonGenerujRaport.Size = new Size(206, 66);
            buttonGenerujRaport.TabIndex = 5;
            buttonGenerujRaport.Text = "Generuj raport";
            buttonGenerujRaport.UseVisualStyleBackColor = true;
            buttonGenerujRaport.Click += buttonGenerujRaport_Click;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(12, 12);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(66, 62);
            buttonZalogujRej.TabIndex = 42;
            buttonZalogujRej.Text = "⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // DateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(834, 339);
            Controls.Add(buttonZalogujRej);
            Controls.Add(buttonGenerujRaport);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DateForm";
            Text = "Raport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button buttonGenerujRaport;
        private Button buttonZalogujRej;
    }
}