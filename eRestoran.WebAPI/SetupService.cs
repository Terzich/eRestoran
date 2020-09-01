using eRestoran.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI
{
    public class SetupService
    {
        public static void Seed(eRestoranContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
