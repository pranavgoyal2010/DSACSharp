namespace DSA;

class DictionaryBuiltIn
{
    static void Main(string[] args)
    {
        // Test case 1: Creating a dictionary with integer keys and string values
        Dictionary<int, string> dict1 = new Dictionary<int, string>();

        dict1.Add(1, "One");
        dict1.Add(2, "Two");
        dict1.Add(3, "Three");

        // Test case 2: Creating a dictionary with string keys and double values
        Console.WriteLine("Contents of Dictionary 1");
        foreach (KeyValuePair<int, string> keyValuePair in dict1)
        {
            Console.WriteLine("Key: {0} Value: {1}", keyValuePair.Key, keyValuePair.Value);
        }

        Console.WriteLine();

        // Adding key/value pairs using different syntax
        Dictionary<string, double> dict2 = new Dictionary<string, double>();

        dict2["pi"] = 3.14;
        dict2["e"] = 2.71;
        dict2["sqrt2"] = 1.41;

        // Displaying contents of dict2
        Console.WriteLine("Contents of Dictionary 2");
        foreach (KeyValuePair<string, double> keyValuePair in dict2)
        {
            Console.WriteLine("Key: {0} Value: {1}", keyValuePair.Key, keyValuePair.Value);
        }

        Console.WriteLine();

        // Test case 3: Accessing values by key
        Console.WriteLine("Value corresponding to key 'pi': " + dict2["pi"]);
        Console.WriteLine();

        // Test case 4: Checking if a key exists
        string key = "sqrt3";
        if (dict2.ContainsKey(key))
        {
            Console.WriteLine("Value corresponding to key '" + key + "' is: " + dict2[key]);
        }
        else
        {
            Console.WriteLine("Key '{0}' does not exist in dict2.", key);
        }
        Console.WriteLine();

        // Test case 5: Removing a key/value pair
        key = "sqrt2";
        if (dict2.ContainsKey(key))
        {
            dict2.Remove(key);
            Console.WriteLine("Key '{0}' removed from dict2.", key);
        }
        else
        {
            Console.WriteLine("Key '{0}' does not exist in dict2.", key);
        }
        Console.WriteLine();

        // Test case 6: Counting the number of key/value pairs in the dictionary
        Console.WriteLine("Number of key/value pairs in dict2: " + dict2.Count);
        Console.WriteLine();

        // Test case 7: Clearing all key/value pairs from the dictionary
        dict1.Clear();
        Console.WriteLine("dict1 cleared. Number of key/value pairs in dict1: " + dict1.Count);
    }
}
