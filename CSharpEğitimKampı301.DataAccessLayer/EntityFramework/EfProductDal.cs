using CSharpEğitimKampı301.DataAccessLayer.Abstract;
using CSharpEğitimKampı301.DataAccessLayer.Context;
using CSharpEğitimKampı301.DataAccessLayer.Repositories;
using CSharpEğitimKampı301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampı301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProdusctsWithCategory()
        {
            var context=new KampContext();
            var values = context.Products
                .Select(x => new
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductStock = x.ProductStock,
                    ProductPrice = x.ProductPrice,
                    ProductDescription = x.ProductDescription,
                    CategoryName = x.Category.CategoryName
                }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
