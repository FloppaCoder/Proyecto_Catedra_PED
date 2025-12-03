using System;
using System.Windows.Forms;
using Proyecto_Catedra_PED; // Tu namespace de lógica
using Proyecto_Catedra_PED.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer updateTimer;

        public Form1()
        {
            InitializeComponent();

            ConfigurarTimer();

            this.button3.Click += new EventHandler(btnSalir_Click); 
            this.button4.Click += new EventHandler(btnHistorial_Click); 
            this.button5.Click += new EventHandler(btnAtender_Click); 
            this.btnLimpiarColas.Click += new EventHandler(btnLimpiar_Click);
        }

        // --- CONFIGURACIÓN DEL TIMER ---
        private void ConfigurarTimer()
        {
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 2000; // Actualizar cada 2 segundos
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarEstadisticas();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            ActualizarEstadisticas();
        }

        // --- ACTUALIZACIÓN DE INTERFAZ ---
        private void ActualizarEstadisticas()
        {
            var estado = TurnManager.Instance.ObtenerEstadoActual();
            TextPendientes.Text = estado.Pendientes.ToString();
            TextUrgentes.Text = estado.Urgentes.ToString();
            TextAtendidos.Text = estado.Atendidos.ToString();
        }

        // --- EVENTOS DE BOTONES ---
        private void button1_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
            ActualizarEstadisticas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var queuesForm = new QueuesForm();
            queuesForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            // Si ya creaste HistoryForm, descomenta esto:
            // var historyForm = new HistoryForm();
            // historyForm.Show();
            MessageBox.Show("Aquí se mostrará el historial completo.");
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            var turno = TurnManager.Instance.AtenderSiguiente();

            if (turno != null)
            {
                MessageBox.Show($"LLAMANDO A PACIENTE:\n\nNombre: {turno.Patient.Nombre}\nMotivo: {turno.Patient.Motivo}\nTipo: {turno.Patient.TipoCaso}",
                                "Atención Iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay pacientes en espera.", "Información");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e) { }

        private void btnTerminarConsulta_Click(object sender, EventArgs e)
        {
            TurnManager.Instance.FinalizarTurnoActual();
            MessageBox.Show("Atención finalizada correctamente.");
            ActualizarEstadisticas();
        }

        private void btnLimpiarColas_Click(object sender, EventArgs e)
        {
            DatabaseHelper.ClearQueues();
            TurnManager turnManager = TurnManager.Instance;

            turnManager.ReconstruirColasDesdeBD();
            MessageBox.Show("Colas limpiadas correctamente.");
        }
    }
}