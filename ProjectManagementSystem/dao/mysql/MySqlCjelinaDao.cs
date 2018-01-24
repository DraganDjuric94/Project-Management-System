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
    class MySqlCjelinaDao : CjelinaDao<Cjelina>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlCjelinaDao Instance { get; }

        static MySqlCjelinaDao()
        {
            Instance = new MySqlCjelinaDao();
        }

        public void Create(Cjelina cjelina)
        {
            #region Unesi novu cjelinu u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_cjelina";

                cmd.Parameters.AddWithValue("@cjelinaID", MySqlDbType.Int32);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@cjelina_roditeljID", cjelina.CjelinaRoditeljID);
                cmd.Parameters["@cjelina_roditeljID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@projekatID", cjelina.ProjekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", cjelina.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@procenat_izvrsenosti", cjelina.ProcenatIzvrsenosti);
                cmd.Parameters["@procenat_izvrsenosti"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@rok", cjelina.Rok);
                cmd.Parameters["@rok"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", cjelina.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@broj_potrebnih_covjek_casova", cjelina.BrojPotrebnihCovjekCasova);
                cmd.Parameters["@broj_potrebnih_covjek_casova"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", cjelina.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                cjelina.CjelinaID = Convert.ToInt32(cmd.Parameters["@cjelinaID"].Value);
            }
            #endregion

            #region Unesi nove aktivnosti za cjelinu
            foreach (Aktivnost aktivnost in cjelina.Aktivnosti)
            {
                if(aktivnost.AktivnostID is null)
                {
                    aktivnost.CjelinaID = cjelina.CjelinaID;
                    MySqlAktivnostDao.Instance.Create(aktivnost);
                }
            }
            #endregion

            #region Unesi nove ucesnike i dodaj ucesnike cjelini
            foreach(Ucesnik u in cjelina.Ucesnici)
            {
                if(u.UcesnikID is null)
                {
                   MySqlUcesnikDao.Instance.Create(u);
                }

                InsertUcesnikCjelina(u.UcesnikID.Value, cjelina.CjelinaID.Value);
            }
            #endregion

            #region Unesi podcjeline u bp
            foreach (Cjelina podcjelina in cjelina.Podcjeline)
            {
                podcjelina.CjelinaRoditeljID = cjelina.CjelinaID;
                podcjelina.ProjekatID = cjelina.ProjekatID;
                Create(podcjelina);
            }
            #endregion

        }

        public void Delete(int cjelinaID)
        {
            Cjelina cjelina = Read(new Cjelina { CjelinaID = cjelinaID })[0];
            Cjelina.DeaktivirajCjelinu(cjelina);
            Update(cjelina);
        }

        public List<Cjelina> Read(Cjelina cjelina)
        {
            List<Cjelina> cjeline = ReadHelper(cjelina);

            foreach (Cjelina c in cjeline)
            {
                AddChildrenTo(c);
            }

            return cjeline;
        }

        public void Update(Cjelina cjelina)
        {
            #region Azuriraj cjelinu u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_cjelina";

                cmd.Parameters.AddWithValue("@cjelinaID", cjelina.CjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelina_roditeljID", cjelina.CjelinaRoditeljID);
                cmd.Parameters["@cjelina_roditeljID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@projekatID", cjelina.ProjekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", cjelina.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@procenat_izvrsenosti", cjelina.ProcenatIzvrsenosti);
                cmd.Parameters["@procenat_izvrsenosti"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@rok", cjelina.Rok);
                cmd.Parameters["@rok"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", cjelina.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@broj_potrebnih_covjek_casova", cjelina.BrojPotrebnihCovjekCasova);
                cmd.Parameters["@broj_potrebnih_covjek_casova"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", cjelina.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                cjelina.CjelinaID = Convert.ToInt32(cmd.Parameters["@cjelinaID"].Value);
            }
            #endregion

            #region Azuriraj ucesnike na cjelini
            foreach(Ucesnik u in cjelina.Ucesnici)
            {
                DeleteUcesnikCjelinaByCjelinaID(cjelina.CjelinaID.Value);
                InsertUcesnikCjelina(u.UcesnikID.Value, cjelina.CjelinaID.Value);
            }
            #endregion

            #region Azuriraj svaku aktivnost iz cjeline, i dodaj nove ako postoje u bp
            foreach (Aktivnost aktivnost in cjelina.Aktivnosti)
            {
                if(aktivnost is null)
                {
                    aktivnost.CjelinaID = cjelina.CjelinaID;
                    MySqlAktivnostDao.Instance.Create(aktivnost);
                }
                else
                {
                    MySqlAktivnostDao.Instance.Update(aktivnost);
                }
            }
            #endregion

            #region Azuriraj svaku podcjelinu cjeline i dodaj novih ako ima u bp
            foreach (Cjelina podcjelina in cjelina.Podcjeline)
            {
                if(podcjelina.CjelinaID is null)
                {
                    podcjelina.CjelinaRoditeljID = cjelina.CjelinaID;
                    podcjelina.ProjekatID = cjelina.ProjekatID;
                    Create(podcjelina);
                }
                else
                {
                    Update(podcjelina);
                }
            }
            #endregion

        }

        private List<Cjelina> ReadHelper(Cjelina cjelina)
        {
            List<Cjelina> cjeline = new List<Cjelina>();

            #region Read Cjelina to list from DB
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_cjelina";

                cmd.Parameters.AddWithValue("@cjelinaID", cjelina.CjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelina_roditeljID", cjelina.CjelinaRoditeljID);
                cmd.Parameters["@cjelina_roditeljID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@projekatID", cjelina.ProjekatID);
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", cjelina.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@procenat_izvrsenosti", cjelina.ProcenatIzvrsenosti);
                cmd.Parameters["@procenat_izvrsenosti"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@rok", cjelina.Rok);
                cmd.Parameters["@rok"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", cjelina.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@broj_potrebnih_covjek_casova", cjelina.BrojPotrebnihCovjekCasova);
                cmd.Parameters["@broj_potrebnih_covjek_casova"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", cjelina.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cjeline.Add(new Cjelina { CjelinaID = reader.GetInt32(0), CjelinaRoditeljID = ((!reader.IsDBNull(1))?reader.GetInt32(1):(Int32?)null), ProjekatID = reader.GetInt32(2), Naziv = reader.GetString(3), ProcenatIzvrsenosti = reader.GetInt32(4), Rok = reader.GetDateTime(5), DatumKreiranja = reader.GetDateTime(6), BrojPotrebnihCovjekCasova = reader.GetInt32(7), Aktivna = reader.GetBoolean(8) });
                }
            }
            #endregion

            #region Procitaj ucesnike za svaku cjelinu
            foreach (Cjelina c in cjeline)
            {
                List<Int32> ucesniciID = ReadUcesnikIDFromUcesnikCjelinaByCjelinaID(c.CjelinaID.Value);

                foreach (Int32 ucesnikID in ucesniciID)
                {
                    c.Ucesnici.Add(MySqlUcesnikDao.Instance.Read(new Ucesnik { UcesnikID = ucesnikID })[0]);
                }
            }
            #endregion

            #region Read Aktivnost for every Cjelina in list from DB
            MySqlAktivnostDao aInstance = MySqlAktivnostDao.Instance;
            foreach (Cjelina c in cjeline)
            {
                c.Aktivnosti = aInstance.Read(new Aktivnost { CjelinaID = c.CjelinaID });
            }
            #endregion

            return cjeline;
        }

        private void AddChildrenTo(Cjelina parent)
        {
            List<Cjelina> children = ReadHelper(new Cjelina { CjelinaRoditeljID = parent.CjelinaID });
            if (children != null)
            {
                parent.Podcjeline = children;
                foreach (Cjelina child in children)
                {
                    AddChildrenTo(child);
                }
            }
        }

        private List<Int32> ReadUcesnikIDFromUcesnikCjelinaByCjelinaID(Int32 cjelinaID)
        {
            List<Int32> ucesniciID = new List<Int32>();

            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_ucesnik_cjelina";

                cmd.Parameters.AddWithValue("@ucesnikID", null);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelinaID", cjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ucesniciID.Add(reader.GetInt32(0));
                }
            }

            return ucesniciID;
        }

        private void InsertUcesnikCjelina(Int32 ucesnikID, Int32 cjelinaID)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_ucesnik_cjelina";

                cmd.Parameters.AddWithValue("@ucesnikID", ucesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelinaID", cjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }

        private void DeleteUcesnikCjelinaByCjelinaID(Int32 cjelinaID)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "delete_ucesnik_cjelina";

                cmd.Parameters.AddWithValue("@ucesnikID", null);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@cjelinaID", cjelinaID);
                cmd.Parameters["@cjelinaID"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();            
            }
        }

    }
}
