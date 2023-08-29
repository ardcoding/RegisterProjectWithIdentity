using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using ProjectDb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectDbContext _dbcontext;

        public UserRepository(ProjectDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<User>> GetUsers()
        {
            return await _dbcontext.Users.ToListAsync();
        }
        public async Task<User> AddUser(User user)
        {
            _dbcontext.Users.Add(user);
            await _dbcontext.SaveChangesAsync();
            return user;
        }
    }
}
