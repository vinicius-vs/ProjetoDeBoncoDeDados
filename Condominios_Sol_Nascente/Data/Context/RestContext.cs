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
        /*
         *  CREATE TABLE condominios(
         *  ID INT IDENTITY(1,1) PRIMARY KEY,
         *  Cnpj VARCHAR(255),
         *  nome VARCHAR(255),
         *  endereco VARCHAR(255)
         *  )
         */
        public DbSet<Condominio> condominios{ get; set; }

        public RestContext() : base("server=192.168.0.104;Database=postgres;User ID=postgres;Password=74269;Persist Security Info=True")
        {


        }

    }
}
