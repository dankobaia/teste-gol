namespace AirplaneCrud.DependencyInjection.Mapper
{
    internal class DomainRepositoryEF : AutoMapper.Profile
    {
        public DomainRepositoryEF()
        {
            AutoMapperConfig();
            MapRepositoryModels();
        }

        private void AutoMapperConfig()
        {
            // map properties with a public or private getter
            ShouldMapProperty = pi =>
                pi.GetMethod != null && (pi.GetMethod.IsPublic || pi.GetMethod.IsPrivate);
        }

        private void MapRepositoryModels()
        {
            CreateMap<Repository.EF.Models.Airplane, Domain.Models.Airplane.IAirplane>()
                .As<Domain.Gol.Models.Airplane>();

            CreateMap<Repository.Models.Airplane.IAirplaneRepositoryModel, Domain.Gol.Models.Airplane>();
        }
    }
}