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
    class MySqlAktivnostDao : AktivnostDao<Aktivnost>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlAktivnostDao Instance { get; }

        static MySqlAktivnostDao()
        {
            Instance = new MySqlAktivnostDao();
        }

        private MySqlAktivnostDao()
        {

        }

        public void Create(Aktivnost aktivnost)
        {
            #region Dodaj aktivnost u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_aktivnost";

                cmd.Parameters.AddWithValue("@aktivnostID", MySqlDbType.Int32);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@cjelinaID", aktivnost.CjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", aktivnost.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@opis", aktivnost.Opis);
                cmd.Parameters["@opis"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", aktivnost.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                aktivnost.AktivnostID = Convert.ToInt32(cmd.Parameters["@aktivnostID"].Value);
            }
            #endregion

            #region Dodaj nove transakcije aktivnosti u bp
            foreach (Transakcija transakcija in aktivnost.Transakcije)
            {
                if(transakcija.TransakcijaID is null)
                {
                    transakcija.AktivnostID = aktivnost.AktivnostID;
                    MySqlTransakcijaDao.Instance.Create(transakcija);
                }
            }
            #endregion

            #region Dodaj nove ucesnike na aktivnosti u bp
            foreach(KeyValuePair<Ucesnik, Int32> pair in aktivnost.UcesniciSaBrojemUtrosenihSati.ToArray())
            {

                if(pair.Key.UcesnikID is null)
                {
                    MySqlUcesnikDao.Instance.Create(pair.Key);
                }

                InsertUcesnikAktivnost(pair.Key.UcesnikID.Value, aktivnost.AktivnostID.Value, pair.Value);
            }
            #endregion
        }

        public List<Aktivnost> Read(Aktivnost aktivnost)
        {
            List<Aktivnost> aktivnosti = new List<Aktivnost>();

            #region Procitaj sve aktivnosti iz bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_aktivnost";

                cmd.Parameters.AddWithValue("@aktivnostID", aktivnost.AktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelinaID", aktivnost.CjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", aktivnost.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@opis", aktivnost.Opis);
                cmd.Parameters["@opis"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", aktivnost.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    aktivnosti.Add(new Aktivnost { AktivnostID = reader.GetInt32(0), CjelinaID = reader.GetInt32(1), Naziv = reader.GetString(2), Opis = reader.GetString(3), Aktivna = reader.GetBoolean(4) });
                }
            }
            #endregion

            #region Procitaj transakcije za svaku aktivnost iz bp
            MySqlTransakcijaDao tInstance = MySqlTransakcijaDao.Instance;

            foreach (Aktivnost a in aktivnosti)
            {
                a.Transakcije = tInstance.Read(new Transakcija { AktivnostID = a.AktivnostID });
            }
            #endregion

            #region Procitaj sve ucesnike za svaku aktivnost iz bp
            foreach(Aktivnost a in aktivnosti)
            {
                foreach (KeyValuePair<Int32, Int32> pair in ReadUcesnikAktivnostByAktivnostID(a.AktivnostID.Value).ToArray())
                {
                    a.UcesniciSaBrojemUtrosenihSati.Add((MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = pair.Key })[0]), pair.Value) ;             
                }
            }
            #endregion

            return aktivnosti;
        }

        public void Update(Aktivnost aktivnost)
        {
            #region Azuriraj aktivnost u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_aktivnost";

                cmd.Parameters.AddWithValue("@aktivnostID", aktivnost.AktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelinaID", aktivnost.CjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", aktivnost.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@opis", aktivnost.Opis);
                cmd.Parameters["@opis"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", aktivnost.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
            #endregion

            #region Azuriraj postojece transakcije za aktivnost, i dodaj nove u bp, ako postoje
            foreach (Transakcija transakcija in aktivnost.Transakcije)
            {
                if(transakcija.TransakcijaID is null)
                {
                    transakcija.AktivnostID = aktivnost.AktivnostID;
                    MySqlTransakcijaDao.Instance.Create(transakcija);
                }
                else
                {
                    MySqlTransakcijaDao.Instance.Update(transakcija);
                }
            }
            #endregion
            Dictionary<Ucesnik, int> stari = Read(new Aktivnost { AktivnostID = aktivnost.AktivnostID})[0].UcesniciSaBrojemUtrosenihSati;
            foreach (KeyValuePair<Ucesnik, Int32> pair in stari.ToArray()) {
                DeleteUcesnikAktivnostByAktivnostID(aktivnost.AktivnostID.Value);
            }

            #region Azuriraj ucesnike na aktivnosti
            foreach (KeyValuePair<Ucesnik, Int32> pair in aktivnost.UcesniciSaBrojemUtrosenihSati.ToArray())
            {
                InsertUcesnikAktivnost(pair.Key.UcesnikID.Value, aktivnost.AktivnostID.Value, pair.Value);
            }
            #endregion
        }

        public void Delete(int aktivnostID)
        {
            Aktivnost aktivnost = Read(new Aktivnost { AktivnostID = aktivnostID })[0];
            aktivnost.Aktivna = false;
            Update(aktivnost);
        }

        private Dictionary<Int32, Int32> ReadUcesnikAktivnostByAktivnostID(Int32 aktivnostID)
        {
            Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_ucesnik_aktivnost";

                cmd.Parameters.AddWithValue("@ucesnikID", null);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivnostID", aktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@utroseno_sati", null);
                cmd.Parameters["@utroseno_sati"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dict.Add(reader.GetInt32(0), reader.GetInt32(2));
                }
            }
            return dict;
        }

        private void InsertUcesnikAktivnost(Int32 ucesnikID, Int32 aktivnostID, Int32 utrosenoSati)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_ucesnik_aktivnost";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivnostID", aktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@utroseno_sati", utrosenoSati);
                cmd.Parameters["@utroseno_sati"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteUcesnikAktivnostByAktivnostID(Int32 aktivnostID)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete_ucesnik_aktivnost";

                cmd.Parameters.AddWithValue("@ucesnikID", null);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivnostID", aktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@utroseno_sati", null);
                cmd.Parameters["@utroseno_sati"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
