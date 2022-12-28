//Exercício 1
/*
Console.Write("Digite sua senha: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 2022)
{
    Console.Write("Senha incorreta! Digite novamente: ");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Liberado!");
*/

//Exercício 2
/*
Console.Write("Digite o valor de x e y: ");
string[] coordenadas = Console.ReadLine().Split(' ');
int x = int.Parse(coordenadas[0]);
int y = int.Parse(coordenadas[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro quadrante");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo quadrante");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro quadrante");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Quarto quadrante");
    }
    Console.Write("Digite outras coordenadas: ");
    coordenadas = Console.ReadLine().Split(' ');
    x = int.Parse(coordenadas[0]);
    y = int.Parse(coordenadas[1]);
}
Console.WriteLine("Fora do plano");
*/

//Exercício 3
/*
Console.WriteLine("Digite os códigos:");
int alcool = 0;
int gasolina = 0;
int diesel = 0;

int produto = int.Parse(Console.ReadLine());

while (produto != 4)
{
    if(produto == 1)
    {
        alcool = alcool + 1;
    }
    else if(produto == 2)
    {
        gasolina = gasolina + 1;
    }
    else if(produto == 3)
    {
        diesel = gasolina + 1;
    }
    else
    {
        Console.WriteLine("Digite um código válido");
    }
    produto = int.Parse(Console.ReadLine());
}
Console.WriteLine("MUITO OBRIGADO!");
Console.WriteLine("Álcool: " +alcool);
Console.WriteLine("Gasolina: " +gasolina);
Console.WriteLine("Diesel: " +diesel);
*/