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
    class MySqlProjekatDao:ProjekatDao<Projekat>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlProjekatDao Instance { get; }

        static MySqlProjekatDao()
        {
            Instance = new MySqlProjekatDao();
        }

        private MySqlProjekatDao() { }

        public void Create(Projekat projekat)
        {
            #region Unesi projekat u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_projekat";

                cmd.Parameters.AddWithValue("@projekatID", MySqlDbType.Int32);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@naziv", projekat.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", projekat.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", projekat.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                projekat.ProjekatID = Convert.ToInt32(cmd.Parameters["@projekatID"].Value);
            }

            #endregion

            #region Unesi ucesnike za projekat
            foreach(KeyValuePair<Ucesnik, Uloga> parUcesnikUloga in projekat.UcesniciNaProjektu)
            {
                Ucesnik ucesnik = parUcesnikUloga.Key;
                Uloga uloga = parUcesnikUloga.Value;
                
                if(uloga.UlogaID is null)
                {
                    MySqlUlogaDao.Instance.Create(uloga);
                }

                if(ucesnik.UcesnikID is null)
                {
                    MySqlUcesnikDao.Instance.Create(ucesnik);
                }

                InsertUcesnikProjekatUloga(ucesnik.UcesnikID.Value, projekat.ProjekatID.Value, uloga.UlogaID.Value);
            }
            #endregion

            #region Unesi cjeline za dati projekat
            foreach (Cjelina cjelina in projekat.Cjeline)
            {
                if(cjelina.CjelinaID is null)
                {
                    cjelina.ProjekatID = projekat.ProjekatID;
                    MySqlCjelinaDao.Instance.Create(cjelina);
                }
            }
            #endregion

        }

        public List<Projekat> Read(Projekat projekat)
        {
            List<Projekat> projekti = new List<Projekat>();

            #region Procitaj projekte iz bp koji zadovoljavaju kriterijume
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_projekat";

                cmd.Parameters.AddWithValue("@projekatID", projekat.ProjekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", projekat.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", projekat.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", projekat.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    projekti.Add(new Projekat { ProjekatID = reader.GetInt32(0), Naziv = reader.GetString(1), DatumKreiranja = reader.GetDateTime(2), Aktivan = reader.GetBoolean(3) });
                }
            }
            #endregion

            #region Procitaj sve ucesnike za projekat iz bp
            foreach(Projekat p in projekti)
            {
                Dictionary<Int32, Int32> dict = ReadUcesnikIDAndUlogaIDFromUcesnikProjekatUlogaByProjekatID(p.ProjekatID.Value);

                foreach(KeyValuePair<Int32, Int32> pair in dict)
                {
                    Ucesnik ucesnik = MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = pair.Key })[0];
                    Uloga uloga = MySqlUlogaDao.Instance.Read(new Uloga { UlogaID = pair.Value})[0];
                    p.UcesniciNaProjektu[ucesnik] = uloga;
                }
            }
            #endregion

            #region Procitaj sve cjeline za svaki projekat iz bp
            foreach(Projekat p in projekti)
            {
                p.Cjeline = MySqlCjelinaDao.Instance.Read( new Cjelina { ProjekatID=p.ProjekatID});
            }
            #endregion

            return projekti;
        }

        public void Update(Projekat projekat)
        {
            #region Azuriraj projekat u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_projekat";

                cmd.Parameters.AddWithValue("@projekatID", projekat.ProjekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", projekat.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", projekat.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", projekat.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                projekat.ProjekatID = Convert.ToInt32(cmd.Parameters["@projekatID"].Value);
            }
            #endregion

            #region Azuriraj ucesnike na projektu
            foreach(KeyValuePair<Ucesnik, Uloga> pair in projekat.UcesniciNaProjektu)
            {
                DeleteUcesnikProjekatUlogaByProjekatID(projekat.ProjekatID.Value);
                InsertUcesnikProjekatUloga(pair.Key.UcesnikID.Value, projekat.ProjekatID.Value, pair.Value.UlogaID.Value);
            }
            #endregion

            #region Azuriraj cjeline za projekat i dodaj nove ako postoje u bp
            foreach(Cjelina cjelina in projekat.Cjeline)
            {
                if(cjelina.ProjekatID is null)
                {
                    cjelina.ProjekatID = projekat.ProjekatID;
                    MySqlCjelinaDao.Instance.Create(cjelina);
                }
                else
                {
                    MySqlCjelinaDao.Instance.Update(cjelina);
                }
            }

            #endregion
        }

        public void Delete(int projekatID)
        {
            Projekat projekat = Read(new Projekat { ProjekatID = projekatID })[0];
            Projekat.DeaktivirajProjekat(projekat);
            Update(projekat);         
        }

        public List<Projekat> ReadProjekatByUcesnikID(Ucesnik ucesnik)
        {
            List<Projekat> projekti = new List<Projekat>();
            List<Int32> projektiID = new List<Int32>();

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_ucesnik_projekat_uloga";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnik.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@projekatID", null);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ulogaID", null);
                cmd.Parameters["@ulogaID"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    projektiID.Add(reader.GetInt32(1));
                }
            }

            foreach(Int32 pID in projektiID)
            {
                projekti.Add(MySqlProjekatDao.Instance.Read(new Projekat { ProjekatID = pID })[0]);
            }

            return projekti;
        }

        private Dictionary<Int32, Int32> ReadUcesnikIDAndUlogaIDFromUcesnikProjekatUlogaByProjekatID(Int32 projekatID)
        {
            Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_ucesnik_projekat_uloga";

                cmd.Parameters.AddWithValue("@ucesnikID", null);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@projekatID", projekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ulogaID", null);
                cmd.Parameters["@ulogaID"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dict[reader.GetInt32(0)] = reader.GetInt32(2);
                }
            }

            return dict;
        }

        private void InsertUcesnikProjekatUloga(Int32 ucesnikID, Int32 projekatID, Int32 ulogaID)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_ucesnik_projekat_uloga";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@projekatID", projekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ulogaID", ulogaID);
                cmd.Parameters["@ulogaID"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteUcesnikProjekatUlogaByProjekatID(Int32 projekatID)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete_ucesnik_projekat_uloga";

                cmd.Parameters.AddWithValue("@ucesnikID", null);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@projekatID", projekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ulogaID", null);
                cmd.Parameters["@ulogaID"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }



    }
}
