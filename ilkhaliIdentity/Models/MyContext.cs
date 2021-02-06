
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ilkhaliIdentity.Models
{
    public class MyContext: IdentityDbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }



        


    }
}
