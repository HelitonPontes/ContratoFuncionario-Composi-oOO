using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoFuncionario_ComposiçãoOO.Entidade
{
    class Departamento
    {
        public string DepartamentoNome { get; set; }


        public Departamento()
        {

        }

        public Departamento(string departamentoNome)
        {
            DepartamentoNome = departamentoNome;
        }
    }
    
}
