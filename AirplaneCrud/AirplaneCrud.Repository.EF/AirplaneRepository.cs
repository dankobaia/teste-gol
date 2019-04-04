using AirplaneCrud.Repository.EF.Models;
using AirplaneCrud.Repository.Models.Airplane;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirplaneCrud.Repository.EF
{
    public class AirplaneRepository : IAirplaneRepository
    {
        public async Task<IAirplaneRepositoryModel> Get(string id)
        {
            using (var dbContext = new AirplaneDbContext())
            {
                return await dbContext.Airplanes.FindAsync(id)
                    .ConfigureAwait(false);
            }
        }

        public async Task<IAirplaneRepositoryModel> Create(IAirplaneRepositoryModel airplane)
        {
            using (var dbContext = new AirplaneDbContext())
            {
                var value = new Airplane(airplane);
                await dbContext.Airplanes.AddAsync(value)
                    .ConfigureAwait(false);
                await dbContext.SaveChangesAsync();
                return value;
            }
        }

        public async Task<IAirplaneRepositoryModel> Edit(IAirplaneRepositoryModel airplane)
        {
            using (var dbContext = new AirplaneDbContext())
            {
                var value = new Airplane(airplane);
                dbContext.Airplanes.Update(new Airplane(value));
                await dbContext.SaveChangesAsync()
                    .ConfigureAwait(false);
                return value;
            }
        }

        public async Task<IEnumerable<IAirplaneRepositoryModel>> List(int limit, int offset)
        {
            using (var dbContext = new AirplaneDbContext())
            {
                return await dbContext.Airplanes
                .Skip(offset)
                .Take(limit)
                .ToListAsync().ConfigureAwait(false);
            }
        }

        public async Task Remove(string id)
        {
            using (var dbContext = new AirplaneDbContext())
            {
                var airplane = await dbContext.Airplanes
                .FindAsync(id)
                .ConfigureAwait(false);
                dbContext.Airplanes.Remove(airplane);
            }
        }
    }
}