using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scaffold_Test_User.Areas.Identity.Data;
using Scaffold_Test_User.Models;

namespace Scaffold_Test_User.Areas.Identity.Data;



public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{

    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        const string administratorRoleName = "Administrator";

        IdentityRole administratorRoleToSeed = new()
        {
            Id = Guid.NewGuid().ToString(),
            Name = administratorRoleName,
            NormalizedName = administratorRoleName.ToUpperInvariant()
        };

        builder.Entity<IdentityRole>().HasData(administratorRoleToSeed);

        const string administratorUserEmail = "admin@example.com";

        var passwordHasher = new PasswordHasher<ApplicationUser>();

        ApplicationUser administratorUserToSeed = new()
        {
            FirstName = "Admin",
            LastName = "Admin",
            Id = Guid.NewGuid().ToString(),
            UserName = administratorUserEmail,
            NormalizedUserName = administratorUserEmail.ToUpperInvariant(),
            Email = administratorUserEmail,
            NormalizedEmail = administratorUserEmail.ToUpperInvariant(),
            PasswordHash = string.Empty,
        };

        string hashedPassword = passwordHasher.HashPassword(administratorUserToSeed, "StrongPassword1@#");

        administratorUserToSeed.PasswordHash = hashedPassword;

        builder.Entity<ApplicationUser>().HasData(administratorUserToSeed);
        IdentityUserRole<string> identityUserRoleToSeed = new()
        {
            RoleId = administratorRoleToSeed.Id,
            UserId = administratorUserToSeed.Id
        };

        builder.Entity<IdentityUserRole<string>>().HasData(identityUserRoleToSeed);

        builder.Entity<Reservation>()
            .HasKey(r => r.Id);

        builder.Entity<Reservation>()
       .HasOne(r => r.User)
       .WithMany()
       .HasForeignKey(r => r.UserId)
       .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Reservation>()
        .HasOne(r => r.Vehicle)
        .WithMany()
        .HasForeignKey(r => r.VehicleId)
        .OnDelete(DeleteBehavior.Cascade);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(255);
        builder.Property(x => x.LastName).HasMaxLength(255);
    }
}

