using System.Linq.Expressions;
using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfHashtagRepository : EfGenericRepository<Hashtag>, IHashtagDal
    {
    
    }
}