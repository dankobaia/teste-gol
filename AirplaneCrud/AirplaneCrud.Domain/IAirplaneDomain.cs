using AirplaneCrud.Domain.Models.Airplane;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirplaneCrud.Domain
{
    public interface IAirplaneDomain
    {
        Task<IEnumerable<IAirplane>> List(int limit, int offset);

        Task<IAirplane> Create(ICreateAirplane createAirplane);

        Task<IAirplane> Edit(string id, ICreateAirplane editAirplane);

        Task Remove(string id);
    }
}