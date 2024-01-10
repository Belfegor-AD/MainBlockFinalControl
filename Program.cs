string[] CreateArray()
{
    Console.WriteLine("Введите элементы массива через запятую: ");
    string input = Console.ReadLine()!;
    string[] array = input.Split(',');
    return array;
}

string[] FilterArray(string[] array)
{
    int count = 0;
    foreach(string i in array){
        if (i.Length <= 3){
            count++;
        }
    }

    int j = 0;
    string[] newArray = new string[count];
    foreach(string i in array){
        if (i.Length <= 3){
            newArray[j] = i;
            j++;
        }
    }
    return newArray;
}

// string[] inputArray = CreateArray();
// string[] filteredArray = FilterArray(inputArray);

Console.WriteLine("Результат:");
foreach (string i in FilterArray(CreateArray()))
{
Console.Write(i + ", ");
}