using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM
{
    public interface IIdentityUser
    {
        String Email { get; set; }
        String Password { get; set; }
    }
}