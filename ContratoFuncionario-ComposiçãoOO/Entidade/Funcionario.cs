using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoFuncionario_ComposiçãoOO.Entidade;


namespace ContratoFuncionario_ComposiçãoOO.Entidade
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double SalarioBase { get; set; }
        public NivelTrabalhador NivelTrabalhador { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contratofuncionario> Contratofuncionarios { get; set; } = new List<Contratofuncionario>();


        public Funcionario()
        {

        }

        public Funcionario(string nome, int idade, double salarioBase, NivelTrabalhador
            nivelTrabalhador, Departamento departamento)
        {
            Nome = nome;
            Idade = idade;
            SalarioBase = salarioBase;
            NivelTrabalhador = nivelTrabalhador;
            Departamento = departamento;
        }

        public void  AdicionarContrato (Contratofuncionario contratofuncionario)
        {
            Contratofuncionarios.Add(contratofuncionario);
        }

        public void removerContrato (Contratofuncionario contratofuncionario)
        {
            Contratofuncionarios.Remove(contratofuncionario);

        }

        public double  GanhoTotal()
        {

            double Gt = SalarioBase;
            foreach (Contratofuncionario contratofuncionario  in Contratofuncionarios)
            {
               Gt= contratofuncionario.ValorTotal++;
            }
            SalarioBase = Gt;
            return Gt;
        }

    }
}
