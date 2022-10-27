using CRM2.Core;
using CDM = CRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM2.Service.Product
{
    public class ProductService: IProductService
    {
        private readonly IRepository<CDM.IProduct> m_RepoProduct; 

        ProductService(IRepository<CDM.IProduct> repoProduct)
        {
            m_RepoProduct = repoProduct ?? throw new ArgumentNullException(nameof(repoProduct));
        }

        public Guid Add(CDM.IProduct entity)
        {
            throw new NotImplementedException();
        }

        public List<Guid> AddProducts(List<CDM.IProduct> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(CDM.IProduct entity)
        {
            throw new NotImplementedException();
        }

        public bool GetActivity(Guid id)
        {
            throw new NotImplementedException();
        }

        public CDM.IProduct GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CDM.IProduct> GetProductsByCategory(CDM.ProductCategory category)
        {
            throw new NotImplementedException();
        }

        public List<CDM.IProduct> GetProductsByCategoryAndActivity(CDM.ProductCategory category, bool @switch)
        {
            throw new NotImplementedException();
        }

        public bool GetProductStatus(Guid id)
        {
            throw new NotImplementedException();
        }

        public int GetQuantityByCategory(CDM.ProductCategory category)
        {
            throw new NotImplementedException();
        }

        public int GetQuantityByCategoryAndActivity(CDM.ProductCategory category, bool @switch)
        {
            throw new NotImplementedException();
        }

        public void SetActivity(bool @switch)
        {
            throw new NotImplementedException();
        }

        public void SetProductStatus(CDM.ProductStatus status)
        {
            throw new NotImplementedException();
        }

        public void Update(CDM.IProduct entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateProducts(List<CDM.IProduct> products)
        {
            throw new NotImplementedException();
        }
    }
}
