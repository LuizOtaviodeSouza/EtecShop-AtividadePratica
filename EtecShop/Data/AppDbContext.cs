using EtecShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EtecShop.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext (DbContextOptions <AppDbContext> options) : base(options)
    {
    }
    public DbSet <Avaliacao> Avaliacoes { get; set; }
    public DbSet <Categoria> Categorias { get; set; }
    public DbSet <Produtos> Produtos { get; set; }

    protected override void OnModelCreating (MolBuilder builder)
    {
        base.OnModelCreating (builder);
        #region Populando os dados da gestão de usuários
        List <IdentityRole> roles = new()
        {
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                name = "Administrador",
                NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                name = "Funcuinário",
                NormalizedName = "FUNCIONÁRIO"
            },
            new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                name = "Cliente",
                NormalizedName = "CLIENTE"
            }
        };
        builder.Entity <IdentityRole> ().HasData (roles);

        IdentityUser user = new()
        {
            Id = Guid.NewGuid().ToString(),
            Email = "admin@etecshop.com",
            NomalizedEmail = "ADMIN@ETECSHOP.COM",
            UserName = "Admin",
            NormalizedUserName = "ADMIN",
            LockoutEnabled = true,
            EmailConfirmed = true,
        };
        PassawordHasher <IdentityUser> pass = new();
        user.PassawordHash = pass.HashPassword (user, "@Etec123");
        builder.Entity <IdentityUser> ().HasData (user);

        List <IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole <string> () {
                UserId = user.Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole <string> () {
                UserId = user.Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole <string> () {
                UserId = user.Id,
                RoleId = roles[2].Id
            };
            builder.Entity <IdentityUserRole <string>>(). HasData (userRoles);
            #endregion
        }
    }
}