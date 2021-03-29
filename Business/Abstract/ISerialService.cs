using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISerialService
    {
        IDataResult<Serial> GetById(int serialId);
        IDataResult<List<Serial>> GetAll();
        IResult Add(Serial serial);
        IResult Update(Serial serial);
        IResult Delete(Serial serial);
    }

}
