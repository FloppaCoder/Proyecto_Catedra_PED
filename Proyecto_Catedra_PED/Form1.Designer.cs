namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            TextAtendidos = new TextBox();
            TextUrgentes = new TextBox();
            TextPendientes = new TextBox();
            lblAtendidos = new Label();
            lblUrgentes = new Label();
            lblPendientes = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            btnTerminarConsulta = new Button();
            btnLimpiarColas = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextAtendidos);
            groupBox1.Controls.Add(TextUrgentes);
            groupBox1.Controls.Add(TextPendientes);
            groupBox1.Controls.Add(lblAtendidos);
            groupBox1.Controls.Add(lblUrgentes);
            groupBox1.Controls.Add(lblPendientes);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox1.Location = new Point(204, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadisticas";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // TextAtendidos
            // 
            TextAtendidos.BackColor = SystemColors.Control;
            TextAtendidos.BorderStyle = BorderStyle.None;
            TextAtendidos.Enabled = false;
            TextAtendidos.Location = new Point(173, 152);
            TextAtendidos.Name = "TextAtendidos";
            TextAtendidos.Size = new Size(100, 29);
            TextAtendidos.TabIndex = 5;
            // 
            // TextUrgentes
            // 
            TextUrgentes.BackColor = SystemColors.Control;
            TextUrgentes.BorderStyle = BorderStyle.None;
            TextUrgentes.Enabled = false;
            TextUrgentes.Location = new Point(173, 106);
            TextUrgentes.Name = "TextUrgentes";
            TextUrgentes.Size = new Size(100, 29);
            TextUrgentes.TabIndex = 4;
            // 
            // TextPendientes
            // 
            TextPendientes.BackColor = SystemColors.Control;
            TextPendientes.BorderStyle = BorderStyle.None;
            TextPendientes.Enabled = false;
            TextPendientes.Location = new Point(173, 61);
            TextPendientes.Name = "TextPendientes";
            TextPendientes.Size = new Size(100, 29);
            TextPendientes.TabIndex = 3;
            // 
            // lblAtendidos
            // 
            lblAtendidos.AutoSize = true;
            lblAtendidos.Location = new Point(31, 152);
            lblAtendidos.Name = "lblAtendidos";
            lblAtendidos.Size = new Size(111, 30);
            lblAtendidos.TabIndex = 2;
            lblAtendidos.Text = "Atendidos";
            // 
            // lblUrgentes
            // 
            lblUrgentes.AutoSize = true;
            lblUrgentes.Location = new Point(31, 105);
            lblUrgentes.Name = "lblUrgentes";
            lblUrgentes.Size = new Size(106, 30);
            lblUrgentes.TabIndex = 1;
            lblUrgentes.Text = "Urgentes:";
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Location = new Point(31, 64);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(123, 30);
            lblPendientes.TabIndex = 0;
            lblPendientes.Text = "Pendientes:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 172, 177);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.CausesValidation = false;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.ForeColor = Color.White;
            textBox1.HideSelection = false;
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1264, 29);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "Sistema de Gestion de Turnos";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTerminarConsulta);
            groupBox2.Controls.Add(btnLimpiarColas);
            groupBox2.Controls.Add(button5);
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox2.Location = new Point(675, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion de Turnos";
            // 
            // btnTerminarConsulta
            // 
            btnTerminarConsulta.BackColor = Color.FromArgb(0, 172, 177);
            btnTerminarConsulta.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            btnTerminarConsulta.FlatAppearance.BorderSize = 0;
            btnTerminarConsulta.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            btnTerminarConsulta.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            btnTerminarConsulta.FlatStyle = FlatStyle.Flat;
            btnTerminarConsulta.Font = new Font("Segoe UI", 14F);
            btnTerminarConsulta.ForeColor = Color.White;
            btnTerminarConsulta.Location = new Point(95, 132);
            btnTerminarConsulta.Name = "btnTerminarConsulta";
            btnTerminarConsulta.Size = new Size(203, 44);
            btnTerminarConsulta.TabIndex = 9;
            btnTerminarConsulta.Text = "Terminar Consulta";
            btnTerminarConsulta.UseVisualStyleBackColor = false;
            btnTerminarConsulta.Click += btnTerminarConsulta_Click;
            // 
            // btnLimpiarColas
            // 
            btnLimpiarColas.BackColor = Color.FromArgb(0, 172, 177);
            btnLimpiarColas.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            btnLimpiarColas.FlatAppearance.BorderSize = 0;
            btnLimpiarColas.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            btnLimpiarColas.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            btnLimpiarColas.FlatStyle = FlatStyle.Flat;
            btnLimpiarColas.Font = new Font("Segoe UI", 14F);
            btnLimpiarColas.ForeColor = Color.White;
            btnLimpiarColas.Location = new Point(95, 200);
            btnLimpiarColas.Name = "btnLimpiarColas";
            btnLimpiarColas.Size = new Size(203, 44);
            btnLimpiarColas.TabIndex = 8;
            btnLimpiarColas.Text = "Limpiar Colas";
            btnLimpiarColas.UseVisualStyleBackColor = false;
            btnLimpiarColas.Click += btnLimpiarColas_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 172, 177);
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(95, 64);
            button5.Name = "button5";
            button5.Size = new Size(203, 44);
            button5.TabIndex = 6;
            button5.Text = "Atender Siguiente";
            button5.UseVisualStyleBackColor = false;
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
            button1.Location = new Point(155, 76);
            button1.Name = "button1";
            button1.Size = new Size(203, 44);
            button1.TabIndex = 2;
            button1.Text = "Registrar Paciente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 172, 177);
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(391, 76);
            button2.Name = "button2";
            button2.Size = new Size(203, 44);
            button2.TabIndex = 3;
            button2.Text = "Ver Colas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button3.Location = new Point(911, 76);
            button3.Name = "button3";
            button3.Size = new Size(203, 44);
            button3.TabIndex = 5;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 172, 177);
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(675, 76);
            button4.Name = "button4";
            button4.Size = new Size(203, 44);
            button4.TabIndex = 4;
            button4.Text = "Historial";
            button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sistema de Gestion de Turnos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblAtendidos;
        private Label lblUrgentes;
        private Label lblPendientes;
        private Button button5;
        private Button btnLimpiarColas;
        private TextBox TextAtendidos;
        private TextBox TextUrgentes;
        private TextBox TextPendientes;
        private Button btnTerminarConsulta;
    }
}
