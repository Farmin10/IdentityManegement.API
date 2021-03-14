using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistance
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }

    }
}
