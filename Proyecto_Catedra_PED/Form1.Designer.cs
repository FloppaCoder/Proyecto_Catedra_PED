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
            lblAtendidos = new Label();
            lblUrgentes = new Label();
            lblPendientes = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            TextUrgentes = new TextBox();
            TextAtendidos = new TextBox();
            TextPendientes = new TextBox();
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
            groupBox1.Location = new Point(233, 260);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(446, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadisticas";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // lblAtendidos
            // 
            lblAtendidos.AutoSize = true;
            lblAtendidos.Location = new Point(35, 203);
            lblAtendidos.Name = "lblAtendidos";
            lblAtendidos.Size = new Size(138, 37);
            lblAtendidos.TabIndex = 2;
            lblAtendidos.Text = "Atendidos";
            // 
            // lblUrgentes
            // 
            lblUrgentes.AutoSize = true;
            lblUrgentes.Location = new Point(35, 140);
            lblUrgentes.Name = "lblUrgentes";
            lblUrgentes.Size = new Size(130, 37);
            lblUrgentes.TabIndex = 1;
            lblUrgentes.Text = "Urgentes:";
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Location = new Point(35, 85);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(152, 37);
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
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1445, 36);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "Sistema de Gestion de Turnos";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox2.Location = new Point(771, 260);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(446, 437);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion de Turnos";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 172, 177);
            button7.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(115, 309);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(232, 59);
            button7.TabIndex = 8;
            button7.Text = "Limpiar Colas";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 172, 177);
            button6.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(115, 195);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(232, 59);
            button6.TabIndex = 7;
            button6.Text = "Pausar Turno";
            button6.UseVisualStyleBackColor = false;
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
            button5.Location = new Point(115, 85);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(232, 59);
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
            button1.Location = new Point(177, 101);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(232, 59);
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
            button2.Location = new Point(447, 101);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(232, 59);
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
            button3.Location = new Point(1041, 101);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(232, 59);
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
            button4.Location = new Point(771, 101);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(232, 59);
            button4.TabIndex = 4;
            button4.Text = "Historial";
            button4.UseVisualStyleBackColor = false;
            // 
            // TextUrgentes
            // 
            TextUrgentes.BackColor = SystemColors.Control;
            TextUrgentes.BorderStyle = BorderStyle.None;
            TextUrgentes.Enabled = false;
            TextUrgentes.Location = new Point(198, 141);
            TextUrgentes.Margin = new Padding(3, 4, 3, 4);
            TextUrgentes.Name = "TextUrgentes";
            TextUrgentes.Size = new Size(114, 36);
            TextUrgentes.TabIndex = 4;
            // 
            // TextAtendidos
            // 
            TextAtendidos.BackColor = SystemColors.Control;
            TextAtendidos.BorderStyle = BorderStyle.None;
            TextAtendidos.Enabled = false;
            TextAtendidos.Location = new Point(198, 203);
            TextAtendidos.Margin = new Padding(3, 4, 3, 4);
            TextAtendidos.Name = "TextAtendidos";
            TextAtendidos.Size = new Size(114, 36);
            TextAtendidos.TabIndex = 5;
            // 
            // TextPendientes
            // 
            TextPendientes.BackColor = SystemColors.Control;
            TextPendientes.BorderStyle = BorderStyle.None;
            TextPendientes.Enabled = false;
            TextPendientes.Location = new Point(198, 81);
            TextPendientes.Margin = new Padding(3, 4, 3, 4);
            TextPendientes.Name = "TextPendientes";
            TextPendientes.Size = new Size(114, 36);
            TextPendientes.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button7;
        private Button button6;
        private TextBox TextAtendidos;
        private TextBox TextUrgentes;
        private TextBox TextPendientes;
    }
}
