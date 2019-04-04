using AirplaneCrud.Domain.Models.Airplane;
using System.Threading.Tasks;

namespace AirplaneCrud.Domain
{
    public interface IAirplaneDomain
    {
        Task<IAirplane> List(int limit, int offset);

        Task<IAirplane> Create(ICreateAirplane airplane);

        Task<IAirplane> Edit(IEditAirplane airplane);

        Task Remove(string id);
    }
}