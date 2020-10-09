using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace hlm_datalayer.Context
{

    // for various way to manage Design-Time DbContext Creation
    // Refer to: https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation
    class ContextFactory : IDesignTimeDbContextFactory<AppContext>
    {
        public AppContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder();
            //options.UseSqlite(@"Data Source=Data\lib.sqlite");
            options.UseSqlServer(@"Server=DESKTOP-ALH87KQ;Database=HLMS;Trusted_Connection=True;");
            options.UseLazyLoadingProxies(); // disable by passing `false` as a parameter.

            return new AppContext(options.Options);
        }
    }
}
