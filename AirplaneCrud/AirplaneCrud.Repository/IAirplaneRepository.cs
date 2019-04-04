using AirplaneCrud.Repository.Models.Airplane;
using System.Threading.Tasks;

namespace AirplaneCrud.Repository
{
    public interface IAirplaneRepository
    {
        Task<IAirplane> List(int limit, int offset);

        Task<IAirplane> Create(IAirplane airplane);

        Task<IAirplane> Edit(IAirplane airplane);

        Task Remove(string id);
    }
}