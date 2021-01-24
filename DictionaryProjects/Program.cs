using System;


namespace DictionaryProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n\n-----BOOK  *  AUTHOR -----\n");
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("SEDUCATION", "Robert Greene");
            myDictionary.Add("The 7 Habits of Highly Effective People ", "Stephen. R. Covey");
            myDictionary.Add("Think and Grow Rich", "Napoleon Hill");
            myDictionary.Add("The Attention Revolution", "Alan Wallace");
            myDictionary.Add("Failing Forward", "John C. Maxwell");
            myDictionary.Add("The Power of Now", "Eckhart Tolle");
            myDictionary.Add("The Last Lecture", "Randy Pausch");

            myDictionary.Show();

        }
    }
}