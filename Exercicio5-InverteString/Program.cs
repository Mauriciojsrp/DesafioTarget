Console.WriteLine("Digite a String: ");
char[] texto = Console.ReadLine().ToCharArray();

for (int i = 0; i < texto.Length / 2; i++)
{
    var caracter = texto[i];
    texto[i] = texto[texto.Length - i - 1];
    texto[texto.Length - i - 1] = caracter;
}

Console.WriteLine($"A string invertida é: {new string(texto)}");