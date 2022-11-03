using CRM.Domain.Model;
using CRM2.Domain.Model.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM2.Service.Product
{
    public class ProductService: IProductService
    {
        private readonly IRepository<IProduct> productRepository; 

        ProductService(IRepository<IProduct> repoProduct)
        {
            productRepository = repoProduct ?? throw new ArgumentNullException(nameof(repoProduct));
        }

        public Guid Add(IProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<Guid> AddProducts(List<IProduct> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(IProduct entity)
        {
            throw new NotImplementedException();
        }

        public bool GetActivity(Guid id)
        {
            throw new NotImplementedException();
        }

        public IProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<IProduct> GetProductsByCategory(ProductCategory category)
        {
            throw new NotImplementedException();
        }

        public List<IProduct> GetProductsByCategoryAndActivity(ProductCategory category, bool @switch)
        {
            throw new NotImplementedException();
        }

        public bool GetProductStatus(Guid id)
        {
            throw new NotImplementedException();
        }

        public int GetQuantityByCategory(ProductCategory category)
        {
            throw new NotImplementedException();
        }

        public int GetQuantityByCategoryAndActivity(ProductCategory category, bool @switch)
        {
            throw new NotImplementedException();
        }

        public void SetActivity(Guid id, bool @switch)
        {
            throw new NotImplementedException();
        }

        public void SetProductStatus(ProductStatus status)
        {
            throw new NotImplementedException();
        }

        public void Update(IProduct entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateProducts(List<IProduct> products)
        {
            throw new NotImplementedException();
        }
    }
}
