float[] grupo1 = new float[5];
float[] grupo2 = new float[5];

float media1 = 0, media2 = 0;

Console.WriteLine("Digite a nota dos alunos do grupo 1: ");

for (int i = 0; i < grupo1.Length; i++)
{
    grupo1[i] = float.Parse(Console.ReadLine());

    media1 += grupo1[i];
}

media1 /= grupo1.Length;

Console.WriteLine("Digite a nota dos alunos do grupo 2: ");

for (int i = 0; i < grupo2.Length; i++)
{
    grupo2[i] = float.Parse(Console.ReadLine());

    media2 += grupo2[i];
}

media2 /= grupo2.Length;

Console.WriteLine($"Média do grupo 1: {media1}");
Console.WriteLine($"Média do grupo 2: {media2}");