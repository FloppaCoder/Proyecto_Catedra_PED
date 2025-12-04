namespace Proyecto_Catedra_PED
{
    partial class HistoryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridViewHistorial = new DataGridView();
            id_paciente = new DataGridViewTextBoxColumn();
            nombre_paciente = new DataGridViewTextBoxColumn();
            motivo_paciente = new DataGridViewTextBoxColumn();
            hora_paciente = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
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
            textBox1.Text = "Historial de Atenciones";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewHistorial);
            groupBox1.Font = new Font("Segoe UI", 16F);
            groupBox1.ForeColor = Color.FromArgb(0, 172, 177);
            groupBox1.Location = new Point(68, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1127, 514);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historial";
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.Columns.AddRange(new DataGridViewColumn[] { id_paciente, nombre_paciente, motivo_paciente, hora_paciente });
            dataGridViewHistorial.Location = new Point(26, 35);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.Size = new Size(1082, 461);
            dataGridViewHistorial.TabIndex = 0;
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
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "HistoryForm";
            Text = "Sistema de Gestion de Turnos - Historial";
            Load += HistoryForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridViewHistorial;
        private DataGridViewTextBoxColumn id_paciente;
        private DataGridViewTextBoxColumn nombre_paciente;
        private DataGridViewTextBoxColumn motivo_paciente;
        private DataGridViewTextBoxColumn hora_paciente;
    }
}
