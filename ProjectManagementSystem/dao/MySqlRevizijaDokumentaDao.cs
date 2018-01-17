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
    class MySqlRevizijaDokumentaDao: RevizijaDokumentaDao<RevizijaDokumenta>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlRevizijaDokumentaDao Instance { get; }

        static MySqlRevizijaDokumentaDao()
        {
            Instance = new MySqlRevizijaDokumentaDao();
        }

        private MySqlRevizijaDokumentaDao()
        {

        }

        public void Create(RevizijaDokumenta revizijaDokumenta)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_revizija_dokumenta";

                cmd.Parameters.AddWithValue("@revizija_dokumentaID", MySqlDbType.Int32);
                cmd.Parameters["@revizija_dokumentaID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@dokumentID", revizijaDokumenta.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", revizijaDokumenta.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", revizijaDokumenta.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                revizijaDokumenta.RevizijaDokumentaID = Convert.ToInt32(cmd.Parameters["@revizija_dokumentaID"].Value);
            }
        }

        public List<RevizijaDokumenta> Read(RevizijaDokumenta revizijaDokumenta)
        {
            List<RevizijaDokumenta> revizijeDokumenta = new List<RevizijaDokumenta>();
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_revizija_dokumenta";

                cmd.Parameters.AddWithValue("@revizija_dokumentaID", revizijaDokumenta.RevizijaDokumentaID);
                cmd.Parameters["@revizija_dokumentaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@dokumentID", revizijaDokumenta.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", revizijaDokumenta.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", revizijaDokumenta.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    revizijeDokumenta.Add(new RevizijaDokumenta { RevizijaDokumentaID = reader.GetInt32(0), DokumentID = reader.GetInt32(1), UcesnikID = reader.GetInt32(2), DatumVrijeme = reader.GetDateTime(3) });
                }

            }
            return revizijeDokumenta;
        }

        public void Update(RevizijaDokumenta revizijaDokumenta)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_revizija_dokumenta";

                cmd.Parameters.AddWithValue("@revizija_dokumentaID", revizijaDokumenta.RevizijaDokumentaID);
                cmd.Parameters["@revizija_dokumentaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@dokumentID", revizijaDokumenta.DokumentID);
                cmd.Parameters["@dokumentID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@ucesnikID", revizijaDokumenta.UcesnikID);
                cmd.Parameters["@ucesnikID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@datum_vrijeme", revizijaDokumenta.DatumVrijeme);
                cmd.Parameters["@datum_vrijeme"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int revizijaDokumentaID)
        {
            
        }
    }
}
