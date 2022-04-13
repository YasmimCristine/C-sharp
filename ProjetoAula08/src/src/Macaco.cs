using System;

class Macaco
{
    public string nome;
    public string cor;
    public string tamanho;
    public string corOlho;

    public Macaco (string _nome, string _cor, string _tamanho, string _corOlho)
{
    nome = _nome;
    cor = _cor;
    tamanho = _tamanho;
    corOlho = _corOlho;
}
public void fala()
{
    Console.WriteLine("Cesar esta em casa!");
}
public void poder()
{
    Console.WriteLine("Eu sou o rei dos macacos");
}
public void som()
{
    Console.WriteLine("u u á á");

}

}
