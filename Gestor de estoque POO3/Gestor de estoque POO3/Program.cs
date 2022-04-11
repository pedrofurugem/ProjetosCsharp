using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_estoque_POO3
{
    [System.Serializable]
    internal class Program
    {
        static List<IEstoque> produtos  = new List<IEstoque>(); 
        enum Menu { Listar=1, Adicionar=2, Remover=3, Entrada=4, Saida=5, Sair=6 }
        static void Main(string[] args)
        {
            Carregar();
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Bem vindo ao sistema de estoque");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Entrada\n5-Saída\n6-Sair do Sistema");
                string opcStr = Console.ReadLine();
                int opInt = int.Parse(opcStr);

                if(opInt > 0 && opInt < 7)
                {
                    Menu escolha = (Menu)opInt;
                    switch (escolha)
                    {
                        case Menu.Listar:
                            Listar();
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            Remover();
                            break;
                        case Menu.Entrada:
                            Entrada();
                            break;
                        case Menu.Saida:
                            Saida();
                            break;
                        case Menu.Sair:
                            escolheuSair = true; 
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }   

            void Listar()
            {
                Console.WriteLine("Lista de produtos");
                int id = 0;
                foreach(IEstoque produto in produtos)
                {
                    Console.WriteLine($"id: {id}");
                    produto.Exibir();
                    id++;
                }
                Console.ReadLine();
            }

            void Cadastro()
            {
                Console.WriteLine("Cadastro de Produtos, tecle as opções abaixo de 1 a 3");
                Console.WriteLine("1-Produto Físico\n2-Ebook\n3-Curso");
                int escolhe = int.Parse(Console.ReadLine());

                switch (escolhe)
                {
                    case 1:
                        ProdutoFisico();
                        break;
                    case 2:
                        Ebook();
                        break;
                    case 3:
                        Curso();
                        break;
                }

                void ProdutoFisico()
                {
                    Console.WriteLine("Cadastro do produto físico: ");
                    Console.WriteLine("nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("preço: ");
                    float preco = float.Parse(Console.ReadLine());
                    Console.WriteLine("frete: ");
                    float frete = float.Parse(Console.ReadLine());
                    ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
                    produtos.Add(pf);
                    Salvar();
                }

                void Ebook()
                {
                    Console.WriteLine("Cadastro do Ebook: ");
                    Console.WriteLine("nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("preço: ");
                    float preco = float.Parse(Console.ReadLine());
                    Console.WriteLine("autor: ");
                    string autor = Console.ReadLine();
                    Ebook ebk = new Ebook(nome, preco, autor);
                    produtos.Add(ebk);
                    Salvar();
                }

                void Curso()
                {
                    Console.WriteLine("Cadastro do Curso: ");
                    Console.WriteLine("nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("preço: ");
                    float preco = float.Parse(Console.ReadLine());
                    Console.WriteLine("autor: ");
                    string autor = Console.ReadLine();
                    Curso c = new Curso(nome, preco, autor);
                    produtos.Add(c);
                    Salvar();
                }
            }

            void Remover()
            {
                Listar();
                Console.WriteLine("digite o id do produto que deseja remover");
                int id = int.Parse(Console.ReadLine());
                if(id >= 0 && id <= produtos.Count)
                {
                    produtos.RemoveAt(id);
                }
                else
                {
                    Console.WriteLine("id inválido");
                    Console.ReadLine();
                }
            }

            void Entrada()
            {
                Listar();
                Console.WriteLine("Digite o id do produto que deseja alocar entrada");
                int id = int.Parse(Console.ReadLine());
                if(id >= 0 && id < produtos.Count)
                {
                    produtos[id].CadastrarEntrada();
                    Salvar();
                }
            }

            void Saida()
            {
                Listar();
                Console.WriteLine("Digite o id do produto para alocar saída");
                int id = int.Parse(Console.ReadLine());
                if (id >= 0 && id < produtos.Count)
                {
                    produtos[id].CadastrarSaida();
                    Salvar();
                }
            }

            void Salvar()
            {
                FileStream stream = new FileStream("arqv.bin", FileMode.OpenOrCreate);
                BinaryFormatter encoder = new BinaryFormatter();

                                 //escrever dentro do meu arquivo stream
                encoder.Serialize(stream, produtos);

                stream.Close();
            }

            void Carregar()
            {
                FileStream stream = new FileStream("arqv.bin", FileMode.OpenOrCreate);
                BinaryFormatter encoder = new BinaryFormatter();

                try
                {              //tipo de estoque  //dado recebido do arquivo
                    produtos = (List<IEstoque>)encoder.Deserialize(stream);

                    if(produtos == null)
                    {
                        produtos = new List<IEstoque>(); //se der errado cria uma nova lista
                    }
                }
                catch(Exception ex)
                {
                    produtos = new List<IEstoque>();
                }

                stream.Close();
            }
        }
    }
}
