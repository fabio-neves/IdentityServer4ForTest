using IdentityServer4.Models;
using IdentityServer4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Test
{
    public class TceProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            context.IssuedClaims.Add(new Claim("helloworld","hey hoo"));
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            context.IsActive = true;            
        }
    }
}
