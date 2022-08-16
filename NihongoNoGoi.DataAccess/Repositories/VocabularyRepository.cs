using NihongoNoGoi.DataAccess.Repositories.IRepositories;
using NihongoNoGoi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NihongoNoGoi.DataAccess.Repositories
{
    public class VocabularyRepository : Repository<Vocabulary>, IVocabularyRepository
    {
        private ApplicationDBContext _db;

        public VocabularyRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Vocabulary obj)
        {
            _db.Update(obj);
        }
    }
}
