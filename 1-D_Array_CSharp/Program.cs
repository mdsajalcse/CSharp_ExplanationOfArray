// CSharp 1 Dimensional Array


string[] names = new string[]
{
    "Rasel","Rahi","Sajal","Rana","Rafsa","Rakhi","Rani"
};
/*names[0] = "sajal";
names[1] = "Rana";
names[2] = "Raju";
names[3] = "Rajib";
names[4] = "Saleh";
names[5] = "Rajin";
names[6] = "Ratul";*/



int[] intArray = new int[]
{
    8, 9, 3, 4, 5, 6, 7
};

Array.Sort(intArray);
for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine(names[i]);
    Console.WriteLine("======");
    Console.WriteLine(intArray[i]);


}
Console.WriteLine("Arrays Dimensional::");
Console.WriteLine(intArray.Rank);
Console.WriteLine("Arrays Length::");
Console.WriteLine(intArray.Length);
Console.WriteLine("Arrays Number of Elements");




