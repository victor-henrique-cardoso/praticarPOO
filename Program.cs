using System;

class Programa
{
    static void Main()
    {
        Carro carro1 = new Carro();
        carro1.marca= "BMW";
        carro1.modelo= "n sei um modelo";
        carro1.ano=2024;

        carro1.ExibirInformacoes();
    }
}