using MySql.Data.MySqlClient;
using ProjectManagementSystem.org.unibl.etf.model.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.org.unibl.etf.model.dao.mysql
{
    class MySqlTransakcijaDao : TransakcijaDao<Transakcija>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlTransakcijaDao Instance { get; }

        static MySqlTransakcijaDao()
        {
            Instance = new MySqlTransakcijaDao();
        }

        public void Create(Transakcija transakcija)
        {
            #region Unesi transakciju u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_transakcija";

                cmd.Parameters.AddWithValue("@transakcijaID", MySqlDbType.Int32);
                cmd.Parameters["@transakcijaID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@aktivnostID", transakcija.AktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@prihod_rashod", transakcija.PrihodRashod);
                cmd.Parameters["@prihod_rashod"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@iznos", transakcija.Iznos);
                cmd.Parameters["@iznos"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", transakcija.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@opis", transakcija.Opis);
                cmd.Parameters["@opis"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                transakcija.TransakcijaID = (Int32)cmd.Parameters["@transakcijaID"].Value;
            }
            #endregion
        }

        public void Delete(int transakcijaID)
        {
            /*
             * Transakcije se ne brisu iz sistema
             */
        }

        public List<Transakcija> Read(Transakcija transakcija)
        {
            List<Transakcija> transakcije = new List<Transakcija>();
            #region Procitaj transakciju iz bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_transakcija";

                cmd.Parameters.AddWithValue("@transakcijaID", transakcija.TransakcijaID);
                cmd.Parameters["@transakcijaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivnostID", transakcija.AktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@prihod_rashod", transakcija.PrihodRashod);
                cmd.Parameters["@prihod_rashod"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@iznos", transakcija.Iznos);
                cmd.Parameters["@iznos"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", transakcija.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@opis", transakcija.Opis);
                cmd.Parameters["@opis"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    transakcije.Add(new Transakcija { TransakcijaID = reader.GetInt32(0), AktivnostID = reader.GetInt32(1), PrihodRashod = reader.GetBoolean(2), Iznos = reader.GetDecimal(3), DatumVrijeme = reader.GetDateTime(4), Opis = reader.GetString(5) });
                }
            }
            #endregion

            return transakcije;
        }

        public void Update(Transakcija transakcija)
        {
            #region Azuriraj transakciju u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_transakcija";

                cmd.Parameters.AddWithValue("@transakcijaID", transakcija.TransakcijaID);
                cmd.Parameters["@transakcijaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivnostID", transakcija.AktivnostID);
                cmd.Parameters["@aktivnostID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@prihod_rashod", transakcija.PrihodRashod);
                cmd.Parameters["@prihod_rashod"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@iznos", transakcija.Iznos);
                cmd.Parameters["@iznos"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", transakcija.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@opis", transakcija.Opis);
                cmd.Parameters["@opis"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
            #endregion
        }
    }
}
