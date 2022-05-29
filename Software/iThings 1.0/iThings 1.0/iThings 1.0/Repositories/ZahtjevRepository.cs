using DBLayer;
using iThings_1._0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iThings_1._0.Repositories
{
    public class ZahtjevRepository
    {
        public static Zahtjev GetZahtjev(int id)
        {
            Zahtjev zahtjev = null;
            string sql = $"SELECT * FROM Zahtjev WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zahtjev;
        }

        public static List<Zahtjev> GetZahtjevi()
        {
            var zahtjevi = new List<Zahtjev>();
            string sql = "SELECT * FROM Zahtjev";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }
            reader.Close();
            DB.CloseConnection();
            return zahtjevi;
        }

        private static Zahtjev CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string podnositelj = reader["Podnositelj"].ToString();
            string status = reader["Status"].ToString();
            string datumPodnosenja = reader["DatumPodnosenja"].ToString();
            string naziv = reader["Naziv"].ToString();
            int kolicina = int.Parse(reader["Kolicina"].ToString());
            var zahtjev = new Zahtjev
            {
                Id = id,
                Podnositelj = podnositelj,
                Status = status,
                DatumPodnosenja = datumPodnosenja,
                Naziv = naziv,
                Kolicina = kolicina
            };
            return zahtjev;

        }

        public static void InsertIntoZahtjev(int id, string podnositelj, string status, string datumPodnosenja, string naziv, int kolicina)
        {
            string sql = $"INSERT INTO Zahtjev (Id, Podnositelj, Status, DatumPodnosenja, Naziv, Kolicina) VALUES('{id}', '{podnositelj}','{status}','{datumPodnosenja}', '{naziv}', '{kolicina}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteFromZahtjev(int id)
        {
            string sql = $"DELETE Zahtjev WHERE Id = '{id}' ";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateFromZahtjev (Zahtjev zahtjev, string podnositelj, string status, string datumPodnosenja, string naziv, int kolicina)
        {
            string sql = $"UPDATE Zahtjev SET Podnositelj = {podnositelj}, Status = {status}, DatumPodnosenja = {datumPodnosenja}, Naziv = {naziv}, Kolicina = {kolicina} WHERE Id = {zahtjev.Id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }


    }
}
