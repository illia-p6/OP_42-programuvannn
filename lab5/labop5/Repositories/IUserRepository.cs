using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labop4.Models;


namespace labop4.Repositories
{
   public interface IUserRepository : IRepository<UserReg>
    {
        UserReg GetByUsername(string username);

    }
}
