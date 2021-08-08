using System.ComponentModel;
using Britney.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Britney.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<ShowModel> ShowsDataBase { get; set; }
    }
}