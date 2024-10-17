using bilbioteka.Forms;

namespace bilbioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            LogowanieForm logowanieForm = new LogowanieForm();
            logowanieForm.Show();
            //this.Close();

        }
        private void buttonRejstruj_Click(object sender, EventArgs e)
        {
            RejestracjaForm rejestracjaForm = new RejestracjaForm();
            rejestracjaForm.Show();
            //this.Close();

        }
    }
}