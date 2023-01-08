using System;

namespace DataStructureProblemsUsingCSharpGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Problems Using C-Sharp Generics");
            Console.WriteLine("Enter-\n1: for Hash Tables\n2: for BST");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   Console.WriteLine("----------------------------------------------------------");
                   //string paragraph = "To be or not to be";    //--UC1
                   string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                   CountNumbOfOccurence(paragraph);
                    break;
                case 2:
                    BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
                    binarySearch.Insert(30);
                    binarySearch.Insert(70);
                    binarySearch.Display();
                    binarySearch.GetSize();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

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
            Console.WriteLine("Displaying after add operation");
            hashTabe.Display();
            string s = "avoidable";
            hashTabe.Remove(s);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("After removed an item {0}", s);
            hashTabe.Display();

        }
    }
}
