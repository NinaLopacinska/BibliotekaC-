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
    public partial class MainPracownikForm : Form
    {
        public MainPracownikForm(string imie)
        {
            InitializeComponent();
            label1.Text = imie;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zostałeś pomyślnie wylogowany. Do zobaczenia!");
            
            this.Close();
            
        }
    }
}
