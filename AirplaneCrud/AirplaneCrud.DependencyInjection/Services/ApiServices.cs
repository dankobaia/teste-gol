using AirplaneCrud.DependencyInjection.Mapper;
using AirplaneCrud.Domain;
using AirplaneCrud.Repository;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AirplaneCrud.DependencyInjection.Service
{
    public static class ApiServices
    {
        public static void ResolveApi(this IServiceCollection services)
        {
            services.AddScoped<IAirplaneRepository, AirplaneCrud.Repository.EF.AirplaneRepository>();
            //Run Migrations
            Repository.EF.AirplaneRepository.RunMigrations();

            services.AddScoped<IAirplaneDomain, AirplaneCrud.Domain.Gol.AirplaneDomain>();

            var mappingConfig = new MapperConfiguration(mc => mc.AddProfile(new DomainRepositoryEF()));
            mappingConfig.AssertConfigurationIsValid();
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}