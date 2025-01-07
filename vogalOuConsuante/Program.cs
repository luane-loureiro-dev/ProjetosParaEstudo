string letra;

Console.WriteLine("Vou te dizer se vc digitou uma consoante ou uma vogal.");

do
{
    Console.WriteLine("Digite uma letra: ");
    letra = Console.ReadLine();

    letra = letra.ToUpper();

    if (letra.Length != 1)
    {
        Console.WriteLine("Entrada inválida! Digite apenas uma letra.");
    }
    else if (
                letra == "0" ||
                letra == "1" ||
                letra == "2" ||
                letra == "3" ||
                letra == "4" ||
                letra == "5" ||
                letra == "6" ||
                letra == "7" ||
                letra == "8" ||
                letra == "9"
            )
    {
        Console.WriteLine($"Isso não é uma letra, é um número!");
    }

    else
    {

        if (
            letra == "A" ||
            letra == "E" ||
            letra == "I" ||
            letra == "O" ||
            letra == "U"
            )
        {
            Console.WriteLine($"A letra {letra} é uma Vogal!");
        }

        else
        {
            Console.WriteLine($"A letra {letra} é uma Consoante!");
        }

    }
}
while (
    letra.Length != 1 ||
    letra == "0" ||
    letra == "1" ||
    letra == "2" ||
    letra == "3" ||
    letra == "4" ||
    letra == "5" ||
    letra == "6" ||
    letra == "7" ||
    letra == "8" ||
    letra == "9");


