using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from r in context.Rentals
                             join car in context.Cars
                             on r.CarId equals car.CarId
                             join u in context.Users
                             on r.UserId equals u.UserId
                             join b in context.Brands
                             on r.BrandId equals b.BrandId

                             select new RentalDetailDto { CarId = car.CarId, ModelName = car.ModelName, FirstName = u.FirstName, LastName = u.LastName, RentDate = r.RentDate, RetunDate =(DateTime)r.ReturnDate,BrandName=b.BrandName};
                            return result.ToList();
            }
           
        }
    }
}
