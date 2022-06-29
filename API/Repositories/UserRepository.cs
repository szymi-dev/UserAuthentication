using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<IReadOnlyList<UserEntity>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }
}