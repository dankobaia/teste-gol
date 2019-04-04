using AirplaneCrud.Domain.Models.Airplane;
using System.ComponentModel.DataAnnotations;

namespace AirplaneCrud.API.Models
{
    public class CreateAirplane : ICreateAirplane
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Model { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        public int MaxPassengers { get; set; }
    }
}