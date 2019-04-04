using System;

namespace AirplaneCrud.Repository.Models.Airplane
{
    public interface IAirplaneRepositoryModel
    {
        string Id { get; set; }
        string Model { get; set; }
        int MaxPassengers { get; set; }
        DateTime CreateDate { get; set; }
    }
}