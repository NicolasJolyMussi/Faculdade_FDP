int contador = 1;
while (contador <= 5)
{
    Console.WriteLine("Número:" + contador);
    contador++;
}
Console.WriteLine("Contagem finalizada.");
------------------------------------------------

string comando = "";

Console.WriteLine("Exemplo 4: testando com entrada de dados");

while (comando != "sair")
{
    Console.WriteLine("Digite um comando qualquer (ou digite 'sair' para encerrar):");
    comando = Console.ReadLine();
    Console.WriteLine("Você digitou:" + comando);
}
Console.WriteLine("Programa Encerrado.");
------------------------------------------------------------------------------------------- a mesma coisa só que tem o To.Upper para deixa a letra maiuscula

string comando = "";

Console.WriteLine("Exemplo 4: testando com entrada de dados");

while (comando.ToUpper() != "SAIR")
{
    Console.WriteLine("Digite um comando qualquer (ou digite 'sair' para encerrar):");
    comando = Console.ReadLine();
    Console.WriteLine("Você digitou:" + comando);
}
Console.WriteLine("Programa Encerrado.");
