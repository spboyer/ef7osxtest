
using Microsoft.EntityFrameworkCore;
namespace EF7WebAPI.Data
{
    public class WeatherContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<WeatherEvent> WeatherEvents { get; set; }
    }
}