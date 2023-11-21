using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using twitter.entities.Concrete;

namespace twitter.dataaccess.Interfaces
{
    public interface ITweetDal : IGenericDal<Tweet>
    {
    }
}
