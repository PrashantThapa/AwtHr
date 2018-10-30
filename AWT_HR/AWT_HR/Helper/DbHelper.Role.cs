using AppHealth.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppHealth.Helper
{
    public partial class DbHelper
    {
        public async Task<RoleViewModel> GetRoleById(int id)
        {
            return (await _context.Roles.SingleOrDefaultAsync(x => x.Id == id)).ToVM();
        }

       
    }
}
