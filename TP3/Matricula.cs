namespace TP3;

public class Matricula
{
    public string NomeDoAluno;
    public string Curso;
    public int NumeroMatricula;
    public string Situacao;         
    public string DataInicial;
    
    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("===== Dados da Matrícula =====");
        Console.WriteLine($"Aluno: {NomeDoAluno}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
        Console.WriteLine($"Situação: {Situacao}");
        Console.WriteLine($"Data de Início: {DataInicial}");
        Console.WriteLine("================================");
    }
}