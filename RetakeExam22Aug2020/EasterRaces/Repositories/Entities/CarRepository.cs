﻿using System.Collections.Generic;
using System.Linq;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : IRepository<ICar>
    {
        private readonly List<ICar> cars;
        public CarRepository()
        {
            this.cars = new List<ICar>();
        }
        public void Add(ICar model)
        {
            this.cars.Add(model);
        }
        public ICar GetByName(string name) 
            => this.cars.FirstOrDefault(x => x.Model == name);

        public IReadOnlyCollection<ICar> GetAll() => this.cars;


        public bool Remove(ICar model)
        {
            return this.cars.Remove(model);
        }
    }
}
