using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarsRecords.Main_Sheets;
using StarsRecords.Supporting_Sheets;
using SQLite.CodeFirst;

namespace DBAccess
{
    public class SectorContext : DbContext
    {
        public SectorContext() : base("name=default")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            SqliteDropCreateDatabaseWhenModelChanges<SectorContext> sqliteConnectionInitializer = new SqliteDropCreateDatabaseWhenModelChanges<SectorContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

        public DbSet<Alien> aliens { get; set; }
        public DbSet<Faction> factions { get; set; }
        public DbSet<Planet> planets { get; set; }
        public DbSet<Adventure> adventures { get; set; }
        public DbSet<FactionAsset> factionAssets { get; set; }
        public DbSet<NPC> npcs { get; set; }
		public DbSet<Star> stars { get; set; }
    }
}
