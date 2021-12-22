﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService // iş katmanında Interfaceler service olarak ifade edilir.
    {
        IDataResult <List<Product>>GetAll();
        IDataResult <List<Product>> GetAllByCategoryId(int id);
        IDataResult <List<Product>> GetByUnitPrice(decimal min,decimal max);
        IDataResult <List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IDataResult <Product> GetById(int productId);
   // RESTFUL--> HTTP --> TCP
    }
}
