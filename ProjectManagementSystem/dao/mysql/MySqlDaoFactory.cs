using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjectManagementSystem.dto;

namespace ProjectManagementSystem.dao.mysql
{
    class MySqlDaoFactory : DaoAbstractFactory
    {
        private static string ConnectionString = "Server=localhost;Database=pms;UserId=student;Password=student;";

        public static MySqlDaoFactory Instance { get; }

        static MySqlDaoFactory()
        {
            Instance = new MySqlDaoFactory();
        }

        private MySqlDaoFactory() { }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        #region MySql implemented DAO's
        public UlogaDao<Uloga> GetUlogaDao()
        {
            return MySqlUlogaDao.Instance;
        }

        public TransakcijaDao<Transakcija> GetTransakcijaDao()
        {
            return MySqlTransakcijaDao.Instance;
        }

        public AktivnostDao<Aktivnost> GetAktivnostDao()
        {
            return MySqlAktivnostDao.Instance;
        }

        public CjelinaDao<Cjelina> GetCjelinaDao()
        {
            return MySqlCjelinaDao.Instance;
        }

        public ProjekatDao<Projekat> GetProjekat()
        {
            return MySqlProjekatDao.Instance;
        }

        public DokumentDao<Dokument> GetDokument()
        {
            return MySqlDokumentDao.Instance;
        }

        public RevizijaDokumentaDao<RevizijaDokumenta> GetRevizijaDokumentaDao()
        {
            return MySqlRevizijaDokumentaDao.Instance;
        }

        public DokumentDao<Dokument> GetDokumentDao()
        {
            return MySqlDokumentDao.Instance;
        }

        public UcesnikDao<Ucesnik> GetUcesnikDao()
        {
            return MySqlUcesnikDao.Instance;
        }

        public IstorijaAktivnostiDao<IstorijaAktivnosti> GetIstorijaAktivnostiDao()
        {
            return MySqlIstorijaAktivnostiDao.Instance;
        }
        #endregion
    }
}
