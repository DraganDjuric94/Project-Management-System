using MySql.Data.MySqlClient;
using ProjectManagementSystem.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dao.mysql
{
    class MySqlIstorijaAktivnostiDao : IstorijaAktivnostiDao<IstorijaAktivnosti>
    {

        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlIstorijaAktivnostiDao Instance { get; }

        static MySqlIstorijaAktivnostiDao()
        {
            Instance = new MySqlIstorijaAktivnostiDao();
        }

        private MySqlIstorijaAktivnostiDao()
        {

        }

        public void Create(IstorijaAktivnosti obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<IstorijaAktivnosti> Read(IstorijaAktivnosti parametar)
        {
            List<IstorijaAktivnosti> istorijaAktivnosti = new List<IstorijaAktivnosti>();

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_istorija_aktivnosti";

                cmd.Parameters.AddWithValue("@istorija_aktivnostiID", parametar.IstorijaAktivnostiID);
                cmd.Parameters["@istorija_aktivnostiID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelinaID", parametar.CjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@opis", parametar.Opis);
                cmd.Parameters["@opis"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum", parametar.Datum);
                cmd.Parameters["@datum"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    istorijaAktivnosti.Add(new IstorijaAktivnosti { IstorijaAktivnostiID = reader.GetInt32(0), CjelinaID = reader.GetInt32(1), Opis = reader.GetString(2), Datum = reader.GetDateTime(3) });
                }

                return istorijaAktivnosti;
            }
        }

        public void Update(IstorijaAktivnosti obj)
        {
            throw new NotImplementedException();
        }
    }
}
