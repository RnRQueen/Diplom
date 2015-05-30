using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Diplom
{
    [DbConfigurationType(typeof(SQLiteConfiguration))]
    class Context: DbContext
        {
        public DbSet<ApartmentData> Apartaments { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
             {
            
                  modelBuilder.Conventions
                     .Remove<PluralizingTableNameConvention>();
             }

        
        }
}
