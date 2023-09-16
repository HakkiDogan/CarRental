using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1,BrandId=1,ColorId=1,DailyPriceId=1,Description="Mercedes",ModelYear="2012"},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPriceId=2,Description="Toyota",ModelYear="2005"},
                new Car{Id=3,BrandId=3,ColorId=3,DailyPriceId=3,Description="Tesla",ModelYear="2022"},
                new Car{Id=4,BrandId=4,ColorId=1,DailyPriceId=4,Description="Audi",ModelYear="2019"},
                new Car{Id=5,BrandId=5,ColorId=3,DailyPriceId=5,Description="Hyundai",ModelYear="2023"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car car = _cars.SingleOrDefault(c => c.Id == id);
            if (car != null)
            {
                _cars.Remove(car);
            }           
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            if (carToUpdate != null)
            {
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.Description = car.Description;
                carToUpdate.DailyPriceId = car.DailyPriceId;
                carToUpdate.ModelYear = car.ModelYear;
            }                  
        }
    }
}
