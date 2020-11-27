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
                Console.WriteLine("Bem vindo(a) ao sistema de produtos!");
                Console.WriteLine("Escolha o que você deseja fazer: ");
                Console.WriteLine("[1] - Cadastrar Produto\n[2] - Listar os produtos\n[3] - Sair do menu");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Página de cadastro de produtos.");
                        do
                        {
                            if(contador < 10)
                            {                            
                            Console.WriteLine($"Digite o nome do {contador + 1}º produto");
                            nome[contador] = Console.ReadLine();
                            Console.WriteLine($"O produto está em promoção? Sim/Não");
                            promocao[contador] = Console.ReadLine();

                            contador++;
                            }else{
                                Console.WriteLine("Número de produtos excedidos");
                                break;
                            }
                            Console.WriteLine("Quer registrar mais produtos? s/n");
                            resposta = Console.ReadLine();
                            
                        } while (resposta == "s");

                        break;
                    case 2:
                    for (var i = 0; i < contador; i++){
                        
                        Console.WriteLine($"Seu {i+1}º produto é: {nome[i]}");
                        Console.WriteLine($"Esse produto tem promoção? {promocao[i]}");
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
