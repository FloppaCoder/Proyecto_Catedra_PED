namespace Proyecto_Catedra_PED
{
    partial class QueuesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridViewUrgentes = new DataGridView();
            id_paciente = new DataGridViewTextBoxColumn();
            nombre_paciente = new DataGridViewTextBoxColumn();
            motivo_paciente = new DataGridViewTextBoxColumn();
            hora_paciente = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dataGridViewGenerales = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            btnAtenderGeneral = new Button();
            btnAtenderUrgente = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrgentes).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenerales).BeginInit();
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
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1280, 29);
            textBox1.TabIndex = 3;
            textBox1.TabStop = false;
            textBox1.Text = "Colas de Atención";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewUrgentes);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox1.Location = new Point(68, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 245);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cola Urgencias";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dataGridViewUrgentes
            // 
            dataGridViewUrgentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUrgentes.Columns.AddRange(new DataGridViewColumn[] { id_paciente, nombre_paciente, motivo_paciente, hora_paciente });
            dataGridViewUrgentes.Location = new Point(26, 35);
            dataGridViewUrgentes.Name = "dataGridViewUrgentes";
            dataGridViewUrgentes.Size = new Size(1082, 192);
            dataGridViewUrgentes.TabIndex = 0;
            // 
            // id_paciente
            // 
            id_paciente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_paciente.HeaderText = "N°";
            id_paciente.Name = "id_paciente";
            // 
            // nombre_paciente
            // 
            nombre_paciente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre_paciente.FillWeight = 200F;
            nombre_paciente.HeaderText = "Nombre Completo";
            nombre_paciente.Name = "nombre_paciente";
            // 
            // motivo_paciente
            // 
            motivo_paciente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            motivo_paciente.HeaderText = "Motivo Visita";
            motivo_paciente.Name = "motivo_paciente";
            // 
            // hora_paciente
            // 
            hora_paciente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hora_paciente.HeaderText = "Hora Registro";
            hora_paciente.Name = "hora_paciente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewGenerales);
            groupBox2.Font = new Font("Segoe UI", 16F);
            groupBox2.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox2.Location = new Point(68, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1127, 245);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cola General";
            // 
            // dataGridViewGenerales
            // 
            dataGridViewGenerales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenerales.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewGenerales.Location = new Point(26, 35);
            dataGridViewGenerales.Name = "dataGridViewGenerales";
            dataGridViewGenerales.Size = new Size(1082, 192);
            dataGridViewGenerales.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "N°";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.FillWeight = 200F;
            dataGridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Motivo Visita";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Hora Registro";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnAtenderGeneral
            // 
            btnAtenderGeneral.BackColor = Color.FromArgb(0, 172, 177);
            btnAtenderGeneral.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            btnAtenderGeneral.FlatAppearance.BorderSize = 0;
            btnAtenderGeneral.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            btnAtenderGeneral.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            btnAtenderGeneral.FlatStyle = FlatStyle.Flat;
            btnAtenderGeneral.Font = new Font("Segoe UI", 14F);
            btnAtenderGeneral.ForeColor = Color.White;
            btnAtenderGeneral.Location = new Point(826, 600);
            btnAtenderGeneral.Name = "btnAtenderGeneral";
            btnAtenderGeneral.Size = new Size(320, 45);
            btnAtenderGeneral.TabIndex = 9;
            btnAtenderGeneral.Text = "Atender Siguiente General";
            btnAtenderGeneral.UseVisualStyleBackColor = false;
            btnAtenderGeneral.Click += btnAtenderGeneral_click;
            // 
            // btnAtenderUrgente
            // 
            btnAtenderUrgente.BackColor = Color.FromArgb(0, 172, 177);
            btnAtenderUrgente.FlatAppearance.BorderColor = Color.FromArgb(0, 172, 177);
            btnAtenderUrgente.FlatAppearance.BorderSize = 0;
            btnAtenderUrgente.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 172, 177);
            btnAtenderUrgente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 172, 177);
            btnAtenderUrgente.FlatStyle = FlatStyle.Flat;
            btnAtenderUrgente.Font = new Font("Segoe UI", 14F);
            btnAtenderUrgente.ForeColor = Color.White;
            btnAtenderUrgente.Location = new Point(137, 600);
            btnAtenderUrgente.Name = "btnAtenderUrgente";
            btnAtenderUrgente.Size = new Size(320, 45);
            btnAtenderUrgente.TabIndex = 8;
            btnAtenderUrgente.Text = "Atender Siguiente Urgente";
            btnAtenderUrgente.UseVisualStyleBackColor = false;
            btnAtenderUrgente.Click += btnAtenderUrgente_Click;
            // 
            // QueuesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnAtenderGeneral);
            Controls.Add(btnAtenderUrgente);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "QueuesForm";
            Text = "Sistema de Gestion de Turnos";
            Load += QueuesForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrgentes).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenerales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAtenderGeneral;
        private Button btnAtenderUrgente;
        private DataGridView dataGridViewUrgentes;
        private DataGridViewTextBoxColumn id_paciente;
        private DataGridViewTextBoxColumn nombre_paciente;
        private DataGridViewTextBoxColumn motivo_paciente;
        private DataGridViewTextBoxColumn hora_paciente;
        private DataGridView dataGridViewGenerales;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}