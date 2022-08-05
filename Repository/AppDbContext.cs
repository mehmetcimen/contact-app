using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInformation> ContactInformations { get; set; }


        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is Base baseEntity)
                {
                    switch (item.Entity)
                    {
                        case EntityState.Added:
                            {
                                baseEntity.CreatedDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(baseEntity).Property(x => x.CreatedDate).IsModified = false;
                                Entry(baseEntity).Property(x => x.Active).IsModified = false;

                                baseEntity.UpdatedDate = DateTime.Now;
                                break;
                            }


                    }
                }


            }


            return base.SaveChanges();
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is Base baseEntity)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                baseEntity.Active = true;
                                baseEntity.CreatedDate = DateTime.Now;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(baseEntity).Property(x => x.CreatedDate).IsModified = false;
                                Entry(baseEntity).Property(x => x.Active).IsModified = false;

                                baseEntity.UpdatedDate = DateTime.Now;
                                break;
                            }


                    }
                }


            }

            return base.SaveChangesAsync(cancellationToken);    
        }



    }
}
