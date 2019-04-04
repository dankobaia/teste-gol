using AirplaneCrud.Repository.Models.Airplane;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirplaneCrud.Repository
{
    public interface IAirplaneRepository
    {
        Task<IAirplaneRepositoryModel> Get(string id);

        Task<IEnumerable<IAirplaneRepositoryModel>> List(int limit, int offset);

        Task<IAirplaneRepositoryModel> Create(IAirplaneRepositoryModel airplane);

        Task<IAirplaneRepositoryModel> Edit(IAirplaneRepositoryModel airplane);

        Task Remove(string id);
    }
}