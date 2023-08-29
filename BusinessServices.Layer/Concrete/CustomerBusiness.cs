using BusinessServices.Layer.Interface;
using DataAccess.Layer.Interface;
using ProjectDb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices.Layer.Concrete
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _repository;
        public UserBusiness(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _repository.GetUsers();
        }
        public async Task<User> AddUser(User user)
        {

            if (user != null)
            {
                return await _repository.AddUser(user);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
