using System;

namespace Spelling_Checker

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word;
                bool flag = false;
                Console.Write("Enter your word: ");
                word = Console.ReadLine();
                for (int i = 0; i < word.Length; i++)
                {
                    try
                    {
                        foreach (char c in word)
                        {
                            if ((c < 'A') || (c > 'z'))
                            {
                                flag = true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        flag = false;
                    }
                }
                while (flag == true)
                {
                    Console.WriteLine("Only letters are accepted.\n");
                    break;
                }
                while (flag == false)
                {
                    Console.WriteLine("You entered : " + word);
                    Console.WriteLine("You enter valid word\n");
                    
                    break;
                }
            }
        }
    }
}