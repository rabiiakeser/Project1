﻿using Nortwind.DataAccess.Concrete;
using NortWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Nortwind.Business.Concrete
{
    public class ProductManager
    {
        ProductDal _productDal = new ProductDal();
        public List<Product>GetAll()
        {
            //business code

            
            return _productDal.GetAll();



        }
    }
}
