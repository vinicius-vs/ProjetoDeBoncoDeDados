using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorys
{
    public class CondominioRepository : BaseRepository<Condominio>
    {
        //create 
        /*
         * INSERT INTO Condominios
         *       VALUES ('cnpj',
         *               'nome',
         *               'so segue reto')
         */

        //read
        /*
         * SELECT * FROM   condominios c
         */

        //read by id
        /*
         * SELECT * FROM   condominios c WHERE  c.id = 19
         */

        //update
        /*
         * UPDATE condominios  SET endereco = 'sempre reto' WHERE  id = 19
         */

        //delete
        /*
         * DELETE FROM condominios WHERE  id = 19  
         */
    }
}
