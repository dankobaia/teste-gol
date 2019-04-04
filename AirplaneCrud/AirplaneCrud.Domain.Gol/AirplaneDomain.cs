using AirplaneCrud.Domain.Gol.Models;
using AirplaneCrud.Domain.Models.Airplane;
using AirplaneCrud.Repository;
using AirplaneCrud.Repository.Models.Airplane;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirplaneCrud.Domain.Gol
{
    public class AirplaneDomain : IAirplaneDomain
    {
        private readonly IAirplaneRepository airplaneRepository;
        private readonly IMapper mapper;

        public AirplaneDomain(IAirplaneRepository airplaneRepository, IMapper mapper)
        {
            this.airplaneRepository = airplaneRepository;
            this.mapper = mapper;
        }

        public async Task<IAirplane> Create(ICreateAirplane createAirplane)
        {
            var airplane = new Airplane(createAirplane);

            var createdAirplane = await airplaneRepository
                .Create(mapper.Map<IAirplaneRepositoryModel>(airplane))
                .ConfigureAwait(false);

            return mapper.Map<Airplane>(createdAirplane);
        }

        public async Task<IAirplane> Edit(string id, ICreateAirplane editAirplane)
        {
            var dbAirplane = await airplaneRepository.Get(id);
            if (dbAirplane == null)
            {
                throw new NullReferenceException($"Aeronave {id} não encontrada");
            }

            var airplane = new Airplane(editAirplane, dbAirplane);

            var editedAirpolane = await airplaneRepository
                .Edit(mapper.Map<IAirplaneRepositoryModel>(airplane))
                .ConfigureAwait(false);

            return mapper.Map<Airplane>(editedAirpolane);
        }

        public async Task<IEnumerable<IAirplane>> List(int limit, int offset)
        {
            if (limit > 100)
            {
                limit = 100;
            }
            var result = await airplaneRepository.List(limit, offset);
            return result.Select(i => mapper.Map<Airplane>(i));
        }

        public async Task Remove(string id)
        {
            try
            {
                await airplaneRepository.Remove(id)
                    .ConfigureAwait(false);
            }
            catch (ArgumentNullException)
            {
                throw new NullReferenceException($"Aeronave {id} não encontrada");
            }
        }
    }
}