//Three Dimensional Array in CSharp

string[,,] lunchItem = new string[3, 4, 4]
{
    { 
        {"beef","chicken","salad","bread" },
        {"Potato","Chicken","bread","sweet" },
        {"pasta","noodles","hotdok","banana" },
        {"Rosmalai","Naspati","pitha","hotCake"}
    },
    {
         {"beef","chicken","salad","bread" },
        {"Potato","Chicken","bread","sweet" },
        {"pasta","noodles","hotdok","banana" },
        {"Rosmalai","Naspati","milk","hotCake"}
    },
    {
        {"beef","chicken","salad","bread" },
        {"Potato","Chicken","bread","sweet" },
        {"pasta","noodles","hotdok","banana" },
        {"Rosmalai","Naspati","pitha","hotCake"}
    }
};

Console.WriteLine(lunchItem[0, 0, 0]);
Console.WriteLine(lunchItem[0, 0, 1]);
Console.WriteLine(lunchItem[0, 0, 2]);
Console.WriteLine(lunchItem[0, 0, 3]);


