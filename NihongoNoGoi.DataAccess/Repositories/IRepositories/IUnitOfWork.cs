using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NihongoNoGoi.DataAccess.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        IVocabularyRepository VocabularyRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        void Save();
    }
}
