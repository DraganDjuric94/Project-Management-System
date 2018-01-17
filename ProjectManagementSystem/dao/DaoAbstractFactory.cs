using ProjectManagementSystem.org.unibl.etf.model.dao.mysql;
using ProjectManagementSystem.org.unibl.etf.model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.org.unibl.etf.model.dao
{
    interface DaoAbstractFactory
    {
        #region DAO's
        UlogaDao<Uloga> GetUlogaDao();
        TransakcijaDao<Transakcija> GetTransakcijaDao();
        AktivnostDao<Aktivnost> GetAktivnostDao();
        CjelinaDao<Cjelina> GetCjelinaDao();
        ProjekatDao<Projekat> GetProjekat();
        RevizijaDokumentaDao<RevizijaDokumenta> GetRevizijaDokumentaDao();
        KomentarDao<Komentar> GetKomentarDao();
        DokumentDao<Dokument> GetDokumentDao();
        UcesnikDao<Ucesnik> GetUcesnikDao();
        #endregion
    }
}
