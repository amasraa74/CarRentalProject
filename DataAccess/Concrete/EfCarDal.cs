using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext carContext = new CarContext())
            {
                var result = from car in carContext.Cars
                             join c in carContext.Colors
                             on car.ColorId equals c.ColorId
                             join b in carContext.Brands
                             on car.BrandId equals b.BrandId
                             select new CarDetailDto
                             {  CarId = car.CarId, BrandName = b.BrandName, ModelName = car.ModelName, ColorName = c.ColorName, DailyPrice = car.DailyPrice};
                return result.ToList();

                             

            }
        }
    }
}
