using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Catedra_PED
{
    public partial class QueuesForm : Form
    {
        public QueuesForm()
        {
            InitializeComponent();
        }

        private void QueuesForm_Load(object sender, EventArgs e)
        {
            getInfoTablas();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtenderUrgente_Click(object sender, EventArgs e)
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

        private void btnAtenderGeneral_click(object sender, EventArgs e)
        {
            var turno = TurnManager.Instance.AtenderSiguiente(false);

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


        private void getInfoTablas()
        {
            dataGridViewUrgentes.Rows.Clear();
            dataGridViewGenerales.Rows.Clear();

            foreach (var turno in TurnManager.Instance.ColaUrgencias)
            {
                dataGridViewUrgentes.Rows.Add(
                    turno.TurnId,
                    turno.Patient.Nombre,
                    turno.Patient.Motivo,
                    turno.HoraIngreso.ToString("HH:mm")
                );
            }

            foreach (var turno in TurnManager.Instance.ColaGeneral)
            {
                dataGridViewGenerales.Rows.Add(
                    turno.TurnId,
                    turno.Patient.Nombre,
                    turno.Patient.Motivo,
                    turno.HoraIngreso.ToString("HH:mm")
                );
            }
        }
    }
}
