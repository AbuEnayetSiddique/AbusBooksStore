using AbusBooks.DataAccess.Repository.IRepository;
using AbusBooks.Models;
using AbusBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbusBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb == null)
            {
                objFromDb.Name = covertype.Name;
                _db.SaveChanges();
            }
        }
    }
}
