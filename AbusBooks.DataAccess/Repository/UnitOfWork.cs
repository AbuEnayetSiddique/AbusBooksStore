using AbusBooks.DataAccess.Repository.IRepository;
using AbusBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbusBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        //public ICategoryRepository Category => throw new NotImplementedException();

        //public ISP_Call SP_Call => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() //all changes will be saved
        {
            _db.SaveChanges();
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
