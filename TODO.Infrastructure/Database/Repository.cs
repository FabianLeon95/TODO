using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO.Domain.Repositories;

namespace TODO.Infrastructure.Database
{
    public class Repository<TEntity> : IRepository<TEntity>
    {
        public IEnumerable<TEntity> GetAll(int id)
        {
            throw new NotImplementedException();
        }
    }
}
