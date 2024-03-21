using Microsoft.EntityFrameworkCore;
using WebApplicationFuncionarios.Models;

namespace WebApplicationFuncionarios.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
