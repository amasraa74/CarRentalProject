using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete
{
    public class EfColorDal : EfEntityRepositoryBase<Color,CarContext>, IColorDal
    {

       
        
    }
}
