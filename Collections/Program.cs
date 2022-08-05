namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] comedians = {"Leo Gallagher", "Rodney Dangerfield",
                                "George Carlin", "Lenny Bruce",
                                "Eddie Murphy", "Louie Anderson"};

            // TODO: Create the list
            List<string> strList = new List<string>(10);

            // TODO: Add some elements to the list from an existing array
            strList.AddRange(comedians);

            // TODO: Add individual items
            strList.Add("Snehal Bagekar");
            strList.Add("John Sena");

            // TODO: Examine the Count and Capacity
            Console.WriteLine("Count of the List is: " + strList.Count + " And Capacity is: " + strList.Capacity);

            // TODO: Enumerate the items in the list with a foreach loop
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }

            // TODO: Access any item by its index
            Console.WriteLine("\nList Item at 4th Index : {0}", strList[4]);

            // TODO: Remove items from the list
            strList.RemoveAt(4);
            strList.Remove("John Sena");
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("\nSort List:");
            // TODO: Sort the list content
            strList.Sort();
            foreach (string str in strList)
            {
                Console.WriteLine(str);
            }
            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item
            Console.WriteLine(strList.Contains("Snehal Bagekar"));
            Console.WriteLine(strList.Contains("John Sena"));
            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list
            bool found = strList.Exists(o => o.Length > 12);
            Console.WriteLine("Item found {0}", found);
            // TODO: Use the Find function to search through items
            string item = "";
            item = strList.Find(o => o.StartsWith("S"));
            Console.WriteLine("Item : {0}",item);
            // TODO: The FindAll function can find multiple items
            List<string> itemList = strList.FindAll(o => o.StartsWith("L"));
            Console.WriteLine("\nItems starts with letter L:");
            foreach (string str in itemList)
            {
                Console.WriteLine(str);
            }

            // TODO: Use TrueForAll to see if a given condition is true for all elements
            bool result = strList.TrueForAll(o => o.StartsWith("S"));
            Console.WriteLine("\nResult: {0}", result);

            bool result2 = strList.TrueForAll(o => o.Length > 10);
            Console.WriteLine("\nResult: {0}", result2);
        }
    }
}