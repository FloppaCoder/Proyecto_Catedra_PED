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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            dataGridViewHistorial.Rows.Clear();

            foreach (var turno in TurnManager.Instance.Historial)
            {
                dataGridViewHistorial.Rows.Add(
                    turno.TurnId,
                    turno.Patient.Nombre,
                    turno.Patient.Motivo,
                    turno.HoraIngreso.ToString("HH:mm")
                );
            }
        }
    }
}
