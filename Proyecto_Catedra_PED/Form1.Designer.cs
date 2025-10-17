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
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox1.Location = new Point(204, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadisticas";
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
            textBox1.Text = "Gestion de Turnos";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox2.Location = new Point(675, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 328);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestion de Turnos";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 172, 177);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(134, 76);
            button1.Name = "button1";
            button1.Size = new Size(203, 44);
            button1.TabIndex = 2;
            button1.Text = "Registrar Paciente";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sistema de Gestion de Turnos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Button button1;
    }
}
