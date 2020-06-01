using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        //Create an array to hold integer values 0 through 9
        static void Arrays(){
            int [] array = new int[] {0,1,2,3,4,5,6,7,8,9};{
                foreach (int i in array){
                    Console.WriteLine(i);
                    }
            }
            //Create an array to hold integer values 0 through 9
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};{
                foreach (string name in names){
                    Console.WriteLine($"{name}");
                }
            }
            //Create an array of length 10 that alternates between true and false values, starting with true
            // bool[] bools = new bool[10];
            for (var i=1; i<=10; i++){
              if (i%2==0){
                   Console.WriteLine("False"); 
               }
               else{
                   Console.WriteLine("True");
               }
            }
        }
           
        //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
        //Output the length of this list after building it
        //Output the third flavor in the list, then remove this value
        //Output the new length of the list (It should just be one fewer!)
        static void List(){
            List<string> flavors = new List<string>();{
                flavors.Add("Vanilla");
                flavors.Add("Chocolate");
                flavors.Add("Blueberry");
                flavors.Add("Bubble gum");
                flavors.Add("Green tea");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
                flavors.Remove(flavors[2]);
            Console.WriteLine(flavors.Count);
            }
        }
        //Create a dictionary that will store both string keys as well as string values
        //Add key/value pairs to this dictionary where:
            //each key is a name from your names array
            //each value is a randomly select a flavor from your flavors list.
        //Loop through the dictionary and print out each user's name and their associated ice cream flavor
        static void Dictionary()
        {
            string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            List<string> flavors = new List<string>();
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Blueberry");
            flavors.Add("Bubble gum");
            flavors.Add("Green tea");
            Dictionary<string,string> nameKeys = new Dictionary<string,string>();
            
            foreach (var name in names)
            {
                Random rand = new Random();
                nameKeys.Add(name,flavors[rand.Next(flavors.Count)]);
            }

            foreach (KeyValuePair<string,string> entry in nameKeys)
            {
                Console.WriteLine($"{entry.Key}'s flavorite ice cream is {entry.Value}");
            }

        }
        static void Main(string[] args)
        {
            // Arrays();
            // List();
            Dictionary();
        }
    }
}
