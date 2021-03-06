﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iCONEXTWorkShop.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string CritizenId { get; set; }
        public DateTime BirthDay { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public int UserClassId { get; set; }
        public string UserClassName { get; set; }
    }
}