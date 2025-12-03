#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_Catedra_PED.Models;
using Proyecto_Catedra_PED.Models.Enums;

namespace Proyecto_Catedra_PED
{
    public class TurnManager
    {
        private static TurnManager _instance;
        private static readonly object _lock = new object();

        public Queue<PatientVisit> ColaGeneral { get; private set; }
        public Queue<PatientVisit> ColaUrgencias { get; private set; }
        public List<PatientVisit> Historial { get; private set; }
        public PatientVisit TurnoEnAtencion { get; private set; }
        private int _contadorTurnos = 1;

        private TurnManager()
        {
            ColaGeneral = new Queue<PatientVisit>();
            ColaUrgencias = new Queue<PatientVisit>();
            Historial = new List<PatientVisit>();

            DatabaseHelper.InitializeDatabase();
            //ReconstruirColasDesdeBD();
        }

        public static TurnManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new TurnManager();
                    return _instance;
                }
            }
        }

        public void RegistrarPaciente(Patient paciente)
        {
            lock (_lock)
            {
                var nuevoTurno = new PatientVisit(_contadorTurnos++, paciente);

                DatabaseHelper.SavePatient(nuevoTurno);

                if (paciente.TipoCaso == TipoCaso.Urgente)
                    ColaUrgencias.Enqueue(nuevoTurno);
                else
                    ColaGeneral.Enqueue(nuevoTurno);
            }
        }

        public PatientVisit AtenderSiguiente()
        {
            lock (_lock)
            {
                if (TurnoEnAtencion != null) return TurnoEnAtencion;

                PatientVisit siguiente = null;

                if (ColaUrgencias.Count > 0)
                    siguiente = ColaUrgencias.Dequeue();
                else if (ColaGeneral.Count > 0)
                    siguiente = ColaGeneral.Dequeue();

                if (siguiente != null)
                {
                    siguiente.IniciarAtencion();
                    TurnoEnAtencion = siguiente;
                    DatabaseHelper.UpdateVisitState(siguiente);
                }
                return siguiente;
            }
        }

        public void FinalizarTurnoActual()
        {
            lock (_lock)
            {
                if (TurnoEnAtencion != null)
                {
                    TurnoEnAtencion.FinalizarAtencion();
                    Historial.Add(TurnoEnAtencion);
                    DatabaseHelper.UpdateVisitState(TurnoEnAtencion);
                    TurnoEnAtencion = null;
                }
            }
        }

        public (int Pendientes, int Urgentes, int Atendidos) ObtenerEstadoActual()
        {
            lock (_lock)
            {
                return (ColaGeneral.Count, ColaUrgencias.Count, Historial.Count);
            }
        }
    }
}