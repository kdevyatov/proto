using System;
using System.Collections.Generic;
using System.Text;
using CRM2.Core;
using CRM.Domain.Model;

namespace CRM2.Service.Product
{
    public interface IProductService
    {
        IProduct GetById(Guid id);
        Guid Add(IProduct entity);
        List<Guid> AddProducts(List<IProduct> entities);
        void Delete(IProduct entity);
        void Update(IProduct entity);
        void UpdateProducts(List<IProduct> products);
        void SetActivity(Guid id,bool @switch);
        bool GetActivity(Guid id);

        void SetProductStatus(ProductStatus status);
        bool GetProductStatus(Guid id);

        int GetQuantityByCategory(ProductCategory category);
        int GetQuantityByCategoryAndActivity(ProductCategory category, bool @switch);

        List<IProduct> GetProductsByCategory(ProductCategory category);
        List<IProduct> GetProductsByCategoryAndActivity(ProductCategory category, bool @switch);

    }
}
