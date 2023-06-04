using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCSharp04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Empresa MaxAlteirTesla possui 40.000 funcionários.
            // O setor de RH precisa ter controle dos funcionários, como:
            // Média de salário de cada setor
            // Registro de tempo por setor
            // Listagem de funcionários por setor

            List<Funcionario> funcionarios = new List<Funcionario>();

            while(true)
            {
                Console.WriteLine("Controle do RH da empresa MaxAlteirTesla.");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1 - Registrar funcionário");
                Console.WriteLine("2 - Calcular média salarial por setor");
                Console.WriteLine("3 - Listar funcionários por setor");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RegistrarFuncionario(funcionarios);
                        break;
                    case "2":
                        CalcularMediaSalarialPorSetor(funcionarios);
                        break;
                    case "3":
                        ListarFuncionariosPorSetor(funcionarios);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void RegistrarFuncionario(List<Funcionario> funcionarios)
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o setor do funcionário: ");
            string setor = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            funcionarios.Add(new Funcionario { Nome = nome, Setor = setor, Salario = salario });

            Console.WriteLine("Funcionário registrado com sucesso!");
        }

        static void CalcularMediaSalarialPorSetor(List<Funcionario> funcionarios)
        {
            Console.Write("Digite o setor para calcular a média salarial: ");
            string setor = Console.ReadLine();

            decimal somaSalarios = 0;
            int contador = 0;

            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario.Setor == setor)
                {
                    somaSalarios += funcionario.Salario;
                    contador++;
                }
            }

            if (contador > 0)
            {
                decimal mediaSalarial = somaSalarios / contador;
                Console.WriteLine($"Média salarial do setor {setor}: {mediaSalarial:C}");
            }
            else
            {
                Console.WriteLine($"Não há funcionários registrados no setor {setor}.");
            }

        }

        static void ListarFuncionariosPorSetor(List<Funcionario> funcionarios)
        {
            Console.Write("Digite o setor para listar os funcionários: ");
            string setor = Console.ReadLine();

            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario.Setor == setor)
                {
                    Console.WriteLine($"Nome:  {funcionario.Nome}, Salário: {funcionario.Salario:C}");
                }
                else
                {
                    Console.WriteLine($"Não há funcionários registrados no setor {setor}.");
                }
            }
        }
    }
}
