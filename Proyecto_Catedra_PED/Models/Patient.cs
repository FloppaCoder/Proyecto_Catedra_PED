using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Catedra_PED.Models.Enums;

namespace Proyecto_Catedra_PED.Models
{
    public class Patients
    {
        public string Nombre { get; set; }
        public string Motivo { get; set; }
        public TipoCaso TipoCaso { get; set; }

        // Constructor
        public Patient(string nombre, string motivo, TipoCaso tipoCaso)
        {
            Nombre = nombre;
            Motivo = motivo;
            TipoCaso = tipoCaso;
        }

        // Método GetInfo() como se solicita
        public string GetInfo()
        {
            string tipo = TipoCaso == TipoCaso.Urgente ? "URGENTE" : "REGULAR";
            return $"{Nombre} - {Motivo} ({tipo})";
        }

        // Sobrescribir ToString para mejor visualización
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
