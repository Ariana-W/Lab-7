using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab7
{
    class Program
    {
        static void Main(string[] args)

        {
            bool run = true;
            int userInput2 = 0;

            while (run)
         
            {

                Console.WriteLine("Welcome to our C# Class. Which student would you like to learn more about? Please enter a number in between 1 and 6");
                Console.WriteLine();
                string user = Console.ReadLine();
                int userInput = int.Parse(user);

                userInput2 = userInput;

                if (userInput > 6)
                {
                    Console.WriteLine("Please Try Again. Please choose a number between 1 and 6");
                }
                else
                {
                    run = false;
                }

            }
           
        
                Hashtable studentNumber = new Hashtable();

                //Keys on the left and Values on the right 

                studentNumber.Add(1, "Omar");
                studentNumber.Add(2, "LaShay");
                studentNumber.Add(3, "Keiaria");
                studentNumber.Add(4, "Jakaela");
                studentNumber.Add(5, "Alicia");
                studentNumber.Add(6, "Chelsea's");

            Console.WriteLine("Student " + userInput2 + " is " + studentNumber[userInput2]);
            //Console.WriteLine("Student " + userInput2 + " is" + studentNumber.Values);
            Console.WriteLine();
            Console.WriteLine("What would you like to know about " + studentNumber[userInput2]);

            Console.WriteLine("Please enter 'hometown' or 'favorite food'");
            string userRequest =  Console.ReadLine();


            Hashtable HomeTowns = new Hashtable();

            //Keys on the left and Values on the right 

            HomeTowns.Add(1, "Hot-Lanta");
            HomeTowns.Add(2, "London,England");
            HomeTowns.Add(3, "Chi-Town");
            HomeTowns.Add(4, "Doulala, Cameroon");
            HomeTowns.Add(5, "Bangkok, Thailand");
            HomeTowns.Add(6, "Springfield, Massachusetts");



            Hashtable FavFood = new Hashtable();

            FavFood.Add(1, "Mac and Cheese");
            FavFood.Add(2, "Hot Dogs");
            FavFood.Add(3, "Veggie Burgers");
            FavFood.Add(4, "Fajitas");
            FavFood.Add(5, "Caribean Cole Slaw");
            FavFood.Add(6, "Peanut Butter Bread and Cool Ranch Doriots");

            Console.WriteLine();
            Console.WriteLine();

            if (userRequest == "favorite food")
            {
                if (userInput2 == 1)
                {
                    Console.WriteLine("Omar's favorite food is: " + FavFood[1]);
                }

                else if (userInput2 == 2)
                {
                    Console.WriteLine("LaShay's favorite food is: " + FavFood[2]);
                }

                else if (userInput2 == 3)
                {
                    Console.WriteLine("Keiaria's favorite food is: " + FavFood[3]);
                }

                else if (userInput2 == 4)
                {
                    Console.WriteLine("Jakaela's favorite food is: " + FavFood[3]);
                }

                else if (userInput2 == 5)
                {
                    Console.WriteLine("Alicia's favorite food is: " + FavFood[3]);
                }

                else if (userInput2 == 6)
                {
                    Console.WriteLine("Chelsea's favorite is: " + FavFood[3]);
                }             

            }


            else if (userRequest == "hometown")
            {
                if (userInput2 == 1)
                {
                    Console.WriteLine("Omar's  home town is: " + HomeTowns[1]);
                }

                else if (userInput2 == 2)
                {
                    Console.WriteLine("LaShay's  home town is: " + HomeTowns[2]);
                }

                else if (userInput2 == 3)
                {
                    Console.WriteLine("Keiaria's  home town is: " + HomeTowns[3]);
                }

                else if (userInput2 == 4)
                {
                    Console.WriteLine("Jakaela's  home town is: " + HomeTowns[4]);
                }

                else if (userInput2 == 5)
                {
                    Console.WriteLine("Alicia's home town is: " + HomeTowns[5]);
                }

                else if (userInput2 == 6)
                {
                    Console.WriteLine("Chelsea's home town is: " + HomeTowns[6]);
                }

               
            }

          else { Console.WriteLine("That data does not exist. Please try again."); }

             

                     
        }
    }
}

