using System;
using Proyecto_Catedra_PED.Models.Enums;

namespace Proyecto_Catedra_PED.Models
{
    public class Patient
    {
        public string Nombre { get; set; }
        public string Motivo { get; set; }
        public TipoCaso TipoCaso { get; set; }

        public Patient(string nombre, string motivo, TipoCaso tipoCaso)
        {
            Nombre = nombre;
            Motivo = motivo;
            TipoCaso = tipoCaso;
        }

        public string GetInfo()
        {
            string tipo = TipoCaso == TipoCaso.Urgente ? "URGENTE" : "REGULAR";
            return $"{Nombre} - {Motivo} ({tipo})";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}