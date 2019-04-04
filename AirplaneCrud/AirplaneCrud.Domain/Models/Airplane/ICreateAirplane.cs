namespace AirplaneCrud.Domain.Models.Airplane
{
    public interface ICreateAirplane
    {
        string Model { get; set; }
        int MaxPassengers { get; set; }
    }
}