﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SSRD.IdentityUI.Account.Areas.Account.Models.Account
{
    public class AcceptInviteViewModel
    {
        public string FirstName { get; set; }
        [DisplayName("Last name")]

        public string LastName { get; set; }
        public string Password { get; set; }
        [DisplayName("Confirm password")]

        public string ConfirmPassword { get; set; }

        public string Code { get; set; }

        public AcceptInviteViewModel(string code)
        {
            Code = code;
        }
    }
}
