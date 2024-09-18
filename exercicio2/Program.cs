int len, valores;

Console.WriteLine("Digite a quantidade de elementos do Array");
len = int.Parse(Console.ReadLine());
int[] ints = new int[len];

for (int i = 0; i < ints.Length; i++)
{
        Console.WriteLine("Elemento número :" + i);
        ints[i] = int.Parse(Console.ReadLine());
}

    char resposta;
    bool encontrado = false;

do
{
    Console.WriteLine("Digite o valor que deseja buscar:");
    int busca = int.Parse(Console.ReadLine());

    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] == busca)
        {
            encontrado = true;
            break;
        }
    }

    if (encontrado == true)
    {
        Console.WriteLine("O valor " + busca + " existe no array");
    }
    else
    {
        Console.WriteLine("O valor " + busca + " não existe no array");
    }

    Console.WriteLine("'c' continuar, 'p' parar");
    resposta = char.Parse(Console.ReadLine().ToLower());

} while (resposta == 'c');

Console.WriteLine("Fim");

