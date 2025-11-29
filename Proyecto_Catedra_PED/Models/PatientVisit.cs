using Proyecto_Catedra_PED.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Catedra_PED.Models
{
    public class PatientVisit
    {
        // Propiedades
        public int TurnId { get; set; }
        public Patient Patient { get; set; }
        public EstadoTurno Estado { get; set; }
        public DateTime HoraIngreso { get; set; }
        public DateTime? HoraInicioAtencion { get; set; }
        public DateTime? HoraFinAtencion { get; set; }

        // Constructor
        public PatientVisit(int turnId, Patient patient)
        {
            TurnId = turnId;
            Patient = patient;
            Estado = EstadoTurno.Pendiente;
            HoraIngreso = DateTime.Now;
            HoraInicioAtencion = null;
            HoraFinAtencion = null;
        }

        // Métodos para cambiar estado
        public void IniciarAtencion()
        {
            Estado = EstadoTurno.EnAtencion;
            HoraInicioAtencion = DateTime.Now;
        }

        public void FinalizarAtencion()
        {
            Estado = EstadoTurno.Atendido;
            HoraFinAtencion = DateTime.Now;
        }

        public void CancelarTurno()
        {
            Estado = EstadoTurno.Cancelado;
        }

        // Calcular tiempo de espera
        public TimeSpan CalcularTiempoEspera()
        {
            if (HoraInicioAtencion.HasValue)
                return HoraInicioAtencion.Value - HoraIngreso;
            return TimeSpan.Zero;
        }

        // Calcular tiempo de atención
        public TimeSpan CalcularTiempoAtencion()
        {
            if (HoraInicioAtencion.HasValue && HoraFinAtencion.HasValue)
                return HoraFinAtencion.Value - HoraInicioAtencion.Value;
            return TimeSpan.Zero;
        }

        // Información completa de la visita
        public string GetInfoCompleta()
        {
            return $"Turno #{TurnId}: {Patient.GetInfo()} - {Estado}";
        }
    }
}
