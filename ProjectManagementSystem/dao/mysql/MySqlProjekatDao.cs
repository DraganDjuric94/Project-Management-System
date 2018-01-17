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

            #region Unesi cjeline za dati projekat
            foreach(Cjelina cjelina in projekat.Cjeline)
            {
                cjelina.ProjekatID = projekat.ProjekatID;
                MySqlCjelinaDao.Instance.Create(cjelina);
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
                cmd.Parameters["@projekatID"].Direction = ParameterDirection.Output;

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
    }
}
