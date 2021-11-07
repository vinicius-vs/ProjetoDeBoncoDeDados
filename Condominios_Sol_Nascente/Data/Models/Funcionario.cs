using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    class Funcionario
    {
        public Condominio condominio { get; set; }
        public string cpf { get; set; }
        public string turno { get; set; }
        public string funcao { get; set; }
        public decimal salario { get; set; }
    }
}
