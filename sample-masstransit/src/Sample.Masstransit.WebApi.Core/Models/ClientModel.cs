﻿using System;

namespace Sample.Masstransit.WebApi.Core.Models
{
    public interface ClientModel
    {
        public string ClientId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
