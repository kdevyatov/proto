using CRM.Domain.Model;
using CRM2.Domain.Model.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM2.Service.Category
{
    internal class CategoryService : ICategoryService
    {
        private readonly IRepository<ICategory> categoryRepository;

        CategoryService(IRepository<ICategory> categoryRepo)
        {
            categoryRepository = categoryRepo ?? throw new ArgumentNullException(nameof(categoryRepo));
        }

        public Core.IRepository<object> IRepository {
            get => default;
            set {
            }
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

        public List<ICategory> GetCategoriesByProducts(List<IProduct> products)
        {
            throw new NotImplementedException();
        }

        public ICategory GetCategoryByProduct(IProduct product)
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
