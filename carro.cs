using System;

class Carro {
    public string marca="";
    public string modelo="";
    public int ano;

    public void ExibirInformacoes(){
        Console.WriteLine($"Carro: {marca} Modelo: {modelo} Ano: {ano}");
    }
}