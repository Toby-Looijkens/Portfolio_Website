using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Library
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataService (
            this IServiceCollection services) 
        { 
            services.AddDbContext<DBContext> (o => o.UseSqlServer("Server=localhost; Database=S3-Site-DB;User Id = DESKTOP-GHB40U5\\looij; Password=; TrustServerCertificate=true; Integrated Security = true;"));
            return services; 
        }
    }
}
