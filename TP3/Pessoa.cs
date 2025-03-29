namespace TP3;

public class Pessoa
{
    public string Nome;
    public int Idade;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos");
    }
}