using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Scaffold_Test_User.Models;

namespace Scaffold_Test_User.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{   
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int reservationCount { get; set; } = 0;
   
}

