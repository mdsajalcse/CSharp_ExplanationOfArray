// C# Explanation of Array



using System.Globalization;

string[][] arrayItem = new string [4][];


arrayItem[0] = new string[2];
arrayItem[1] = new string[3];
arrayItem[2]= new string[4];
arrayItem[3]= new string[5];

arrayItem[0][0] = "sajal";
arrayItem[0][1] = "Rajib";

int[] arr = new int[]
{
    2,1, 3, 4, 6, 5, 7, 8, 9, 10,
};

int[] arr1 = new int[]
{
    12,1, 3, 4, 76, 5, 17, 8, 9, 10,
};

Array.Copy(arr, arr1, arr.Length);
Console.WriteLine(arr[0]);

Array.Sort(arr);
Console.WriteLine(arr);
Console.WriteLine(arr[0]);
Array.Reverse(arr);
Console.WriteLine(arr);
Console.WriteLine(arr[0]);



Console.WriteLine(arrayItem[0][1]);

Console.WriteLine(arrayItem.Rank);

Console.WriteLine(arrayItem.GetLength(0));

Console.WriteLine(arrayItem.Length);
Console.WriteLine(arrayItem.GetType);
