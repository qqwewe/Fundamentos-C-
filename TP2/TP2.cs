namespace TP2;

public class TP2
{
    public static void EX01()
    {
        Console.WriteLine("Digite sua data de nascimento no formado dd/mm/aaaa");
        String birthday = Console.ReadLine();
        
        DateTime birthdayDateTime = DateTime.Parse(birthday);
        
        var today = DateTime.Today;

        var age = today.Year - birthdayDateTime.Year;

        if (birthdayDateTime.Date > today.AddYears(-age)) age--;
        
        Console.WriteLine("Você tem " + age + " anos");
    }
    public static void EX02()
    {
        Console.WriteLine("Digite sua data de nascimento no formado dd/mm/aaaa");
        String birthday = Console.ReadLine();
        
        DateTime birthdayDateTime = DateTime.Parse(birthday);
        DateTime currentBirthday = new DateTime(DateTime.Now.Year, birthdayDateTime.Month, birthdayDateTime.Day);

        TimeSpan nextBirthday;
        if (currentBirthday.Date > DateTime.Now)
        {
            nextBirthday = currentBirthday.Date - DateTime.Today;
        }
        else
        {
            nextBirthday = currentBirthday.Date.AddYears(1) - DateTime.Today;
        }
        
        Console.WriteLine("Faltam "+nextBirthday.TotalDays+" dias para seu próximo aniversário");
    }

    public static void EX03()
    {
        Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
        String input1 = Console.ReadLine();
        Console.WriteLine("Digite outra data no formado dd/mm/aaaa");
        String input2 = Console.ReadLine();
        
        DateTime date1 = DateTime.Parse(input1);
        DateTime date2 = DateTime.Parse(input2);
        TimeSpan difference;
        if (date1 > date2)
        {
            difference = date1 - date2;

        }
        else
        {
            difference = date2 - date1;
        }
        DateTime calculatedDate = DateTime.MinValue + difference;
        Console.WriteLine(calculatedDate.Day+" dias, "+calculatedDate.Month+" meses e "+calculatedDate.Year+" anos");
    }

    public static void EX04()
    {
        Console.WriteLine("Digite seu nome: ");
        String name = Console.ReadLine();
        Console.WriteLine("Digite sua idade: ");
        String idade = Console.ReadLine();
        Console.WriteLine("Digite seu telefone: ");
        String tel = Console.ReadLine();
        Console.WriteLine("Digite seu email: ");
        String email = Console.ReadLine();
        
        Console.WriteLine("Seu nome é " + name + "\nvocê tem " + idade + " de idade \nseu telefone é " + tel + "\ne seu email é " + email);
    }

    public static void EX05()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        string input = Console.ReadLine();
        
        double celsius = double.Parse(input);
        
        double fahrenheit = celsius * 9.0 / 5.0 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
        Console.WriteLine($"Kelvin: {kelvin:F2}");
    }

    public static void EX06()
    {
        Console.WriteLine("Digite sua altura");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());
        
        double imc = peso / (altura * altura);

        if (imc <= 18.5)
        {
            Console.WriteLine("Você está com baixo peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Você está com peso normal");

        }
        else if (imc < 30)
        {
            Console.WriteLine("Você está com sobrepeso");

        }
        else
        {
            Console.WriteLine("Você está com obesidade");
        }
    }

    public static void EX07()
    {
        Console.WriteLine("Digite um número inteiro");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine(((numero & 1) == 1) ? "Ímpar" : "Par");
    }

    public static void EX08()
    {
        Console.WriteLine("Digite uma nota entre 0 e 10");
        double nota = double.Parse(Console.ReadLine());

        if (nota <= 4.99)
        {
            Console.WriteLine("Insuficiente");
        }
        else if (nota < 7.00)
        {
            Console.WriteLine("regular");
        }
        else if (nota < 9.00)
        {
            Console.WriteLine("bom");
        }
        else
        {
            Console.WriteLine("excelente");
        }
    }

    public static void EX09()
    {
        Console.Write("Digite o salário bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());

        if (salarioBruto <= 2000)
        {
            Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"desconto: R$ {salarioBruto*0:F2}");
            Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
        }
        if (salarioBruto < 5000)
        {
            Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"desconto: R$ {salarioBruto*0.08:F2}");
            Console.WriteLine($"Salário bruto: R$ {salarioBruto*(1-0.08):F2}");
        }
        if (salarioBruto < 7500)
        {
            Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"desconto: R$ {salarioBruto*0.12:F2}");
            Console.WriteLine($"Salário bruto: R$ {salarioBruto*(1-0.12):F2}");
        }
        else
        {
            Console.WriteLine($"Salário bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"desconto: R$ {salarioBruto*0.225:F2}");
            Console.WriteLine($"Salário bruto: R$ {salarioBruto*(1-0.225):F2}");  
        }
    }

    public static void EX10()
    {
        Console.WriteLine("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            if (i > 0)
            {
                Console.Write($"{i},");
            }
            else
            {
                Console.Write(i);
            }
        }
    }

    public static void EX11()
    {
        Console.WriteLine("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero}x{i} = {numero * i}");
        }
    }

    public static void EX12()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 100);
        int guess = -1;
        while (guess != randomNumber)
        {
            Console.WriteLine("Digite o número que deseja adivinhar: ");
            guess = int.Parse(Console.ReadLine());
            if (guess > randomNumber)
            {
                Console.WriteLine("Muito alto tente um número menor");
            }
            else if (guess < randomNumber)
            {
                Console.WriteLine("Muito baixo tente um número maior");
            }
            else
            {
                Console.WriteLine("Adivinhou!");
            }
        }
    }
}