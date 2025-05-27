using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using labop4.Models;

namespace labop4.Repositories
{
    public class UserRegRepository : IUserRepository
    {
        private List<UserReg> users = new List<UserReg>();

        public void Add(UserReg entity)
        {
            users.Add(entity);
        }

        public void Remove(UserReg entity)
        {
            users.Remove(entity);
        }

        public UserReg GetById(int id)
        {
            return users.FirstOrDefault(u => u.ID == id);
        }

        public List<UserReg> GetAll()
        {
            return users;
        }

        public UserReg GetByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }
    }
}
