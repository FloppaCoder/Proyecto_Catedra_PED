using Proyecto_Catedra_PED;
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
            var registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var queuesForm = new QueuesForm();
            queuesForm.Show();
        }
    }
}
