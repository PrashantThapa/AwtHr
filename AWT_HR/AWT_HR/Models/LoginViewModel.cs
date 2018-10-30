﻿using System.ComponentModel.DataAnnotations;

namespace AppHealth.Models
{
    public class LoginViewModel: BaseViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public LoginViewModel()
        {
            ErrorMessage = "";
        }
    }
}
