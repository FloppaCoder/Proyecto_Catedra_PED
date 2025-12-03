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

            // 1. CONFIGURACIÓN INICIAL
            ConfigurarTimer();

            // 2. CONEXIÓN MANUAL DE BOTONES
            // Como el Designer no tiene los eventos "Click" asignados para estos botones,
            // los asignamos aquí por código.
            this.button3.Click += new EventHandler(btnSalir_Click);      // Botón Salir
            this.button4.Click += new EventHandler(btnHistorial_Click);  // Botón Historial
            this.button5.Click += new EventHandler(btnAtender_Click);    // Botón Atender Siguiente
            this.button7.Click += new EventHandler(btnLimpiar_Click);    // Botón Limpiar/Finalizar
            // this.button6.Click += ... // Pausar (si decides implementarlo)
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
            // Obtenemos los datos del Singleton
            var estado = TurnManager.Instance.ObtenerEstadoActual();

            // Usamos los nombres EXACTOS de tu Form1.Designer.cs (TextPendientes, TextUrgentes, etc.)
            TextPendientes.Text = estado.Pendientes.ToString();
            TextUrgentes.Text = estado.Urgentes.ToString();
            TextAtendidos.Text = estado.Atendidos.ToString();
        }

        // --- EVENTOS DE BOTONES ---

        // Botón 1: Registrar (Ya venía conectado en el Designer)
        private void button1_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog(); // ShowDialog es mejor para registros, bloquea la ventana de atrás
            ActualizarEstadisticas(); // Forzar actualización al cerrar
        }

        // Botón 2: Ver Colas (Ya venía conectado en el Designer)
        private void button2_Click(object sender, EventArgs e)
        {
            var queuesForm = new QueuesForm();
            queuesForm.Show();
        }

        // Botón 3: Salir (Conectado manualmente arriba)
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Botón 4: Historial (Conectado manualmente arriba)
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            // Si ya creaste HistoryForm, descomenta esto:
            // var historyForm = new HistoryForm();
            // historyForm.Show();
            MessageBox.Show("Aquí se mostrará el historial completo.");
        }

        // Botón 5: Atender Siguiente (Conectado manualmente arriba)
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

        // Botón 7: Limpiar Colas / Finalizar Turno (Conectado manualmente arriba)
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Asumimos que este botón finaliza el turno actual
            TurnManager.Instance.FinalizarTurnoActual();
            MessageBox.Show("Atención finalizada correctamente.");
            ActualizarEstadisticas();
        }

        // Eventos vacíos del diseñador (déjalos para evitar errores)
        private void groupBox1_Enter_1(object sender, EventArgs e) { }
    }
}