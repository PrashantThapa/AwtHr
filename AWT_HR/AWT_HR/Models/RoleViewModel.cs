using System;
using System.Collections.Generic;

namespace AppHealth.Models
{
    public class RoleViewModel:BaseViewModel
    {
        public string Name { get; set; }

        public static implicit operator RoleViewModel(List<RoleViewModel> v)
        {
            throw new NotImplementedException();
        }
    }
}
