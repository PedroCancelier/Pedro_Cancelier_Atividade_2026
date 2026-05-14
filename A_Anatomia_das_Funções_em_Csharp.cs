using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
Console.Write("óla, vamos caluclar quanto dará a soma das duas armas\n");

Console.Write("Digite o valor do primeiro equipamento:");
int arma1 = lerMoedas();
if (arma1 == 0)
{
    Console.WriteLine($"tentativa de goblin");
    Thread.Sleep(500);
    return;
}
Console.Write("Digite o valor do segundo equipamento:");
int arma2 = lerMoedas(); 


int resultado = SomarEquipamentos(arma1, arma2);

Console.WriteLine($"O preço final dos equipamentos é: {resultado} moedas!");


int lerMoedas()

{
    if (int.TryParse(Console.ReadLine(), out int n))
    {
        return n;
    }
   else { return 0; }
}

int SomarEquipamentos ( int arma1, int arma2)
{
return arma1 + arma2;
}

