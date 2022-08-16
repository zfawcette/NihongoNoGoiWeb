using NihongoNoGoi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NihongoNoGoi.DataAccess.Repositories.IRepositories
{
    public interface IVocabularyRepository : IRepository<Vocabulary>
    {
        void Update(Vocabulary obj);
        void Save();
    }
}
