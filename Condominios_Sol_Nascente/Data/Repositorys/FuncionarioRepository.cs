using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorys
{
    public class FuncionarioRepository: BaseRepository<Funcionario>
    {
        //create 
        /*
         * INSERT INTO Funcionarios  VALUES ('CPF','TURNO','FUNÇÃO',555.5,'NOME','ENDEREÇO',18)
         */

        //read
        /*
         * SELECT * FROM Funcionarios f 
         */

        //read by id
        /*
         * SELECT * FROM Funcionarios f   WHERE id = 12
         */

        //update
        /*
         * UPDATE Funcionarios SET turno = 'TODO DIA' WHERE id = 12
         */

        //delete
        /*
         *DELETE FROM Funcionarios WHERE id = 12  
         */
    }
}
