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
                var cars = context.Cars.ToList();
                var dtos = new List<CarDto>();
                foreach (var car in cars)
                {
                    dtos.Add(new CarDto
                    {
                        Id = car.Id,
                        Plate = car.Plate,
                        Name = car.Name,
                        ModelYear = car.ModelYear,
                        Class = context.CarProperties.FirstOrDefault(cp=>
                            cp.Name.Equals("Sinifi") &&
                            cp.CarId == car.Id
                        ).Value,
                        DailyPrice = car.DailyPrice,
                        DepositFee = car.DepositFee
                    });
                }
                return dtos;
            }
        }

        public CarDetailDto GetDetailDto(int carId)
        {
            using (RentacarContext context = new RentacarContext()) {

                return new CarDetailDto
                {
                    Car = GetDto(carId),
                    Properties = context.CarProperties.Where(cp => cp.CarId == carId).ToList()
                };
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
                    Plate = car.Plate,
                    Name = car.Name,
                    ModelYear = car.ModelYear,
                    Class = context.CarProperties.FirstOrDefault(cp => 
                        cp.CarId == car.Id && 
                        cp.Name.Equals("Class")
                    ).Value,
                    DailyPrice = car.DailyPrice,
                    DepositFee = car.DepositFee
                };
            }
        }
    }
}
