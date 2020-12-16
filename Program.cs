using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using POO_FolhaPagamento.Entities;

/*
 * CONTEÚDO DISPONÍVEL NA AULA DO DIA 16/11/20 (slides 24 e 25)
 * Uma empresa possui funcionários próprios e terceirizados. 
 * Para cada funcionário, deseja-se registrar nome, horas trabalhadas e valor por hora. 
 * Funcionários terceirizados possuem ainda uma despesa adicional
 * O pagamento dos funcionários corresponde ao valor da hora multiplicado pelas horas trabalhadas, 
 * sendo que os funcionários terceirizados ainda recebem um bônus correspondente a 110% de sua despesa adicional.
 * Ler os dados de N funcionários (N fornecido pelo usuário) e 
 * armazená-los em uma lista. Depois de ler todos os dados, 
 * mostrar nome e pagamento de cada funcionário na mesma ordem em que foram digitados.
 */
namespace POO_FolhaPagamento.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de informações
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //Criação da lista Empregados
            List<Empregados> list = new List<Empregados>();
            
            Console.WriteLine();
            //Criação do laço para inserção de dados conforme n
            for (int i = 1; i <= n; i++)
            {
                //Informa o número sequencial do funcionário
                Console.WriteLine($"Funcionário #{i}:");

                //Verificar se é terceirizado
                Console.Write("Terceirizado (s/n)?");
                string terceirizado = Console.ReadLine();

                //Solicita o nome do funcionário
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                //Solicita a quantidade de horas trabalhadas no mês
                Console.Write("Horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());

                //Solicita o valor do salario/hora do funcionário
                Console.Write("Salário por hora: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Verificação de Terceirizado
                if (terceirizado == "s")
                {
                    //funcionários terceirizados ainda recebem um bônus
                    //correspondente a 110% de sua despesa adicional
                    Console.Write("Adicional: ");
                    double adicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Terceirizados(nome, horas, adicional, salario));
                    //Empregados terceirizados = new Terceirizados();
                }
                else
                {
                    list.Add(new Empregados(nome, horas, salario));
                    //Empregados efetivos = new Empregados();
                }

                Console.WriteLine();

            }
            Console.WriteLine("Pagamentos:");

            foreach (Empregados empregados in list)
            {
                Console.WriteLine(empregados);
            }
            Console.WriteLine();
        }
    }
}