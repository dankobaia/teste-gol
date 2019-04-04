namespace AirplaneCrud.Domain.Models.Airplane
{
    public interface IEditAirplane
    {
        string Id { get; set; }
        string Model { get; set; }
        int MaxPassenger { get; set; }
    }
}