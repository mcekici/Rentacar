using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class SerialManager : ISerialService
    {
        ISerialDal _serialDal;

        public SerialManager(ISerialDal serialDal)
        {
            _serialDal = serialDal;
        }

        public IResult Add(Serial serial)
        {
            _serialDal.Add(serial);
            return new SuccessResult("eklendi"); ////////////
        }

        public IResult Delete(Serial serial)
        {
            _serialDal.Delete(serial);
            return new SuccessResult("silindi"); ////////////
        }

        public IDataResult<List<Serial>> GetAll()
        {
            return new SuccessDataResult<List<Serial>>(_serialDal.GetAll().ToList());
        }

        public IDataResult<Serial> GetById(int serialId)
        {
            return new SuccessDataResult<Serial>(_serialDal.Get(b => b.Id == serialId));
        }

        public IResult Update(Serial serial)
        {
            _serialDal.Update(serial);
            return new SuccessResult("güncellendi"); ////////////
        }
    }
}
