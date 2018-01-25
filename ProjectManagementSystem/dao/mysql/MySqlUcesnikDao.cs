using MySql.Data.MySqlClient;
using ProjectManagementSystem.dto;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dao.mysql
{
    class MySqlUcesnikDao:UcesnikDao<Ucesnik>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlUcesnikDao Instance { get; }

        static MySqlUcesnikDao()
        {
            Instance = new MySqlUcesnikDao();
        }

        private MySqlUcesnikDao() { }

        public void Create(Ucesnik ucesnik)
        {
            #region Add Ucesnik to DB
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_ucesnik";

                cmd.Parameters.AddWithValue("@ucesnikID", MySqlDbType.Int32);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@ime", ucesnik.Ime);
                cmd.Parameters["@ime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@prezime", ucesnik.Prezime);
                cmd.Parameters["@prezime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@korisnicko_ime", ucesnik.KorisnickoIme);
                cmd.Parameters["@korisnicko_ime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@lozinka", ucesnik.Lozinka);
                cmd.Parameters["@lozinka"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@jmbg", ucesnik.Jmbg);
                cmd.Parameters["@jmbg"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", ucesnik.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();

                ucesnik.UcesnikID = Convert.ToInt32(cmd.Parameters["@ucesnikID"].Value);
            }
            #endregion

            #region Add Ucesnik_Uloga to DB
            InsertIntoUcesnikUloga(ucesnik.UcesnikID.Value, ucesnik.Uloga.UlogaID.Value);
            #endregion
        }

        public List<Ucesnik> Read(Ucesnik ucesnik)
        {
            List<Ucesnik> ucesnici = new List<Ucesnik>();

            #region Read Ucesnik from DB
            using (conn)
            {
			     conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_ucesnik";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnik.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ime", ucesnik.Ime);
                cmd.Parameters["@ime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@prezime", ucesnik.Prezime);
                cmd.Parameters["@prezime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@korisnicko_ime", ucesnik.KorisnickoIme);
                cmd.Parameters["@korisnicko_ime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@lozinka", ucesnik.Lozinka);
                cmd.Parameters["@lozinka"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@jmbg", ucesnik.Jmbg);
                cmd.Parameters["@jmbg"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", ucesnik.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ucesnici.Add(new Ucesnik { UcesnikID = reader.GetInt32(0), Ime = reader.GetString(1), Prezime = reader.GetString(2), KorisnickoIme = reader.GetString(3), Lozinka = reader.GetString(4), Jmbg = reader.GetString(5), Aktivan = reader.GetBoolean(6) });
                }
            }
            #endregion

            #region Read Uloga for every Ucesnik
            foreach (Ucesnik u in ucesnici)
            {
                Int32 ulogaID = ReadAllUlogaIDByUcesnikID(u.UcesnikID.Value)[0];
                 u.Uloga = (MySqlUlogaDao.Instance.Read(new Uloga { UlogaID = ulogaID })[0]);
            }
            #endregion

            return ucesnici;
        }

        public void Update(Ucesnik ucesnik)
        {
            #region Update Ucesnik
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_ucesnik";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnik.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ime", ucesnik.Ime);
                cmd.Parameters["@ime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@prezime", ucesnik.Prezime);
                cmd.Parameters["@prezime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@korisnicko_ime", ucesnik.KorisnickoIme);
                cmd.Parameters["@korisnicko_ime"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@lozinka", ucesnik.Lozinka);
                cmd.Parameters["@lozinka"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@jmbg", ucesnik.Jmbg);
                cmd.Parameters["@jmbg"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", ucesnik.Aktivan);
                cmd.Parameters["@Aktivan"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();
            }
            #endregion

            #region Update Uloga
            UpdateUcesnikUlogaByUcesnikID(ucesnik.UcesnikID.Value, ucesnik.Uloga.UlogaID.Value);
            #endregion
        }

        public void Delete(int ucesnikId)
        {
            Ucesnik ucesnik = Read(new Ucesnik { UcesnikID = ucesnikId })[0];
            ucesnik.Aktivan = false;
            Update(ucesnik);
        }

        private List<Int32> ReadAllUlogaIDByUcesnikID(Int32 ucesnikID)
        {
            List<Int32> ulogeID = new List<Int32>();
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_ucesnik_uloga_by_ucesnikID";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ulogeID.Add(reader.GetInt32(0));
                }

            }
            return ulogeID;
        }

        private void InsertIntoUcesnikUloga(Int32 ucesnikID, Int32 ulogaID)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_ucesnik_uloga";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ulogaId", ulogaID);
                cmd.Parameters["@ulogaId"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateUcesnikUlogaByUcesnikID(Int32 ucesnikID, Int32 ulogaID)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_ucesnik_uloga_by_ucesnikID";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ulogaId", ulogaID);
                cmd.Parameters["@ulogaId"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
