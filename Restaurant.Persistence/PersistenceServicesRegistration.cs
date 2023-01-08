using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Application.Contracts.Persistence;
using Restaurant.Persistence.Filters;
using Restaurant.Persistence.Repositories;

namespace Restaurant.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IStartupFilter, DatabaseInitFilter>();

            services.AddDbContext<RestaurantDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("RestaurantConnectionString")));


            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IDishRepository, DishRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            return services;
        }
    }
}
