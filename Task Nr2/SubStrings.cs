namespace Task_Nr2;

    //Write a program that takes a sequence of characters (string) from the command line as an argument,
    //and which displays to the console all subsequences (two or more characters) that do not contain
    //two consecutive repeating characters.

    //Example:
    //Input: access
    //Result: ac, ce, ces, es


class SubStrings
{
    static void Main(string[] args)
    {
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Program cannot define substrings from empty string");
                return;
            }

            string inputString = args[0];
            List<string> result = GetValidSubsequences(inputString);
            Console.Write("Substrings: ");
            
            foreach (string subString in result)
            {
                Console.Write(subString + " ");
            }

            Console.WriteLine();
        }

        static List<string> GetValidSubsequences(string input)
        {
            List<string> subStrings = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 2; j <= input.Length; j++)
                {
                    string subString = input.Substring(i, j - i);
                    if (IsValid(subString))
                    {
                        subStrings.Add(subString);
                    }
                }
            }

            return subStrings;
        }

        static bool IsValid(string subsequence)
        {
            for (int i = 0; i < subsequence.Length - 1; i++)
            {
                if (subsequence[i] == subsequence[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}