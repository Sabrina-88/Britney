using System.ComponentModel;
using Britney.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Britney.API.Data
{
    public class DataContext : DbContext
    {
        
        public DbSet<ShowModel> Shows { get; set; }
    }
}