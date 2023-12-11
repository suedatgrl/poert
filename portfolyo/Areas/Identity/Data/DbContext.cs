using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using portfolyo.Areas.Identity.Data;

namespace portfolyo
{
    public class MyDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
}


//public class DbContext : IdentityDbContext<portfolyoUser>
//{
//    public DbContext(DbContextOptions<DbContext> options)
//        : base(options)
//    {

//    }

//    //protected override void OnModelCreating(ModelBuilder builder)
//    //{
//    //    base.OnModelCreating(builder);
//    //    // Customize the ASP.NET Identity model and override the defaults if needed.
//    //    // For example, you can rename the ASP.NET Identity table names and more.
//    //    // Add your customizations after calling base.OnModelCreating(builder);
//    //    builder.ApplyConfiguration(new PortfolyoUserEntityConfiguration());

//    //}
//}

//public class PortfolyoUserEntityConfiguraiton : IEntityTypeConfiguration<portfolyoUser>
//{
//    void IEntityTypeConfiguration<portfolyoUser>.Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<portfolyoUser> builder)
//    {
//        //throw new NotImplementedException();
//        builder.Property(u => u.FirstName).HasMaxLength(255); 
//        builder.Property(u => u.LastName).HasMaxLength(255);
//    }
//}



//public DbSet<>