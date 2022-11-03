﻿using CuratorMagazineWebAPI.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace CuratorMagazineWebAPI.DependencyInjection
{
    public static class PersistenceServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection
            services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<CuratorMagazineContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<ICuratorMagazineContext>(provider => provider.GetService<CuratorMagazineContext>());
            return services;
        }
    }
}
