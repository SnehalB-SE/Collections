namespace DictionaryDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Dictionaries map keys to values. Keys must be unique
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();

            // add some keys and values to the dictionary
            fileTypes.Add(".bmp", "Binary File");
            fileTypes.Add(".txt", "text File");
            fileTypes.Add(".html", "HTML File");
            fileTypes.Add(".jpg", "JPEG File");

            // use the Count property to see how many items there are
            Console.WriteLine("Count: {0}", fileTypes.Count);

            // Trying to add an existing key will throw an exception
            // fileTypes.Add(".txt", "Just plain text");

            // The TryAdd function makes it convenient to see if there's a duplicate
            bool added = fileTypes.TryAdd(".txt", "Just plain text File");
            Console.WriteLine("Added: {0}",added);
            // Dictionaries are also like associative arrays
            Console.WriteLine("Key Value: {0}", fileTypes[".html"]);
            // This way, setting an existing key just overwrites the value
            fileTypes[".html"] = "Web File";
            Console.WriteLine("Key Value: {0}", fileTypes[".html"]);
            // See if the Dictionary contains an key or a value
            Console.WriteLine("Contains Key: {0}", fileTypes.ContainsKey(".html"));
            Console.WriteLine("Contains Value: {0}", fileTypes.ContainsValue("HTML Document"));
            // Remove items
            fileTypes.Remove(".bmp");
            Console.WriteLine("Contains Key: {0}", fileTypes.ContainsKey(".bmp"));
        }
    }
}