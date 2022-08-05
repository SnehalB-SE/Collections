namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputArray = new string[] { "Hello World" };

            Dictionary<char, int> mapChar = new Dictionary<char, int>();

            foreach (string s in inputArray)
            {
                foreach (char c in s.ToCharArray())
                {
                    if(!mapChar.ContainsKey(c))
                        mapChar.Add(c, 1);
                    else
                        mapChar[c]++;
                }
            }
            foreach (var mapitem in mapChar.Keys)
            {
                Console.WriteLine($"'{mapitem}' repeats {mapChar[mapitem]} time(s)");
            }
        }
    }
}