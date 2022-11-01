using CRM2.Core;
using CDM = CRM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using CRM2.Domain.Model;

namespace CRM2.Service.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<CDM.Category> categoryRepository;

        CategoryService(IRepository<CDM.Category> categoryRepo)
        {
            categoryRepository = categoryRepo ?? throw new ArgumentNullException(nameof(categoryRepo));
        }

        public Guid Add(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public List<Guid> AddCategories(List<ICategory> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public bool GetActivity(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICategory GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ICategory> GetCategoriesByProducts(List<CDM.IProduct> products)
        {
            throw new NotImplementedException();
        }

        public ICategory GetCategoryByProduct(CDM.IProduct product)
        {
            throw new NotImplementedException();
        }

        public void SetActivity(Guid id, bool @switch)
        {
            throw new NotImplementedException();
        }

        public void Update(ICategory entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategories(List<ICategory> entities)
        {
            throw new NotImplementedException();
        }
    }
}
