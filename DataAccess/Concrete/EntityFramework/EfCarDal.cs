using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentacarContext>, ICarDal
    {
        

        public List<CarDto> GetAllDto()
        {
            using (RentacarContext context = new RentacarContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join c in context.Colors
                             on car.ColorId equals c.Id
                             join cat in context.Categories
                             on car.CategoryId equals cat.Id
                             select new CarDto
                             {
                                 Id = car.Id,
                                 Category = cat.Name,
                                 Name = car.Name,
                                 Brand = b.Name,
                                 Color = c.Name,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 DepositFee = car.DepositFee,
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }

        public CarDto GetDto(int carId)
        {
            using (RentacarContext context = new RentacarContext())
            {
                var car = context.Cars.Find(carId);
                return new CarDto
                {
                    Id = car.Id,
                    Name = car.Name,
                    Brand = context.Brands.Find(car.BrandId).Name,
                    Category = context.Categories.Find(car.CategoryId).Name,
                    Color = context.Colors.Find(car.ColorId).Name,
                    ModelYear = car.ModelYear,
                    DailyPrice = car.DailyPrice,
                    DepositFee = car.DepositFee,
                    Description = car.Description
                };
            }
        }
    }
}
