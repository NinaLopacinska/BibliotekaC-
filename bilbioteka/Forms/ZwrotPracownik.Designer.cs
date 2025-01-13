namespace bilbioteka.Forms
{
    partial class ZwrotPracownik
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
            label7 = new Label();
            textBoxTyt = new TextBox();
            textBoxLog = new TextBox();
            label4 = new Label();
            label5 = new Label();
            buttonWydluzTermin = new Button();
            buttonZwroc = new Button();
            buttonOdswiez = new Button();
            dataGridView1 = new DataGridView();
            buttonZalogujRej = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(334, 21);
            label7.Name = "label7";
            label7.Size = new Size(576, 54);
            label7.TabIndex = 189;
            label7.Text = "Zwróć pozycje użytkownika";
            // 
            // textBoxTyt
            // 
            textBoxTyt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTyt.Location = new Point(117, 267);
            textBoxTyt.Name = "textBoxTyt";
            textBoxTyt.Size = new Size(305, 38);
            textBoxTyt.TabIndex = 188;
            // 
            // textBoxLog
            // 
            textBoxLog.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLog.Location = new Point(123, 208);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(297, 38);
            textBoxLog.TabIndex = 187;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(27, 267);
            label4.Name = "label4";
            label4.Size = new Size(83, 36);
            label4.TabIndex = 186;
            label4.Text = "Tytuł";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 208);
            label5.Name = "label5";
            label5.Size = new Size(90, 36);
            label5.TabIndex = 185;
            label5.Text = "Login";
            // 
            // buttonWydluzTermin
            // 
            buttonWydluzTermin.Font = new Font("Book Antiqua", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWydluzTermin.Location = new Point(101, 417);
            buttonWydluzTermin.Name = "buttonWydluzTermin";
            buttonWydluzTermin.Size = new Size(253, 61);
            buttonWydluzTermin.TabIndex = 184;
            buttonWydluzTermin.Text = "Wydłuż termin";
            buttonWydluzTermin.UseVisualStyleBackColor = true;
            buttonWydluzTermin.Click += buttonWydluzTermin_Click_1;
            // 
            // buttonZwroc
            // 
            buttonZwroc.Font = new Font("Book Antiqua", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonZwroc.Location = new Point(101, 341);
            buttonZwroc.Name = "buttonZwroc";
            buttonZwroc.Size = new Size(157, 61);
            buttonZwroc.TabIndex = 183;
            buttonZwroc.Text = "Zwróć";
            buttonZwroc.UseVisualStyleBackColor = true;
            buttonZwroc.Click += buttonZwroc_Click_1;
            // 
            // buttonOdswiez
            // 
            buttonOdswiez.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOdswiez.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOdswiez.Location = new Point(283, 341);
            buttonOdswiez.Name = "buttonOdswiez";
            buttonOdswiez.Size = new Size(70, 61);
            buttonOdswiez.TabIndex = 182;
            buttonOdswiez.Text = "⟲";
            buttonOdswiez.UseVisualStyleBackColor = true;
            buttonOdswiez.Click += buttonOdswiez_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(453, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(842, 447);
            dataGridView1.TabIndex = 181;
            // 
            // buttonZalogujRej
            // 
            buttonZalogujRej.Font = new Font("Book Antiqua", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZalogujRej.Location = new Point(18, 11);
            buttonZalogujRej.Name = "buttonZalogujRej";
            buttonZalogujRej.Size = new Size(91, 67);
            buttonZalogujRej.TabIndex = 190;
            buttonZalogujRej.Text = " ⬅";
            buttonZalogujRej.UseVisualStyleBackColor = true;
            buttonZalogujRej.Click += buttonZalogujRej_Click;
            // 
            // ZwrotPracownik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.stan_czytelnictwa_w_polsce1;
            ClientSize = new Size(1329, 653);
            Controls.Add(buttonZalogujRej);
            Controls.Add(label7);
            Controls.Add(textBoxTyt);
            Controls.Add(textBoxLog);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(buttonWydluzTermin);
            Controls.Add(buttonZwroc);
            Controls.Add(buttonOdswiez);
            Controls.Add(dataGridView1);
            Name = "ZwrotPracownik";
            Text = "Zwroty";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox textBoxTyt;
        private TextBox textBoxLog;
        private Label label4;
        private Label label5;
        private Button buttonWydluzTermin;
        private Button buttonZwroc;
        private Button buttonOdswiez;
        private DataGridView dataGridView1;
        private Button buttonZalogujRej;
    }
}