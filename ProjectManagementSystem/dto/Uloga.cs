﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.org.unibl.etf.model.dto
{
    class Uloga
    {
        public Int32? UlogaID { get; set; }
        public String Naziv { get; set; }
        public Boolean? Aktivna { get; set; }

        public override string ToString() => "[UlogaID=" + UlogaID + ", Naziv=" + Naziv + ", Aktivna=" + Aktivna + "]";
    }
}
