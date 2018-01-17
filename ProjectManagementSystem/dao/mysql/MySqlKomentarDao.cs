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
    class MySqlKomentarDao : KomentarDao<Komentar>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlKomentarDao Instance { get; }

        static MySqlKomentarDao()
        {
            Instance = new MySqlKomentarDao();
        }

        private MySqlKomentarDao() { }

        public void Create(Komentar komentar)
        {
            #region Add Komentar to DB
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_komentar";

                cmd.Parameters.AddWithValue("@komentarID", MySqlDbType.Int32);
                cmd.Parameters["@komentarID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@komentar_roditeljID", komentar.KomentarRoditeljID);
                cmd.Parameters["@komentar_roditeljID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", komentar.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@dokumentID", komentar.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@tekst", komentar.Tekst);
                cmd.Parameters["@tekst"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", komentar.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", komentar.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                komentar.KomentarID = Convert.ToInt32(cmd.Parameters["@komentarID"].Value);
            }
            #endregion

            #region Add every sub Komentar for Komentar to DB
            foreach(Komentar podkomentar in komentar.Podkomentari)
            {
                podkomentar.KomentarRoditeljID = komentar.KomentarID;
                podkomentar.DokumentID = komentar.DokumentID;
                Create(podkomentar);
            }
            #endregion
        }

        public void Delete(int komentarID)
        {
            Komentar komentar = Read(new Komentar { KomentarID = komentarID })[0];
            Komentar.DeaktivirajKomentar(komentar);
            Update(komentar);

        }

        public List<Komentar> Read(Komentar komentar)
        {
            List<Komentar> komentari = ReadHelper(komentar);

            foreach (Komentar k in komentari)
            {
                AddChildrenTo(k);
            }

            return komentari;
        }

        public void Update(Komentar komentar)
        {
            #region Azuriraj komentar u bp
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_komentar";

                cmd.Parameters.AddWithValue("@komentarID", MySqlDbType.Int32);
                cmd.Parameters["@komentarID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@komentar_roditeljID", komentar.KomentarRoditeljID);
                cmd.Parameters["@komentar_roditeljID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", komentar.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@dokumentID", komentar.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@tekst", komentar.Tekst);
                cmd.Parameters["@tekst"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", komentar.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", komentar.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                komentar.KomentarID = Convert.ToInt32(cmd.Parameters["@komentarID"].Value);
            }
            #endregion

            #region Azuriraj podkomentare i dodaj nove ako ih ima u bp
            foreach (Komentar podkomentar in komentar.Podkomentari)
            {
                if(podkomentar.KomentarID is null)
                {
                    podkomentar.KomentarRoditeljID = komentar.KomentarID;
                    podkomentar.DokumentID = komentar.DokumentID;
                    Create(podkomentar);
                }
                else
                {
                    Update(podkomentar);
                }
            }
            #endregion

        }

        private List<Komentar> ReadHelper(Komentar komentar)
        {
            List<Komentar> komentari = new List<Komentar>();
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_komentar";

                cmd.Parameters.AddWithValue("@komentarID", komentar.KomentarID);
                cmd.Parameters["@komentarID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@komentar_roditeljID", komentar.KomentarRoditeljID);
                cmd.Parameters["@komentar_roditeljID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", komentar.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@dokumentID", komentar.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@tekst", komentar.Tekst);
                cmd.Parameters["@tekst"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", komentar.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivan", komentar.Aktivan);
                cmd.Parameters["@aktivan"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    komentari.Add(new Komentar { KomentarID = reader.GetInt32(0), KomentarRoditeljID = reader.GetInt32(1), UcesnikID = reader.GetInt32(2), DokumentID = reader.GetInt32(3), Tekst = reader.GetString(4), DatumVrijeme = reader.GetDateTime(5), Aktivan = reader.GetBoolean(6) });
                }

                return komentari;
            }
        }

        private void AddChildrenTo(Komentar parent)
        {
            List<Komentar> children = ReadHelper(new Komentar { KomentarRoditeljID = parent.KomentarID });
            if (children != null)
            {
                parent.Podkomentari = children;
                foreach (Komentar child in children)
                {
                    AddChildrenTo(child);
                }
            }
        }

    }
}
