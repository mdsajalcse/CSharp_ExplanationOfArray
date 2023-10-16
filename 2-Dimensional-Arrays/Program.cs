//Two Dimensional Arrays

string [,] dinnerItem = new string[,]
{
    {"Rice","Alu","Vegetables","Fish" },

    {"Tomato","Fulkopi","Shim","Badhakopi"},

    {"Onion","pasta","sweet","bread" }

};

 

for(int i = 0; i < dinnerItem.Length; i++)
{


    Console.WriteLine(dinnerItem[0][1]);
}


