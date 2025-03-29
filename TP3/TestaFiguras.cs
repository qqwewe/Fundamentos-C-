namespace TP3;

public class TestaFiguras
{
    public static void Main(string[] args)
    {
        Circulo circulo = new Circulo();
        circulo.Raio = 3.0;
        double area = circulo.CalcularArea();
        Console.WriteLine("=== Círculo ===");
        Console.WriteLine($"Raio: {circulo.Raio}");
        Console.WriteLine($"Área: {area:F2}");
        
        Esfera esfera = new Esfera();
        esfera.Raio = 5.0;
        double volume = esfera.CalcularVolume();
        Console.WriteLine("\n=== Esfera ===");
        Console.WriteLine($"Raio: {esfera.Raio}");
        Console.WriteLine($"Volume: {volume:F2}");
    }
}