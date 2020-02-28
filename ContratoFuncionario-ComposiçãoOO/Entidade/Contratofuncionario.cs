using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoFuncionario_ComposiçãoOO.Entidade
{
    class Contratofuncionario
    {
        public DateTime Data { get; set; }
        public int HrsTrabalhada { get; set; }
        public double ValorHrsContrato { get; set; }
        public double ValorTotal { get; set; }

        

        public Contratofuncionario()
        {


        }

        public Contratofuncionario(DateTime data, int hrsTrabalhada, double valorHrsContrato)
        {
            Data = data;
            HrsTrabalhada = hrsTrabalhada;
            ValorHrsContrato = valorHrsContrato;
           // ValorTotal = valorTotal;
        }

        public double  ValoTotalPContrato()
        {
            ValorTotal = ValorHrsContrato * HrsTrabalhada;
             return ValorHrsContrato * HrsTrabalhada;

        }





    }
}
