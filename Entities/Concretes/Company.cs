﻿using Core.Entities;

namespace Entities.Concretes
{
    public class Company : Entity<Guid>
    {
        public string Name { get; set; }
    }
}