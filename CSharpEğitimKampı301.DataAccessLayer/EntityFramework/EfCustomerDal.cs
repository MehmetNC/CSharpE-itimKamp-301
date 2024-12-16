using CSharpEğitimKampı301.DataAccessLayer.Abstract;
using CSharpEğitimKampı301.DataAccessLayer.Repositories;
using CSharpEğitimKampı301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampı301.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>,ICustomerDal
    {
    }
}
