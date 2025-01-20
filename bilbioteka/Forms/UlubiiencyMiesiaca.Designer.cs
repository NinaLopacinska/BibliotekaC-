namespace bilbioteka.Forms
{
    partial class UlubiiencyMiesiaca
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
            buttonZalogujRej = new Button();
            dataGridViewPozycja = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPozycja).BeginInit();
            SuspendLayout();
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(12, 11);
            buttonZalogujRej.Margin = new Padding(3, 2, 3, 2);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(88, 74);
            buttonZalogujRej.TabIndex = 187;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // dataGridViewPozycja
            // 
            dataGridViewPozycja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewPozycja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPozycja.Location = new Point(175, 209);
            dataGridViewPozycja.Margin = new Padding(2);
            dataGridViewPozycja.Name = "dataGridViewPozycja";
            dataGridViewPozycja.RowHeadersWidth = 62;
            dataGridViewPozycja.RowTemplate.Height = 33;
            dataGridViewPozycja.Size = new Size(809, 301);
            dataGridViewPozycja.TabIndex = 185;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(427, 40);
            label4.Name = "label4";
            label4.Size = new Size(434, 58);
            label4.TabIndex = 183;
            label4.Text = "Ulubieńcy miesiąca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(175, 134);
            label3.Name = "label3";
            label3.Size = new Size(887, 40);
            label3.TabIndex = 182;
            label3.Text = "Najchętniej wypożczamyni pozycjami w tym miesiącu są:";
            // 
            // UlubiiencyMiesiaca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            ClientSize = new Size(1199, 616);
            Controls.Add(buttonZalogujRej);
            Controls.Add(dataGridViewPozycja);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "UlubiiencyMiesiaca";
            Text = "Ulubieńcy miesiąca";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPozycja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonZalogujRej;
        private DataGridView dataGridViewPozycja;
        private Label label4;
        private Label label3;
    }
}