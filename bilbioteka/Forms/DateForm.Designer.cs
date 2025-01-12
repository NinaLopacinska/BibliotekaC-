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
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(573, 221);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1020, 47);
            label2.TabIndex = 2;
            label2.Text = "Wybierz zakres dla którego chcesz wygenerować raport:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 47);
            label1.TabIndex = 3;
            label1.Text = "Od:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(646, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 47);
            label3.TabIndex = 4;
            label3.Text = "Do:";
            // 
            // buttonGenerujRaport
            // 
            buttonGenerujRaport.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerujRaport.Location = new Point(371, 292);
            buttonGenerujRaport.Margin = new Padding(4);
            buttonGenerujRaport.Name = "buttonGenerujRaport";
            buttonGenerujRaport.Size = new Size(276, 89);
            buttonGenerujRaport.TabIndex = 5;
            buttonGenerujRaport.Text = "Generuj raport";
            buttonGenerujRaport.UseVisualStyleBackColor = true;
            buttonGenerujRaport.Click += buttonGenerujRaport_Click;
            // 
            // DateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce;
            ClientSize = new Size(1043, 424);
            Controls.Add(buttonGenerujRaport);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Name = "DateForm";
            Text = "DateForm";
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
    }
}