using BusinessLayer.Abstract;
using DataAccess.EntityFramework;
using DataAccess.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _repo;
        public CategoryManager()
        {
            _repo = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            _repo.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _repo.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _repo.Update(category);
        }

        public Category GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Category> GetList()
        {
            return _repo.GetAll();
        }
    }
}
