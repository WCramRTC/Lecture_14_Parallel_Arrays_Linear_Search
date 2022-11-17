using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_14_Parallel_Arrays_Linear_Search
{
    internal class Program
    {
        // 2    cups  flour
        // 1/2  cup   sugar
        // 1    tsp   baking soda
        // 1/2  cup   butter

        // This is being declared globally
        static double[] qty = { 2, .5, 1, .5 };
        static string[] measurements = { "cups", "cup", "tsp", "cup" };
        static string[] ingredients = { "flour", "sugar", "baking soda", "butter" };

        static double[] tartarQty = { 4, .7, .7, .5 };
        static string[] tartarMeasurements = { "piece", "slab", "tsp", "cup" };
        static string[] tartarIngredients = { "steak", "sugar", "baking soda", "butter" };

        static void Main(string[] args)
        {
            //"baking soda"

            while(true)
            {
                Console.Write("Please enter an ingredient: ");
                string search = Console.ReadLine();
                int indexAt = IngredientAtIndex(search, ingredients);


                if (ContainsIngredient(search, ingredients))
                {
                    string ingredient = FormatIngredient(qty[indexAt], measurements[indexAt], ingredients[indexAt]);
                    global::System.Console.WriteLine(ingredient);
                }
                else
                {
                    global::System.Console.WriteLine("Item does not exist");
                }
            }



            Console.ReadKey();

     


        } // Main

        /// <summary>
        /// Searches for an ingredient
        /// </summary>
        /// <param name="search"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int IngredientAtIndex(string search, string[] arr)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                // returns index if item found
                if (search == ingredients[i])
                {
                    return i;
                }
            }
            // Returns negative 1 if item not found
            return -1;
        }

        public static void LinearSearchExample()
        {

            // If an ingredient exists
            Console.Write("Search for an ingredient:");
            string userSearch = Console.ReadLine();

            bool containsFlour = ContainsIngredient(userSearch, ingredients);

            if (containsFlour)
            {
                global::System.Console.WriteLine($"This recipe contains {userSearch}");
            }
            else
            {
                global::System.Console.WriteLine("It doesn't.");
            }

        }


        // Linear Search
        //Linear search is a series of search of the algorithm,
        //it starts at one end and goes through each elment
        //until the targeted element is found ,
        //otherwise the search continues til the end of data.

        public static bool ContainsIngredient(string search, string[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                // If runs if it finds the ingredient
                if (search == arr[i])
                {
                    return true;
                }
            }

            Console.WriteLine("After the loop");

            // If the ingredient is not on the list
            return false;

        } // ContainsIngredient()

        // What index is an ingredient at




        public static void ChangeRecipe()
        {

            Console.WriteLine("Half the greatest cookies in the world");
            DisplayIngredients(qty, measurements, ingredients);
            Console.WriteLine("--------------------------");

            Console.Write("How many servings: ");
            double multiplyBy = double.Parse(Console.ReadLine());
            ScaleRecipe(qty, multiplyBy);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Half the greatest cookies in the world");
            DisplayIngredients(qty, measurements, ingredients);

            Console.ReadKey();
        }

        public static void ScaleRecipe(double[] qty, double scaleBy)
        {
            for (int i = 0; i < qty.Length; i++)
            {
                qty[i] *= scaleBy;
            }
        } // ScaleRecipe



        // Refactoring my code

        public static void DisplayAllRecipes()
        {
            // 2 cups flour

            Console.WriteLine("Half the greatest cookies in the world");
            DisplayIngredients(qty, measurements, ingredients);

            Console.WriteLine("Best Recipe");
            DisplayIngredients(tartarQty, tartarMeasurements, tartarIngredients);
        }

        // Public Display Ingredients
        public static void DisplayIngredients(double[] qty, string[] measurements, string[] ingredients )
        {
            // On method call display my ingredients in a formatted manor
            for (int i = 0; i < qty.Length; i++)
            {
                string ingredient = FormatIngredient(qty[i], measurements[i], ingredients[i]);
                global::System.Console.WriteLine(ingredient);
                //Console.WriteLine(qty[i]);
                //Console.WriteLine(measurements[i]);
                //Console.WriteLine(ingredients[i]);

            }
        }

        // Used to format string for ingredients to display
        public static string FormatIngredient(double qtr, string measure, string ingred)
        {
            // New Escape Command \t
            // \t means tab
            string format = $"{qtr}\t{measure}\t{ingred}";

            return format;
        }


        // 2 cups flour

        public static void UsersValues()
        {
            string[] words = new string[5];

            //// To change an individual value
            //words[0] = Console.ReadLine();


            for(int i = 0; i < words.Length; i++)
            {
                Console.Write($"Enter a word {i}: ");
                words[i] = Console.ReadLine();
                Console.WriteLine();
            }

            // What is the shortcut for is for and double tab tab
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }

             

            Console.ReadKey();
        }


        // Questions
        // 1. Working with arrays
        // Filling up an array with user information

        // 2. Parallel Arrays
        // What are parallel arrays?
        // What connects information in one array with another?

        // 3. Linear Search
        // How does a linear search work?
        // 

        public static void ArrayExample()
        {
            // new type[capacity]
            // 0 - 9 index, 10 capacity
            string[] words = new string[10];
            words[0] = "This"; // 0 This
            words[1] = "Works"; // 1 Works 
            // arrayName.Length returns the capacity of the array
            Console.WriteLine(words.Length + " words");

            Console.ReadKey();
            // The first element will always be at 0.
            // arrayName[0] is always the first element

            // Inside curly braces place values seperated by commas
            int[] oneThruFive = { 1, 2, 3, 4, 5 };


            for (int i = 0; i < oneThruFive.Length; i++)
            {
                Console.WriteLine(oneThruFive[i]);
            }

            Console.WriteLine("-------------");
            // Looks like a blank line, but it's actually an empty string
            Console.WriteLine("-------------");
            Console.ReadKey();
        }

        //could you also prompt the user to enter strings separated by a comma so they could enter the whole array at once? I know that could lead to errors, but is it possible?



    }
}
