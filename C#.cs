Console.WriteLine("Digite um número de 1 a 3:");
    string entrada = Console.ReadLine();
    int numero = Convert.ToInt32(entrada);
    switch (numero)
{
    case 1:
        Console.WriteLine("Você digitou UM");
        break;

    case 2: Console.WriteLine("Você digitou DOIS");
        break;

    case 3: Console.WriteLine("Você digitou TRÊS");
        break;


    default:
        Console.WriteLine("Número Inválido!Digite apenas 1,2,3");
}
