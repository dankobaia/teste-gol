﻿using System;

namespace AirplaneCrud.Domain.Models.Airplane
{
    public interface IAirplane
    {
        string Id { get; set; }
        string Model { get; set; }
        int MaxPassenger { get; set; }
        DateTime CreateDate { get; set; }
    }
}