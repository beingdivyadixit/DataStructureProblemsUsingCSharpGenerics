using System;

namespace DataStructureProblemsUsingCSharpGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Problems Using C-Sharp Generics");
            Console.WriteLine("----------------------------------------------------------");
            string paragraph = "To be or not to be";
            CountNumbOfOccurence(paragraph);

        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            hashTabe.Display();
           
        }
    }
}
