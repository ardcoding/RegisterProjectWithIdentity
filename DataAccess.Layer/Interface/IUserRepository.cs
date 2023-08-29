using ProjectDb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
        Task<User> AddUser(User user);
    }
}
