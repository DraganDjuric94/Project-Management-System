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
    class MySqlDokumentDao:DokumentDao<Dokument>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlDokumentDao Instance { get; }

        static MySqlDokumentDao()
        {
            Instance = new MySqlDokumentDao();
        }

        private MySqlDokumentDao() { }

        public void Create(Dokument dokument)
        {
            #region Dodaj dokument u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_dokument";

                cmd.Parameters.AddWithValue("@dokumentID", MySqlDbType.Int32);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@ucesnikID", dokument.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@putanja", dokument.Putanja);
                cmd.Parameters["@putanja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", dokument.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", dokument.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                dokument.DokumentID = Convert.ToInt32(cmd.Parameters["@dokumentID"].Value);
            }
            #endregion

            #region Dodaj komentare za dokument u bp
            foreach(Komentar komentar in dokument.Komentari)
            {
                komentar.DokumentID = dokument.DokumentID;
                MySqlKomentarDao.Instance.Create(komentar);
            }
            #endregion

            #region Dodaj revizije dokumenta za dokument u bp
            foreach(RevizijaDokumenta revizijaDokumenta in dokument.RevizijeDokumenta)
            {
                revizijaDokumenta.DokumentID = dokument.DokumentID;
                MySqlRevizijaDokumentaDao.Instance.Create(revizijaDokumenta);

            }
            #endregion
        }

        public List<Dokument> Read(Dokument dokument)
        {
            List<Dokument> dokumenti = new List<Dokument>();

            #region Citaj dokumente iz bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_dokument";

                cmd.Parameters.AddWithValue("@dokumentID", dokument.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", dokument.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@putanja", dokument.Putanja);
                cmd.Parameters["@putanja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", dokument.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", dokument.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dokumenti.Add(new Dokument { DokumentID = reader.GetInt32(0), UcesnikID = reader.GetInt32(1), Putanja = reader.GetString(2), DatumKreiranja = reader.GetDateTime(3), Aktivan = reader.GetBoolean(4) });
                }

            }
            #endregion

            #region Za svaki dokument procitaj komentare i revizije
            foreach(Dokument d in dokumenti)
            {
                d.Komentari = MySqlKomentarDao.Instance.Read(new Komentar { DokumentID = d.DokumentID });
                d.RevizijeDokumenta = MySqlRevizijaDokumentaDao.Instance.Read(new RevizijaDokumenta { DokumentID = d.DokumentID });
            }
            #endregion

            return dokumenti;
        }

        public void Update(Dokument dokument)
        {
            #region Azuriraj dokument u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_dokument";

                cmd.Parameters.AddWithValue("@dokumentID", dokument.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", dokument.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@putanja", dokument.Putanja);
                cmd.Parameters["@putanja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_kreiranja", dokument.DatumKreiranja);
                cmd.Parameters["@datum_kreiranja"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", dokument.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();

            }
            #endregion

            #region Azuriraj sve komentare i dodaj nove ako ima u bp
            foreach(Komentar k in dokument.Komentari)
            {
                if(k.KomentarID is null)
                {
                    k.DokumentID = dokument.DokumentID;
                    MySqlKomentarDao.Instance.Create(k);
                }
                else
                {
                    MySqlKomentarDao.Instance.Update(k);
                }
            }
            #endregion

            #region Azuriraj sve revizije dokumenta i dodaj nove ako ih ima u bp
            foreach (RevizijaDokumenta rd in dokument.RevizijeDokumenta)
            {
                if(rd.RevizijaDokumentaID is null)
                {
                    rd.DokumentID = dokument.DokumentID;
                    MySqlRevizijaDokumentaDao.Instance.Create(rd);
                }
                else
                {
                    MySqlRevizijaDokumentaDao.Instance.Update(rd);
                }
            }
            #endregion

        }

        public void Delete(int dokumentID)
        {
            Dokument dokument = Read(new Dokument { DokumentID = dokumentID })[0];

            dokument.Aktivan = false;

            foreach(Komentar komentar in dokument.Komentari)
            {
                Komentar.DeaktivirajKomentar(komentar);
            }

            Update(dokument);
        }
    }
}
