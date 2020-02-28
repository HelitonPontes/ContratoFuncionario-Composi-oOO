using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoFuncionario_ComposiçãoOO.Entidade
{
    class NivelTrabalhador
    {
        public string nivel1 { get; set; }
      
        public NivelTrabalhador()
        {

        }

        public NivelTrabalhador(string nivel1)
        {
            this.nivel1 = nivel1;
        }
    }
}
