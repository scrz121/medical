﻿using System.ComponentModel.DataAnnotations;

namespace Bravure.Models.TokenAuth
{
    public class AuthenticateModel
    {
        [Required]
        public string UserNameOrEmailAddress { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberClient { get; set; }
    }
}
