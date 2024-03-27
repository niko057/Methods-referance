namespace Reference_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string inputString = "Ali Sadat Nicat Mirqubad";
            //string reversedNames = ReverseNames(inputString);
            //Console.WriteLine("Evvelki yazilis:"+inputString);
            //Console.WriteLine("Sonraki yazilis:"+reversedNames);

            //Console.Write("Reqem daxil edin: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int reversedNumber = ReverseNumber(number);

            //Console.WriteLine("Cevrilmis eded: " + reversedNumber);

            //Console.Write("Cumle daxil edin: ");
            //string sentence = Console.ReadLine();

            //Dictionary<char, int> letterCounter = CreateCounter(sentence);

            //// Printing counters for each letter
            //foreach (var item in letterCounter)
            //{
            //    Console.WriteLine($"'{item.Key}'Herfden : {item.Value} dene");
            //}

            Console.Write("Cumle daxil edin: ");
            string word = Console.ReadLine();

            if (IsPalindrome(word))
            {
                Console.WriteLine($"'{word}': Bu cumle polindromdu.");
            }
            else
            {
                Console.WriteLine($"'{word}': Bu cumle polindrom deyil.");
            }

        }
        static string ReverseNames(string input)
        {
            string[] words = input.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }
            return string.Join(" ", words);
        }

        static int ReverseNumber(int num)
        {
            int reversed = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reversed = (reversed * 10) + digit;
                num /= 10;
            }
            return reversed;
        }

        static Dictionary<char, int> CreateCounter(string sentence)
        {
            Dictionary<char, int> letterCounter = new Dictionary<char, int>();

            foreach (char letter in sentence)
            {
                if (char.IsLetter(letter))
                {
                    char lowercaseLetter = char.ToLower(letter);
                    if (letterCounter.ContainsKey(lowercaseLetter))
                    {
                        letterCounter[lowercaseLetter]++;
                    }
                    else
                    {
                        letterCounter[lowercaseLetter] = 1;
                    }
                }
            }

            return letterCounter;
        }

        static bool IsPalindrome(string word)
        {

            word = word.ToLower();

            int i = 0;
            int j = word.Length - 1;


            while (i < j)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}