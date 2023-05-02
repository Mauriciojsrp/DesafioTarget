Console.WriteLine("Digite um número: ");
int valorEntrada = int.Parse(Console.ReadLine());

int n1 = 0, n2 = 1;
int SOMA = 0;
bool ehFibonacci = false;

while (SOMA < valorEntrada)
{
    SOMA = n1 + n2;
    n1 = n2;
    n2 = SOMA;

    if (SOMA == valorEntrada)
        ehFibonacci = true;
}

if (ehFibonacci)
    Console.WriteLine("O número informado pertence a sequencia de Fibonacci");
else
    Console.WriteLine("O número informado NÃO pertence a sequencia de Fibonacci");

