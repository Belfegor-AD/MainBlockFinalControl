string[] CreateArray()
{
    Console.Write("Введите элементы массива через запятую: ");
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

Console.Clear();
string[] filteredArray = FilterArray(CreateArray());

Console.Write("Результат: [");
for (int i = 0; i < filteredArray.Length; i++){
    if (i < filteredArray.Length - 1)
        Console.Write(filteredArray[i] + ", ");
    else
        Console.Write(filteredArray[i]);
}
Console.Write("]");