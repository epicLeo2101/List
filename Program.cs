using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7List
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new list
            //similar in syntax to creatig a new array
            //or a new random number
            //instiation
            List<string> dinosaurs = new List<string>();

            //get a List's capacity with a method call
            Console.WriteLine("\nDinosaur List Capacity: {0}", dinosaurs.Capacity);
            Console.ReadLine();

            //lest add items to our list
            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");
            dinosaurs.Add("Aardonyx");
            dinosaurs.Add("Abelisaurus ");
            dinosaurs.Add("Abrictosaurus");
            Console.Clear();
            Console.WriteLine("\nDinosaur List Capacity: {0}", dinosaurs.Capacity);
            Console.ReadLine();

            //how do you print out contents of your list???
            //list elements can be called much list array elements via index position value
            Console.Clear();
            Console.WriteLine(dinosaurs[0]);
            Console.WriteLine(dinosaurs[1]);
            Console.WriteLine(dinosaurs[2]);
            Console.WriteLine(dinosaurs[3]);
            Console.WriteLine(dinosaurs[4]);
            Console.WriteLine(dinosaurs[5]);
            Console.WriteLine(dinosaurs[6]);
            Console.WriteLine(dinosaurs[7]);
            Console.ReadLine();


            //the count method will derive how many items are actuially in your list
            //use list_identifier.Count
            Console.Clear();
            Console.WriteLine("\nThere are {0} items in the List.", dinosaurs.Count);
            Console.WriteLine("\nList Capacity: {0}", dinosaurs.Capacity);
            Console.ReadLine();

            //how to remove an item from the list
            //.remove
            Console.Clear();
            Console.WriteLine("Let's remove the Aardonyx from our Dinosaurs List\n");
            dinosaurs.Remove("Aardonyx");
            Console.WriteLine("\nThere are {0} items in the List.", dinosaurs.Count);
            Console.WriteLine("\nList Capacity: {0}", dinosaurs.Capacity);
            Console.ReadLine();


            //automate the print out of all items in your lists
            //use the foreach commacnd to iterate through each element in your List
            //and print to screen
            Console.Clear();
            Console.WriteLine("Let's automate the printing of all values stored in a List.\n");
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.ReadLine();

            //use the contains method call to check if a specific
            //value is stored in your list
            //list_identifier.Contains();

            //combine the search functionality with conditional branching
            Console.Clear();
            Console.WriteLine("Lets see if a value exisits in our Dinosaur List?\n");

            if (dinosaurs.Contains("Brontosaurus"))
            {
                Console.WriteLine("Yup, the Brontosaurus is there.");
            }

            else
            {
                Console.WriteLine("Nope, the Brontosaurus is not in the List.");
            }

            Console.ReadLine();

            //how to insert an item into your list
            // list_identifier.Insert(index_position_number, value);
            Console.Clear();

            Console.WriteLine("let's insert a value into the List.\n");

            dinosaurs.Insert(1, "Brontosaurus");

            if (dinosaurs.Contains("Brontosaurus"))
            {
                Console.WriteLine("Yup, the Brontosaurus is there.");
            }

            else
            {
                Console.WriteLine("Nope, the Brontosaurus is not in the List.");
            }

            Console.ReadLine();

            Console.WriteLine("Let's see all values stored in a List.\n");
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.ReadLine();

            Console.WriteLine("\nThere are {0} items in the List.", dinosaurs.Count);
            Console.WriteLine("\nList Capacity: {0}", dinosaurs.Capacity);

            Console.ReadLine();


            //trim capacity in an effort to best manage memory
            Console.Clear();






            dinosaurs.Remove("Amargasaurus");
            dinosaurs.Remove("Mamenchisaurus");
            dinosaurs.Remove("Deinonychus");
            dinosaurs.Remove("Compsognathus");
            dinosaurs.Remove("Aardonyx");
            dinosaurs.Remove("Abelisaurus ");
            dinosaurs.Remove("Abrictosaurus");



            Console.WriteLine("\nThere are {0} items in the List.", dinosaurs.Count);
            Console.WriteLine("\nList Capacity: {0}", dinosaurs.Capacity);

            Console.WriteLine("Let's trim unused capacity.");

            //list_identifier.trimExcess() command
            dinosaurs.TrimExcess();
            Console.WriteLine("\nThere are {0} items in the List.", dinosaurs.Count);
            Console.WriteLine("\nList Capacity: {0}", dinosaurs.Capacity);


            Console.ReadLine();

        }
    }
}
