using System;

class Opcoes
{
    public static void ExecutarOpcao(int opcao, Carro carro1)
    {
        switch (opcao)
        {
            case 0:
                Console.WriteLine("Saindo...");
                break;
            case 1:
                Console.WriteLine("Opção de adicionar carro selecionada!");

                Console.Write("Digite a marca do carro: ");
                carro1.marca = Console.ReadLine();

                Console.Write("Digite o modelo do carro: ");
                carro1.modelo = Console.ReadLine();

                Console.Write("Digite o ano do carro: ");
                carro1.ano = int.Parse(Console.ReadLine());
                break;

            case 2:
                Console.WriteLine("Opção de exibir informações do carro selecionada!");
                carro1.ExibirInformacoes();
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
