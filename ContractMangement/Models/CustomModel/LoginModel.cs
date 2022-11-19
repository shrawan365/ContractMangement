using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContractMangement.Models.CustomModel
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string error { get; set; }
    }
}