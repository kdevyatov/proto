using CRM.Domain.Model;
using CRM2.Domain.Model.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM2.Service.Category
{
    internal interface ICategoryService
    {
        ICategory GetById(Guid id);
        Guid Add(ICategory entity);
        List<Guid> AddCategories(List<ICategory> entities);
        void Delete(ICategory entity);
        void Update(ICategory entity);
        void UpdateCategories(List<ICategory> entities);
        void SetActivity(Guid id, bool @switch);
        bool GetActivity(Guid id);
        ICategory GetCategoryByProduct(IProduct product);
        List<ICategory> GetCategoriesByProducts(List<IProduct> products);
    }
}
