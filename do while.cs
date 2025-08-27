int numero;
int soma = 0 ;


do
{
    Console.Write("Digite um número (0 para sair): ");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
    Console.WriteLine("Soma é:" +soma);
}
while (numero != 0);
