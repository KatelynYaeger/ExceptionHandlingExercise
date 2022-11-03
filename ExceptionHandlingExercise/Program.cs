using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // DONE - First create an char[], it must contain 6 numbers and 3 letters - name it arr

            var arr = new char[] { 'z', 'y', 'w', '1', '2', '3', '4', '5', '6' };

            // DONE - Create a list called numbers that will hold integers

            var numbers = new List<int>();

            // DONE - Create an string variable with an empty string initializer - name it str

            string str = ""; 

            // DONE - using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // DONE - and Exceptions will be thrown 
            // DONE - Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:
            
            // DONE - Make a foreach loop to iterate through your character array

            foreach (var character in arr)
            {
                // DONE - Now create a try catch
                // DONE - Inside your try block
                // DONE - set your string variable to each array element in your char[] to .ToString()
                // DONE - Now, using int.Parse, parse your string variable and store in an int variable
                // DONE - Then add each int to your list

                try
                {

                    str = character.ToString();
                    var actualChar = int.Parse(str);

                    numbers.Add(actualChar);

                }

                // DONE - catch your Exception:
                // DONE - in the scope of your catch you can use the following, 
                // DONE - Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name
                // DONE - of each item in your collection

                catch (Exception e)
                {
                    Console.WriteLine($"Unable to Parse '{character}'");
                }

            }
            
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
        }
    }
}
