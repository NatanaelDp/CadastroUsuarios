using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios
{
    internal class Program
    {
        static List<string> nomes = new List<string>();
        static void Main(string[] args)
        {
            bool continuar = true;
            string op1 = "1 - Cadastrar";
            string op2 = "2 - Buscar";
            string op3 = "3 - Deletar";
            string op4 = "4 - Alterar";
            string op5 = "5 – Listar usuários";
            string op6 = "6 - Sair";
            while (continuar)
                
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine(op1);
                Console.WriteLine(op2);
                Console.WriteLine(op3);
                Console.WriteLine(op4);
                Console.WriteLine(op5);
                Console.WriteLine(op6);

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarUsuario();
                        break;
                    case 2:
                        BuscarUsuario();
                        break;
                    case 3:
                        DeletarUsuario();
                        break;
                    case 4:
                        AlterarUsuario();
                        break;
                    case 5:
                        ListaUsuarios();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Digite novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CadastrarUsuario()
        {
            Console.WriteLine("Digite o nome do novo usuário:");
            string nome = Console.ReadLine();
            nomes.Add(nome);
            Console.WriteLine($"{nome} cadastrado com sucesso!");
        }

        static void BuscarUsuario()
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("A lista está vazia ainda...");
                return;
            }

            Console.WriteLine("Digite o índice do usuário que deseja buscar:");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < nomes.Count)
            {
                string nome = nomes[indice];
                Console.WriteLine("Nome do usuário na posição {0}: {1}", indice, nome);
            }
            else
            {
                Console.WriteLine("Essa posição não existe");
            }
        }

        static void DeletarUsuario()
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("A lista está vazia ainda...");
                return;
            }

            Console.WriteLine("Digite o índice do usuário que deseja deletar:");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < nomes.Count)
            {
                string nome = nomes[indice];
                nomes.RemoveAt(indice);
                Console.WriteLine($"Usuário {nome} deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Essa posição não existe");
            }
        }

        static void AlterarUsuario()
        {
            if (nomes.Count == 0)
            {
                Console.WriteLine("A lista está vazia ainda...");
                return;
            }

            Console.WriteLine("Digite o índice do usuário que deseja alterar:");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < nomes.Count)
            {
                string nomeAntigo = nomes[indice];

                Console.WriteLine("Digite o novo nome para o usuário:");
                string novoNome = Console.ReadLine();

                nomes[indice] = novoNome;
                Console.WriteLine($"Nome do usuário na posição {indice} alterado de {nomeAntigo} para {novoNome}");
            }
            else
            {
                Console.WriteLine("Essa posição não existe");
            }
        }

        static void ListaUsuarios()
        {
            int quantidade = nomes.Count;

            int contador = 0;
            while (contador < quantidade)
            {
                Console.WriteLine("Nome:" + nomes[contador]);
                contador += 1;
            }
        }
    }
}


