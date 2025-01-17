﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripsAPI.TripsEnum;

namespace TripsAPI.ViewModels
{
    public class RegisterInputModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public GenderType GenderType { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
