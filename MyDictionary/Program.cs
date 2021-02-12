using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> unit = new MyList<string>();
            unit.Add("Mathematics");
            unit.Add("Book");
            unit.Add("Pencil");


            foreach (var items in unit.Units)
            {
                Console.WriteLine(items);
            }

        }
    }
}
