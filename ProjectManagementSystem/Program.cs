using ProjectManagementSystem.dao.mysql;
using ProjectManagementSystem.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
<<<<<<< HEAD
<<<<<<< HEAD

            /*foreach (Projekat p in MySqlProjekatDao.Instance.ReadProjekatByUcesnikID(1))
=======
=======
>>>>>>> 562015e22fcf7a8e916e43325cd431dd2235a030
=======
>>>>>>> 562015e22fcf7a8e916e43325cd431dd2235a030
=======
>>>>>>> 562015e22fcf7a8e916e43325cd431dd2235a030
            /*
            foreach (Projekat p in MySqlProjekatDao.Instance.ReadProjekatByUcesnikID(1))
>>>>>>> 562015e22fcf7a8e916e43325cd431dd2235a030
            {
                Console.WriteLine(p);
            }*/
        }
    }
}
