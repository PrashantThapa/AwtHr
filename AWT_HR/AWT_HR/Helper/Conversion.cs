using AppHealth.Models;

namespace AppHealth.Helper
{
    public static class Conversion
    {
        public static RoleViewModel ToVM(this Role obj)
        {
            if (obj == null) return null;
            return new RoleViewModel
            {
                Id = obj.Id,
                Name = obj.Name
            };
        }

        public static UserViewModel ToVM(this User obj)
        {
            if (obj == null) return null;
            return new UserViewModel
            {
                Id = obj.Id,
                Name = obj.Name,
                Username = obj.Username,
                Password = "",
                RoleId = obj.RoleId,
                Role = obj.Role.ToVM()
            };
        }
    }
}
