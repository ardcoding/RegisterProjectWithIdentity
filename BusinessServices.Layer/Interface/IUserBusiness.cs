using ProjectDb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.Layer.Interface
{
    public interface IUserBusiness
    {
        Task<List<User>> GetUsers();
        Task<User> AddUser(User user);
    }
}
