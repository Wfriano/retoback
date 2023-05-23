namespace RetoBackEnd.MiddleWare
{
    using Business;
    using Business.Interfaces;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;
    using Repository;
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ContextDb>(db => db.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork>(sp => new UnitOfWork(
                sp.GetRequiredService<DbContextOptions<ContextDb>>(),
                sp.GetRequiredService<IConfiguration>().GetConnectionString("DefaultConnection")));
            services.AddScoped<ICategoriesBusiness, CategoriesBusiness>();
            services.AddScoped<IInventoriesBusiness, InventoriesBusiness>();
            services.AddScoped<IProductsBusiness, ProductsBusiness>();
            services.AddScoped<ISuppliersBusiness, SuppliersBusiness>();
            return services;
        }
    }
}
