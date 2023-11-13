Console.WriteLine("Single Dimension Array:");

string[] singleDimArray=new string[]
{
    "Ifthekar Sajal","Rana","Rasel","Rajib","Rakesh"
};

foreach (string names in singleDimArray)
{
    Console.WriteLine(names);
}
Console.WriteLine(".....................");
Console.WriteLine("Multi Dimensional Array:");

string[,] multDimensionalArray = new string[2, 3]
{
    { "Rani","Rafa","Rafsana" },
    { "Rahat","Rasul","Raha" }
};
foreach (string multiArrayNames in multDimensionalArray)
{
    Console.WriteLine(multiArrayNames);
}
Console.WriteLine(".....................");
Console.WriteLine("Jagged Array:");

int[][] jaggedArray = new int[][]
{
    new int[]
    {
        2,
        13,
        29
    },
    new int[]
    {
        14,
        12,
        11,
        15,
        54
    },
    new int[]
    {
        20,
        30,
        40,
        26,
        27

    },
    new int[]
    {
        1,
        21,
        26,
        29,
        28,
        100
    }

};

 for(int i = 0; i < jaggedArray.Length; i++)
{
    Console.WriteLine("Elements:"+(i));
    for(int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine(jaggedArray[i][j]);
    }
}