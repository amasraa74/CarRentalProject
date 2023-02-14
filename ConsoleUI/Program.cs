using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManger carManger = new CarManger(new EfCarDal());
            //foreach (var car in carManger.GetAll())
            //{
            //    Console.WriteLine(car.ModelName); 
            //}
            //carManger.Add(new Car { BrandId = 4, ColorId = 4, ModelName = "Cayenne", ModelYear = 2016, DailyPrice = 33500, });
            //var result = carManger.GetCarDetails();
            //if (result.IsSuccess)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName + "/" + car.ModelName + "/" + car.ColorName + "/" + car.DailyPrice);
            //    }
            //}

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
           // rentalManager.Add(new Rental { RentDate=new DateTime(2023,12,06),CarId=4,BrandId=4,UserId=1});
            var result = rentalManager.GetRentalDetails();   
            if(result.IsSuccess)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId+"/"+rental.BrandName+"/"+rental.ModelName+"/"+rental.FirstName+"/"+rental.LastName+"/"+rental.RentDate.ToShortDateString()+"/"+rental.RetunDate.ToShortDateString());
                }
            }
           
            //BrandManager brandManager=new BrandManager(new EfBrandDal());

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //Console.WriteLine(colorManager.GetColorById(1).ColorName);

        }
    }
}