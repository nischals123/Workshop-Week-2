int[] favNumbers = { 8, 3, 15, 1, 10 };

Array.Sort(favNumbers);
Array.Reverse(favNumbers);

Console.WriteLine(" Favorite Numbers ");
for (int i = 0; i < favNumbers.Length; i++)
{
    Console.WriteLine($"Element {i}: {favNumbers[i]}");
}

int position = Array.IndexOf(favNumbers, 10);
Console.WriteLine($"\nThe position of number 10 is: {position}");
