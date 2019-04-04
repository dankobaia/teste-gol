namespace AirplaneCrud.Domain.Models.Airplane
{
    public interface ICreateAirplane
    {
        string Model { get; set; }
        int MaxPassenger { get; set; }
    }
}