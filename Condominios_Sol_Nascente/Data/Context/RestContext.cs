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
         *  Cnpj NVARCHAR,
         *  nome NVARCHAR,
         *  endereco NVARCHAR
         *  )
         */
        public DbSet<Condominio> condominios{ get; set; }


        /*
         * CREATE TABLE  funcionarios (
         * id INT IDENTITY(1,1) PRIMARY KEY,
         * cpf NVARCHAR,
         * turno NVARCHAR,
         * funcao NVARCHAR,
         * salario DECIMAL(18,2),
         * nome NVARCHAR,
         * endereco NVARCHAR,
         * condominio_id INT FOREIGN KEY REFERENCES condominios(ID)
         * )
         */
        public DbSet<Funcionario> funcionarios { get; set; }

        public RestContext() : base("Data Source=192.168.0.104;Initial Catalog=master;Persist Security Info=True;User ID=SA;Password=myPassword")
        {



        }

    }
}
