using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Manipulator
{
    internal class Manipulator : IMessageManipulator

    {
        public void Manipulate(string msg)
        {
            //The manipulation is of the form #m<n> where <n> is the manipulation number such that #m1 => Manipulation and #m2 => Manipulation 2
            //msg string will contain 0 or more characters in the set a-z lowercase
            //manipulation and msg string will be separated by a space
            //first we isolate the manipulation and the input string
            //there is no error handling if say the msg string is smaller than #m<n><space>, so an Argument out of range exception will occur.
            string Manipulation = msg.Substring(0, 3);
            string inputMessage = msg.Substring(4);

            //We then check for the first manipulation #m1
            if (Manipulation == "#m1")
            {
                //for this string we will need to check that the string is a palindrome (reads the same right to left as left to right (ex. racecar,kayak, radar, ewe)
                string reversed = "";
                //we create an array of the inputmessage so that we can go through each index 
                char[] charArray = inputMessage.ToCharArray();

                //we create a for loop to go through each index
                //our iterator is the last index, and it will increment -1 until it is negative.
                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    reversed += charArray[i];
                }
                //we check for the reversal of the string here, and output the reversed string if they are equal in value.
                if (reversed == inputMessage)
                {
                    Console.WriteLine(reversed);
                }
                //otherwise we write an empty string
                else
                {
                    Console.WriteLine(string.Empty);
                }
            }

            //Manipulation 2 removes a and z from the string
            else if (Manipulation == "#m2")
            {
                //we can stack replace methods to replace a and z and output the string
                Console.WriteLine(inputMessage.Replace("a", "").Replace("z", ""));
            }
            else
            {
                //adding this just as a way to return nothing
                Console.WriteLine(string.Empty);
            }


        }
    }
}
