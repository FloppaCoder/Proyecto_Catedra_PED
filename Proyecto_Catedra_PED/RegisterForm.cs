#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_Catedra_PED.Models;
using Proyecto_Catedra_PED.Models.Enums;
using Proyecto_Catedra_PED; // Para TurnManager

namespace WinFormsApp1
{
    public class RegisterForm : Form
    {
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton radioButton1;
        private TextBox textBox3;
        private RadioButton radioButton2;
        private Button button3;
        private Button button1;
        private TextBox textBox2;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            button3 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 172, 177);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Registrar Nuevo Paciente";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(20, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 240);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 50);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 23);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Motivo:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(400, 23);
            textBox3.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.Checked = true;
            radioButton1.Location = new Point(200, 150);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Regular";
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(310, 150);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Urgente";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(300, 310);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 1;
            button3.Text = "Salir";
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(500, 310);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.Click += button1_Click;
            // 
            // RegisterForm
            // 
            ClientSize = new Size(800, 400);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "RegisterForm";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void RegisterForm_Load(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) return;

            string nombre = textBox2.Text;
            string motivo = textBox3.Text;
            TipoCaso tipo = radioButton2.Checked ? TipoCaso.Urgente : TipoCaso.Regular;

            Patient paciente = new Patient(nombre, motivo, tipo);
            TurnManager.Instance.RegistrarPaciente(paciente);

            MessageBox.Show("Registrado");
            this.Close();
        }
    }
}