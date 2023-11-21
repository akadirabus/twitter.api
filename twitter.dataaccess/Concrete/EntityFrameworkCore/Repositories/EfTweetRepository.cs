using twitter.dataaccess.Interfaces;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfTweetRepository : EfGenericRepository<Tweet>, ITweetDal
    {

    }
}
