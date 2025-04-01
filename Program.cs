using System;

class Program
{
    static void Main()
    {
         Carro carro1 = new Carro();
        int opcao;
        do
        {
            Menu.ExibirMenu(); 
            opcao = int.Parse(Console.ReadLine());
            
            Opcoes.ExecutarOpcao(opcao, carro1); 

        } while (opcao != 0);
    }
}
