List<string> fruits = new List<string>
{
    "Pineapple",
    "Strawberry",
    "Kiwi"
};
fruits.Add("Watermelon");

fruits.Remove("Strawberry");

Console.WriteLine("Fruits in the list:");
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

Dictionary<int, string> fruitList = new Dictionary<int, string>
{
    { 1, "Pineapple" },
    { 2, "Kiwi"},
    { 3, "Watermelon" }
};
fruitList.Add(4, "Blueberry");

Console.WriteLine("\nFruits in the dictionary:");
foreach (KeyValuePair<int, string> item in fruitList)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
