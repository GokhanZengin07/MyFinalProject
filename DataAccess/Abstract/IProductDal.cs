using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>// I interface, Product hangi tablo karşılık gelir, Dal Hangi katman
                                // Product entitysin DAL , DATA ACCESS LAYER , DAO > JAVA
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
// Code Refactoring
