using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAccess;
using StarsRecords.Main_Sheets;
using StarsRecords.Supporting_Sheets;
using System.Data.Entity;
using SQLite.CodeFirst;

namespace WindowsFrontEnd
{
    static class Program
    {
		public const string Title = "Stars Without Number Sector Manager";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (SectorContext db = new SectorContext())
            //{
            //    Planet p = new Planet();
            //    p.name = "roar";

            //    db.planets.Add(p);

            //    db.SaveChanges();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntryForm());
        }
    }
}
