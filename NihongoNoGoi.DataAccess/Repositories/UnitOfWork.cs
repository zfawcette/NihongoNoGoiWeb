using NihongoNoGoi.DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NihongoNoGoi.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            VocabularyRepository = new VocabularyRepository(_db);
            CategoryRepository = new CategoryRepository(_db);
        }

        public IVocabularyRepository VocabularyRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
