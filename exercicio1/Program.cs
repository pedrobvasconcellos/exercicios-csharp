Console.WriteLine("Questão a");
Console.WriteLine();

string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Manga",
        "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"};

Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[8]);

Console.WriteLine();
Console.WriteLine("Questão b");
Console.WriteLine();

frutas[2] = "Kiwi";
frutas[9] = "Caqui";

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(frutas[i]);
}

Console.WriteLine();
Console.WriteLine("Questão c");
Console.WriteLine();

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine(i);
}

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

Console.WriteLine();
Console.WriteLine("Questão d");
Console.WriteLine();

Array.Sort(frutas);

foreach (string fruta in frutas)
{ 
    Console.WriteLine(fruta); 
}

Console.WriteLine();
Console.WriteLine("Questão e");
Console.WriteLine();

Array.Reverse(frutas);

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}