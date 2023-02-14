using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=33000,ModelYear=2020,Description="Wie neu"},
                new Car {CarId=2,BrandId=2,ColorId=2,DailyPrice=30000,ModelYear=2019,Description="Tüv neu"},
                new Car {CarId=3,BrandId=3,ColorId=3,DailyPrice=28000,ModelYear=2021,Description="Leasing Fahrzeug"},
                new Car {CarId=4,BrandId=4,ColorId=4,DailyPrice=19000,ModelYear=2018,Description="Familien Auto"}
                
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car); 
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId); 
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
           return _cars.Where(c=>c.CarId == carId).ToList();   
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate =_cars.SingleOrDefault(c=> c.CarId == car.CarId);  
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId; 
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            
            

        }
    }
}
