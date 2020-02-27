using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenRedirect.Models
{
    public class LoginModelDBContext : DbContext
    {
        public LoginModelDBContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<LoginModel> LoginModels { get; set; }
    }
}
