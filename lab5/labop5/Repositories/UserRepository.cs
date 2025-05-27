using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labop4.Models;

namespace labop4.Repositories
{
    public class UserRepository : Repository<User>
    {
        public User GetByEmail(string email)
        {
            return _entities.FirstOrDefault(u => u.Email == email);
        }
    }
}
