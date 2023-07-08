﻿using TemperatureChecker.Entities; 

namespace TemperatureChecker.Entities
{
    public class BusinessPartner : EntityBase
    {
        public string? Name { get; set; }
        public override string ToString() => $"Id: {Id}, Name: {Name}";

    }
}

