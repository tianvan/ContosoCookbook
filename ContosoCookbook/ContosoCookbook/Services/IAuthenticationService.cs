using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoCookbook.Services
{
    public interface IAuthenticationService
    {
        bool Login(string userName, string password);
    }
}
