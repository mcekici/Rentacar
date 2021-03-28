using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDto>> GetAllDto();
        IDataResult<List<Car>> GetAll();
        IDataResult<CarDto> GetDto(int carId);
        IDataResult<Car> Get(int carId);
        IDataResult<CarDetailDto> GetDetailDto(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
