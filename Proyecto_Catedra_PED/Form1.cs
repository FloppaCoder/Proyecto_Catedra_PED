using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abrir el formulario RegisterForm (en blanco)
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
