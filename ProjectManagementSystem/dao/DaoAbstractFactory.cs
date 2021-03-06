﻿using ProjectManagementSystem.dao.mysql;
using ProjectManagementSystem.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.dao
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
        DokumentDao<Dokument> GetDokumentDao();
        UcesnikDao<Ucesnik> GetUcesnikDao();
        IstorijaAktivnostiDao<IstorijaAktivnosti> GetIstorijaAktivnostiDao();
        #endregion
    }
}
