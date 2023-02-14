﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _branDal;

        public BrandManager(IBrandDal branDal)
        {
            _branDal = branDal;
        }

        public IResult Add(Brand brand)
        {
            if(brand.BrandName.Length< 2)
            {
                return new ErrorResult(Messages.InvalidBrand);
            }
            _branDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _branDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
          return new SuccessDataResult<List<Brand>>(  _branDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
           return new SuccessDataResult<Brand>( _branDal.Get(b=>b.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            _branDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
