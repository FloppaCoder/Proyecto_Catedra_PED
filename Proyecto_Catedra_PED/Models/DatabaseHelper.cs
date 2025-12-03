using Microsoft.Data.Sqlite; 
using Proyecto_Catedra_PED.Models;
using Proyecto_Catedra_PED.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Proyecto_Catedra_PED
{
    public class DatabaseHelper
    {
        private const string DbName = "ClinicaTurnos.db";
        private static string ConnectionString = $"Data Source={DbName}";

        public static void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS PatientVisits (
                        TurnId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre TEXT NOT NULL,
                        Motivo TEXT NOT NULL,
                        TipoCaso INTEGER NOT NULL,
                        Estado INTEGER NOT NULL,
                        HoraIngreso TEXT NOT NULL,
                        HoraInicioAtencion TEXT,
                        HoraFinAtencion TEXT
                    );";

                using (var command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void SavePatient(PatientVisit visit)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO PatientVisits (Nombre, Motivo, TipoCaso, Estado, HoraIngreso) VALUES (@nom, @mot, @tipo, @est, @ingreso)";

                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nom", visit.Patient.Nombre);
                    command.Parameters.AddWithValue("@mot", visit.Patient.Motivo);
                    command.Parameters.AddWithValue("@tipo", (int)visit.Patient.TipoCaso);
                    command.Parameters.AddWithValue("@est", (int)visit.Estado);
                    command.Parameters.AddWithValue("@ingreso", visit.HoraIngreso.ToString("o"));

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateVisitState(PatientVisit visit)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sql = "UPDATE PatientVisits SET Estado = @est, HoraInicioAtencion = @ini, HoraFinAtencion = @fin WHERE TurnId = @id";

                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@est", (int)visit.Estado);

                    object iniVal = visit.HoraInicioAtencion.HasValue ? visit.HoraInicioAtencion.Value.ToString("o") : DBNull.Value;
                    object finVal = visit.HoraFinAtencion.HasValue ? visit.HoraFinAtencion.Value.ToString("o") : DBNull.Value;

                    command.Parameters.AddWithValue("@ini", iniVal);
                    command.Parameters.AddWithValue("@fin", finVal);
                    command.Parameters.AddWithValue("@id", visit.TurnId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<PatientVisit> LoadPendingVisits()
        {
            var list = new List<PatientVisit>();
            if (!File.Exists(DbName)) return list;

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM PatientVisits WHERE Estado IN (0, 1) ORDER BY HoraIngreso ASC";

                using (var command = new SqliteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var p = new Patient(
                                reader["Nombre"].ToString(),
                                reader["Motivo"].ToString(),
                                (TipoCaso)Convert.ToInt32(reader["TipoCaso"])
                            );

                            var visit = new PatientVisit(Convert.ToInt32(reader["TurnId"]), p);
                            visit.Estado = (EstadoTurno)Convert.ToInt32(reader["Estado"]);
                            visit.HoraIngreso = DateTime.Parse(reader["HoraIngreso"].ToString());

                            if (reader["HoraInicioAtencion"] != DBNull.Value)
                            {
                                visit.HoraInicioAtencion = DateTime.Parse(reader["HoraInicioAtencion"].ToString());
                            }
                            list.Add(visit);
                        }
                    }
                }
            }
            return list;
        }

        public static List<PatientVisit> LoadAttendedVisits()
        {
            var list = new List<PatientVisit>();
            if (!File.Exists(DbName)) return list;

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM PatientVisits WHERE Estado = 2 ORDER BY HoraIngreso ASC";

                using (var command = new SqliteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var p = new Patient(
                                reader["Nombre"].ToString(),
                                reader["Motivo"].ToString(),
                                (TipoCaso)Convert.ToInt32(reader["TipoCaso"])
                            );

                            var visit = new PatientVisit(Convert.ToInt32(reader["TurnId"]), p);
                            visit.Estado = (EstadoTurno)Convert.ToInt32(reader["Estado"]);
                            visit.HoraIngreso = DateTime.Parse(reader["HoraIngreso"].ToString());

                            if (reader["HoraInicioAtencion"] != DBNull.Value)
                            {
                                visit.HoraInicioAtencion = DateTime.Parse(reader["HoraInicioAtencion"].ToString());
                            }
                            list.Add(visit);
                        }
                    }
                }
            }
            return list;
        }
    
        public static void ClearQueues()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                string sql = @"UPDATE PatientVisits 
                       SET Estado = 2, 
                           HoraInicioAtencion = COALESCE(HoraInicioAtencion, @ahora), 
                           HoraFinAtencion = @ahora 
                       WHERE Estado IN (0, 1)";

                using (var command = new SqliteCommand(sql, connection))
                {
                    string horaActual = DateTime.Now.ToString("o");

                    command.Parameters.AddWithValue("@ahora", horaActual);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}