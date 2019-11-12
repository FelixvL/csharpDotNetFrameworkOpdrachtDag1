using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BikeStoreASPLesdag1.Models;
using DataBaseModelBikeStore;

namespace BikeStoreASPLesdag1.Repositories
{
    public class ProductRepository
    {
        ProbeerselASPDBEntities dbcontext = new ProbeerselASPDBEntities();
        public List<ProductModel> getAlleProducten() {
            return dbcontext.products.Select(
                    p => new ProductModel {
                        Id = p.product_id,
                        Name = p.product_name
                    }
                ).ToList();
        }
    }
}