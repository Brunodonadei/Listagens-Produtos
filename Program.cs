using System;

namespace Atividade_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            float[] preco = new float[10];
            string[] promocao = new string[10];
            string resposta;
            int escolha;

            int contador = 0;

            
            do{
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Bem vindo(a) ao sistema de produtos!");
                Console.WriteLine("------------------------------------\n");
                Console.WriteLine("Escolha o que você deseja fazer: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("[1]");
                Console.ResetColor();
                Console.Write(" - Cadastrar Produto.\n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("[2]");
                Console.ResetColor();
                Console.Write(" - Listar os Produtos.\n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("[3]");
                Console.ResetColor();
                Console.Write(" - Sair do menu.\n");

                Console.Write("Sua resposta: ");

                Console.ForegroundColor = ConsoleColor.Blue;
                escolha = int.Parse(Console.ReadLine());
                Console.ResetColor();
                Console.WriteLine("------------------------------------");

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Página de cadastro de produtos.");
                        Console.WriteLine("------------------------------------");
                        do
                        {
                            if(contador < 10)
                            {                     
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write($"Digite o nome do {contador + 1}º produto: ");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            nome[contador] = Console.ReadLine();
                            Console.WriteLine("\n");


                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write($"O produto está em promoção? Sim/Não: ");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            promocao[contador] = Console.ReadLine();
                            Console.WriteLine("\n");

                            Console.ResetColor();

                            contador++;
                            }else{
                                Console.WriteLine("Número de produtos excedidos");
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("Quer registrar mais produtos? s/n: ");

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            resposta = Console.ReadLine();
                            Console.WriteLine("\n");
                            Console.ResetColor();
                            
                        } while (resposta == "s");

                        break;
                    case 2:
                    for (var i = 0; i < contador; i++){
                        
                        Console.WriteLine($"Seu {i+1}º produto é: {nome[i]}");
                        Console.WriteLine($"Esse produto tem promoção? {promocao[i]}\n");
                    }
                        break;
                    case 3:
                        Console.WriteLine("Saindo do programa");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (escolha != 3);
            {
                
            }
        }
    }
}
