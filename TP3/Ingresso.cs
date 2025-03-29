namespace TP3;

public class Ingresso
{
    public string nomeDoShow;

    public double preco;

    public int quantidadeDisponivel;
   
    public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        this.nomeDoShow = nomeDoShow;
        this.preco = preco;
        this.quantidadeDisponivel = quantidadeDisponivel;
    }
    
    public string GetNomeDoShow()
    {
        return nomeDoShow;
    }

    public double GetPreco()
    {
        return preco;
    }

    public int GetQuantidadeDisponivel()
    {
        return quantidadeDisponivel;
    }

    public void SetNomeDoShow(string novoNome)
    {
        nomeDoShow = novoNome;
    }

    public void SetPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    public void SetQuantidadeDisponivel(int novaQtd)
    {
        quantidadeDisponivel = novaQtd;
    }
    

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Show: {nomeDoShow}");
        Console.WriteLine($"Preço: R${preco:F2}");
        Console.WriteLine($"Quantidade Disponível: {quantidadeDisponivel}");
    }
}