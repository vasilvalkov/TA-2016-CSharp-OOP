namespace DefineClasses2
{
    using GenericClass;
    using System;

    static class GenericClassTest
    {
        public static void Run()
        {
            Console.WriteLine("--- Create generic list ---");
            var myList = new GenericList<int>(4);
            myList.Add(2);
            myList.Add(4);
            myList.Add(8);
            myList.Add(16);

            Console.WriteLine("List capacity is: {0}", myList.Capacity);
            Console.WriteLine("List elements count is: {0}", myList.Count);
            Console.WriteLine("List elements: {{ {0} }}", myList);
            Console.WriteLine("Element at index 2 is: {0}", myList[2]);
            Console.WriteLine();

            Console.WriteLine("--- Resize list and add new elements ---");
            myList.Add(32);
            myList.Add(64);
            Console.WriteLine("List capacity is now : {0}", myList.Capacity);
            Console.WriteLine("List elements count is now : {0}", myList.Count);
            Console.WriteLine("List elements: {{ {0} }}", myList);
            Console.WriteLine();

            Console.WriteLine("--- Trim capacity ---");
            myList.Trim();
            Console.WriteLine("List capacity is: {0}", myList.Capacity);
            Console.WriteLine("List elements count is: {0}", myList.Count);
            Console.WriteLine("List elements: {{ {0} }}", myList);
            Console.WriteLine();

            Console.WriteLine("--- Remove element at index 3 ---");
            myList.RemoveAt(3);
            Console.WriteLine("List elements after removing element: {{ {0} }}", myList);
            Console.WriteLine();

            Console.WriteLine("--- Insert element at index 3 ---");
            myList.InsertAt(3, 16);
            Console.WriteLine("List elements after inserting element: {{ {0} }}", myList);
            Console.WriteLine();

            Console.WriteLine("--- Find element by its value ---");
            int valueToFind = 16;
            Console.WriteLine("{0} is at index {1}",valueToFind, myList.Find(valueToFind));
            Console.WriteLine();

            Console.WriteLine("--- Find min and max int elements ---");
            Console.WriteLine("List of int elements: {{ {0} }}", myList);
            Console.WriteLine($"Min element is {myList.Min()}");
            Console.WriteLine($"Max element is {myList.Max()}");
            Console.WriteLine();

            Console.WriteLine("--- Find min and max string elements ---");
            var myStrList = new GenericList<string>();
            myStrList.Add("Pesho");
            myStrList.Add("Gosho");
            myStrList.Add("Strahil");
            myStrList.Add("Chavdar");
            Console.WriteLine("List of string elements: {{ {0} }}", myStrList);
            Console.WriteLine($"Min string element is {myStrList.Min()}");
            Console.WriteLine($"Max string element is {myStrList.Max()}");

            Console.WriteLine();

            Console.WriteLine("--- Clear list ---");
            myList.Clear();
            Console.WriteLine("List elements after clear: {{ {0} }}", myList);
        }
    }
}