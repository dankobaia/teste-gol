using AirplaneCrud.Domain.Models.Airplane;
using AirplaneCrud.Repository.Models.Airplane;
using EnsureThat;
using System;

namespace AirplaneCrud.Domain.Gol.Models
{
    public class Airplane : IAirplane
    {
        private string _id;
        private int _maxPassenger;
        private DateTime _createDate;
        private string _model;

        private Airplane()
        {
        }

        public Airplane(ICreateAirplane airplane)
        {
            SetCreateDate(DateTime.Now);
            SetMaxPassangers(airplane.MaxPassengers);
            SetModel(airplane.Model);
        }

        public Airplane(ICreateAirplane editAirplane, IAirplaneRepositoryModel dbAirplane)
        {
            SetCreateDate(dbAirplane.CreateDate);
            SetId(dbAirplane.Id);
            SetMaxPassangers(editAirplane.MaxPassengers);
            SetModel(editAirplane.Model);
        }

        public string Id { get => _id; set => SetId(value); }
        public string Model { get => _model; set => SetModel(value); }
        public int MaxPassengers { get => _maxPassenger; set => SetMaxPassangers(value); }
        public DateTime CreateDate { get => _createDate; set => SetCreateDate(value); }

        private void SetCreateDate(DateTime value)
        {
            EnsureArg.IsLte(value, DateTime.Now);
            _createDate = value;
        }

        private void SetMaxPassangers(int value)
        {
            EnsureArg.IsGt(value, 0);
            _maxPassenger = value;
        }

        private void SetId(string value)
        {
            EnsureArg.IsNotEmptyOrWhitespace(value);
            _id = value;
        }

        private void SetModel(string value)
        {
            EnsureArg.IsNotEmptyOrWhitespace(value);
            _model = value;
        }
    }
}