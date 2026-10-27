Console.WriteLine("~Atividade Tabuada~");

Console.WriteLine("Informe o número desejado:  ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int multiplicador = 0;
int resultado;

while ( multiplicador <= 10 );
{
resultado = numero * multiplicador;
Console.WriteLine($"{numero} x {multiplicador} = {resultado}");
multiplicador+=1;
}
