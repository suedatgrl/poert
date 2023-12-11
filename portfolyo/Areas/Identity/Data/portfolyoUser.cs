using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace portfolyo.Areas.Identity.Data;

// Add profile data for application users by adding
// properties to the portfolyoUser class
public class portfolyoUser : IdentityUser
{
    public string? FirstName { get; set; }

    public string? LastName{ get; set;}

    public string? EmailAddress{ get; set;}

    public string? Password{ get; set;}

    public string? Saved { get; set;}

}

