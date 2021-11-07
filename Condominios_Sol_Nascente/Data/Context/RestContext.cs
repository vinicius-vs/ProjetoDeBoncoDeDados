using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class RestContext : DbContext
    {
        public DbSet<Condominio> condominio { get; set; }

        public RestContext() : base("Host=192.168.0.104;Database=postgres;Username=postgres;Password=74269;Persist Security Info=True")
        {

        }
    }
}
