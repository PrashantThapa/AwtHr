using AppHealth.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppHealth.Helper
{
    public partial class DbHelper
    {
        public async Task<bool> IsUsernameExists(string username)
        {
            return (await _context.Users.Where(x => x.Username == username).FirstOrDefaultAsync()) != null;
        }

        public async Task<UserViewModel> GetUserAsync(string username, string password)
        {
            return (await _context.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefaultAsync()).ToVM();
        }
        public async Task<RoleViewModel> GetRoleAsync(int roleId)
        {
            return (await _context.Roles.Where(x => x.Id == roleId).FirstOrDefaultAsync()).ToVM();
        }

        public async Task<bool> ChangePasswordAsync(int userId, string password)
        {
            try
            {
                var obj = await _context.Users.Where(x => x.Id == userId).FirstOrDefaultAsync();
                if (obj == null) return false;

                obj.Password = password;

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
