using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Gestor_de_clientes_no_CMD_2
{
    
    internal class Program
    {
        [System.Serializable] 
        struct Cliente
        {
            public string nome;
            public string email;
            public string CPF;
        }
                  
        static List<Cliente> clientes = new List<Cliente>();

        enum Menu { Listagem=1, Adicionar=2, Remover=3, Sair=4 };

        static void Main(string[] args)
        {
            Carregar();
            bool escolheSair = false;
            while (!escolheSair)
            {

                Console.WriteLine("Seja Bem vindo ao sistema de Cadastro");
                Console.WriteLine("1-Listagem\n2-Adicionar\n3-Remover\n4-Sair");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                //Console.WriteLine(opcao);

                switch (opcao)
                {
                    case Menu.Listagem:
                        Listar();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Remover:
                        Remover();
                        break;
                    case Menu.Sair:
                        escolheSair=true;
                        break;
                }

                Console.Clear();
            }

            void Adicionar()
            {
                Cliente cliente = new Cliente();
                Console.WriteLine("Cadastre seus dados abaixo ");
                Console.WriteLine("Digite seu nome: ");
                cliente.nome = Console.ReadLine();
                Console.WriteLine("Digite seu e-mail: ");
                cliente.email = Console.ReadLine();
                Console.WriteLine("Digite seu CPF: ");
                cliente.CPF = Console.ReadLine();

                clientes.Add(cliente);
                Salvar();
                Console.WriteLine("Cadastro realizado com sucesso, tecle Enter para Sair");
                Console.ReadLine();
            }

            void Listar()
            {
                if (clientes.Count > 0)
                {
                    Console.WriteLine("Lista de clientes: ");
                    int id = 0;
                    foreach (Cliente cliente in clientes)
                    {
                        Console.WriteLine($"id: {id}");
                        Console.WriteLine($"Nome: {cliente.nome}");
                        Console.WriteLine($"e-mail: {cliente.email}");
                        Console.WriteLine($"CPF: {cliente.CPF}");
                        Console.WriteLine("=================");
                        id++;
                    }
                }
                else 
                {
                    Console.WriteLine("Lista Vazia");
                }

                Console.WriteLine("Tecle enter para sair");
                Console.ReadLine();
            }

            void Remover()
            {
                Listar();
                Console.WriteLine("Insira o id de quem você quer deletar");
                int id = int.Parse(Console.ReadLine());
                if(id >= 0 && id < clientes.Count)
                {
                    clientes.RemoveAt(id); 
                    Salvar();
                }
                else
                {
                    Console.WriteLine("Id digitado é inválido, tente novamente");
                    Console.ReadLine();
                }

            }
            
             
            void Salvar()
            {
                FileStream stream = new FileStream("arquivo.bin", FileMode.OpenOrCreate);
                BinaryFormatter encoder = new BinaryFormatter(); 

                encoder.Serialize(stream, clientes);
               
                stream.Close();
            
             }
            void Carregar()
            {
                
                FileStream stream = new FileStream("arquivo.bin", FileMode.OpenOrCreate);
               
                try
                {
                    BinaryFormatter encoder = new BinaryFormatter(); 
                                                                     
                    clientes = (List<Cliente>)encoder.Deserialize(stream);
                    
                    if(clientes == null)
                    {
                        clientes = new List<Cliente>();
                    }
                }
                catch(Exception e)
                {
                    
                    clientes = new List<Cliente>();
                }

                stream.Close();
            }
        }
    }
}
