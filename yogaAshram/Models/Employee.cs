﻿using Microsoft.AspNetCore.Identity;

namespace yogaAshram.Models
{
    public class Employee : IdentityUser
    {
        public string NameSurname { get; set; }
        public bool OnTimePassword { get; set; }
    }
}