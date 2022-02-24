using Microsoft.EntityFrameworkCore;
using PortfolioWebApp.Models;

namespace PortfolioWebApp.Data {
    public class GeneralData : DbContext {

        public DbSet<ConnectionModel> Connections { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { 
            //Admin account provided, but server cannot be accessed without azure account credentials. It is protected by a firewall
            options.UseSqlServer(@"Server=tcp:luis-portfolio.database.windows.net,1433;Initial Catalog=luis-portfolio;Persist Security Info=False;User ID=portfolio-admin;Password=buvnit6rudsepoFvyz;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }

    }
}