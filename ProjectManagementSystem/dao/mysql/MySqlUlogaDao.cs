using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjectManagementSystem.dto;

namespace ProjectManagementSystem.dao.mysql
{
    class MySqlUlogaDao : UlogaDao<Uloga>
    {
        private static MySqlConnection conn = MySqlDaoFactory.Instance.GetConnection();

        public static MySqlUlogaDao Instance { get; }

        static MySqlUlogaDao()
        {
            Instance = new MySqlUlogaDao();
        }

        private MySqlUlogaDao() { }

        public void Create(Uloga uloga)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insert_uloga";

                cmd.Parameters.AddWithValue("@ulogaID", MySqlDbType.Int32);
                cmd.Parameters["@ulogaID"].Direction = ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@naziv", uloga.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", uloga.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
                uloga.UlogaID = Convert.ToInt32(cmd.Parameters["@ulogaID"].Value);
            }
        }

        public List<Uloga> Read(Uloga uloga)
        {
            List<Uloga> uloge = new List<Uloga>();
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "read_uloga";

                cmd.Parameters.AddWithValue("@ulogaID", uloga.UlogaID);
                cmd.Parameters["@ulogaID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@naziv", uloga.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@aktivna", uloga.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    uloge.Add(new Uloga { UlogaID = reader.GetInt32(0), Naziv = reader.GetString(1), Aktivna = reader.GetBoolean(2) });
                }

            }
            return uloge;
        }

        public void Update(Uloga uloga)
        {
            using (conn)
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "update_uloga";
                cmd.Parameters.AddWithValue("@ulogaID", uloga.UlogaID);
                cmd.Parameters["@ulogaID"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@naziv", uloga.Naziv);
                cmd.Parameters["@naziv"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@aktivna", uloga.Aktivna);
                cmd.Parameters["@aktivna"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(Int32 ulogaID)
        {
            Uloga uloga = Read(new Uloga { UlogaID = ulogaID })[0];
            uloga.Aktivna = false;
            Update(uloga);
        }
    }
}
