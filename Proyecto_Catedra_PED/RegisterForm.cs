using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class RegisterForm : Form
    {
        public RegisterForm()
        {
            //// Formulario en blanco — sin controles.
            //this.StartPosition = FormStartPosition.CenterParent;
            //this.ClientSize = new Size(400, 300);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            radioButton2 = new RadioButton();
            button3 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 172, 177);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.CausesValidation = false;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.ForeColor = Color.White;
            textBox1.HideSelection = false;
            textBox1.Location = new Point(-10, -2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(800, 29);
            textBox1.TabIndex = 2;
            textBox1.TabStop = false;
            textBox1.Text = "Registrar Nuevo Paciente";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox1.Location = new Point(22, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 240);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Paciente";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(338, 176);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 34);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Regular";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(274, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(442, 29);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(274, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(442, 29);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 176);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 2;
            label3.Text = "Tipo de Caso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 117);
            label2.Name = "label2";
            label2.Size = new Size(207, 30);
            label2.TabIndex = 1;
            label2.Text = "Motivo de Consulta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(532, 176);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 34);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Urgente";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 172, 177);
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(336, 305);
            button3.Name = "button3";
            button3.Size = new Size(203, 44);
            button3.TabIndex = 6;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 172, 177);
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(557, 305);
            button1.Name = "button1";
            button1.Size = new Size(203, 44);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            ClientSize = new Size(784, 361);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "RegisterForm";
            Text = "Sistema de Gestion de Turnos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

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
    }
}