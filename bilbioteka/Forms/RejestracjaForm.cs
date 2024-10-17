using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilbioteka.Forms
{
    public partial class RejestracjaForm : Form
    {
        public RejestracjaForm()
        {
            InitializeComponent();
        }

        private void buttonZalogujRej_Click(object sender, EventArgs e)
        {
            LogowanieForm logowanieForm = new LogowanieForm();
            logowanieForm.ShowDialog();
            this.Close();
        }
    }
}
