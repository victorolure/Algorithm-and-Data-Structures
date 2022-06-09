
Console.WriteLine("QUESTION 1");
List<int> MaxNumbersInLists(List<List<int>> List)
{
    
    List<int> ints = new List<int>();
    for (int i = 0; i < List.Count; i++)
    {
        ints.Add(List[i].Max());
    }
    return ints;
}

List<List<int>> numbersList = new List<List<int>> { new List<int>() { 1, 5, 3 }, new List<int>() { 9, 7, 3, -2 }, new List<int> { 2, 1, 2 } };

List<int> maxList = MaxNumbersInLists(numbersList);

for(int i = 0; i < maxList.Count; i++)
{
    Console.WriteLine(maxList[i]);
}


Console.WriteLine("\n");
Console.WriteLine("QUESTION 2");


string HighestGrade(List<List<int>> List)
{
    int maxValue = 0;
   
    for (int i = 0; i < List.Count; i++)
    {
        if(List[i].Max() > maxValue)
        {
            maxValue = List[i].Max();
        }
    }
    return $"The highest grade is {maxValue}";
}

List<List<int>> Grades = new List<List<int>> { new List<int>() { 85, 92, 67, 94, 94 }, new List<int>() { 50, 60, 57, 95 }, new List<int> { 95 } };
Console.WriteLine(HighestGrade(Grades));


Console.WriteLine("\n");
Console.WriteLine("QUESTION 3");

List<int> OrderByLooping(List<int>lists)
{
    List<int> list = new List<int>();
    int[] intArray = lists.ToArray();
    Array.Sort(intArray);
    foreach (int i in intArray)
    {
        list.Add(i);
    } 
    return list;
}

List<int> numList = new List<int> { 6, -2, 5, 3 };

List<int> testlist = OrderByLooping(numList);

for(int i = 0; i < testlist.Count; i++)
{
    Console.WriteLine(testlist[i]);
}


Console.WriteLine("\n");
Console.WriteLine("BONUS");


// Zach, I honestly didn't understand bubble sort's complexity but I got it to work.
List<int> BubbleSort(List<int> list)
{
    int[] arr = list.ToArray();
    int temp = 0;
    List<int> list2 = new List<int>();

    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j + 1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
        }
    }
    for (int i = 0; i < arr.Length; i++)
    {
        list2.Add(arr[i]);
    }
    return list2;
}

List<int> intList = new List<int> { 6, -2, 5, 3 };
List<int> intList2 = BubbleSort(intList);

for (int i = 0; i < intList2.Count; i++)
{
    Console.WriteLine(intList2[i]);
}
