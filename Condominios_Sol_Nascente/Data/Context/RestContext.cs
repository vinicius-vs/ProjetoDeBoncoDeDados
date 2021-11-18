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
        public DbSet<Funcionario> funcionarios { get; set; }

        //public DbSet<Funcionario> fun { get; set; }

        public RestContext() : base("Data Source=192.168.0.104;Initial Catalog=master;Persist Security Info=True;User ID=SA;Password=myPassword")
        {



        }

    }
}
