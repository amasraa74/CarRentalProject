using Business.Abstract;
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
    public class CompanyManger : ICompanyService
    {
        ICompanyDal _companyDal;
        public CompanyManger(ICompanyDal customerDal)
        {
            _companyDal = customerDal;
        }

        public IResult Add(Company customer)
        {
            _companyDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Company customer)
        {
            _companyDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll());
        }

        public IDataResult<Company> GetByCustomerId(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(c => c.CompanyId == id));
        }

        public IResult Update(Company customer)
        {
            _companyDal.Update(customer);
            return new SuccessResult(); 
        }
    }
}
