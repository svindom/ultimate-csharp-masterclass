using System;
using System.Collections.Generic;
using System.Linq;

List<int> list = new List<int> { 1, 2, 3, 34,123,99,12 };
List<int> result = list.TakeEverySecond();

Console.WriteLine(string.Join(", ", result));

Console.ReadKey();

public static class ListExtensions
{
    public static List<int> TakeEverySecond(this List<int> list)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < list.Count; i += 2)
        {
            result.Add(list[i]);
        }
        return result;
    }
}
