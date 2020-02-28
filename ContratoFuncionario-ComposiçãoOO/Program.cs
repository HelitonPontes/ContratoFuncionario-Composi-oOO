using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContratoFuncionario_ComposiçãoOO.Entidade;


namespace ContratoFuncionario_ComposiçãoOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("XXXXXXXXXXXXXXX----Contrato Funcionario----XXXXXXXXXXXXXXXXXX");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");

            Console.Write("Departamento>: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nome>:");
            string nome = Console.ReadLine();
            Console.Write("Idade>:");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Base salario>: ");
            double salariobase = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.Write("Nivel (Jr)(Pleno)(Senior)>: ");
            string nivel = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");

            Departamento dep = new Departamento(departamento);

            NivelTrabalhador nivelTrabalhador = new NivelTrabalhador(nivel);

            Funcionario funcionario = new Funcionario(nome, idade, salariobase, nivelTrabalhador, dep);

            
            Console.Write("Quantos Contratos>: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; n > i; i ++)
            {
                Console.WriteLine("Horas Contrato>: ");
                int HrsC = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor Hora Contrato>: ");
                double VHC = double.Parse(Console.ReadLine());
                DateTime dt = DateTime.Now;

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("-------------------------------------------------");


                Contratofuncionario contratofuncionario = new Contratofuncionario(dt, HrsC, VHC);

                Console.WriteLine(contratofuncionario.ValoTotalPContrato());

                funcionario.AdicionarContrato(contratofuncionario);


                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("-------------------------------------------------");

                
            }



            Console.WriteLine("--------------------Reultado---------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.Idade);
            Console.WriteLine(funcionario.NivelTrabalhador.nivel1);
            Console.WriteLine(funcionario.SalarioBase);
            Console.WriteLine(funcionario.Departamento.DepartamentoNome);

           
           

            Console.ReadKey();

        }
    }
}
