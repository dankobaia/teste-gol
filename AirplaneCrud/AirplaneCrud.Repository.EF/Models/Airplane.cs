using AirplaneCrud.Repository.Models.Airplane;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirplaneCrud.Repository.EF.Models
{
    public class Airplane : IAirplaneRepositoryModel
    {
        protected Airplane()
        {
        }

        public Airplane(IAirplaneRepositoryModel model)
        {
            Id = model.Id;
            Model = model.Model;
            MaxPassengers = model.MaxPassengers;
            CreateDate = model.CreateDate;
        }

        public Airplane(IAirplaneRepositoryModel model, Airplane dbAIrplane)
        {
            Id = dbAIrplane.Id;
            Model = model.Model;
            MaxPassengers = model.MaxPassengers;
            CreateDate = dbAIrplane.CreateDate;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public string Id { get; set; }

        public string Model { get; set; }
        public int MaxPassengers { get; set; }
        public DateTime CreateDate { get; set; }
    }
}