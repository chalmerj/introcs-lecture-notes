using System;

class PromptUser  //version with range added to prompt
{

   static void Main() //testing routine
   {
      // int n = InputIntInRange("Enter a score: ", 0, 100);
      // Console.WriteLine("Your score is {0}.", n);
      // Console.WriteLine("Try another test.");
      // n = InputIntInRange("Enter a number: ", -10, 10);
      // Console.WriteLine("Your number is {0}.", n);
      Console.WriteLine(Agree("Do you understand? "));
   }

   static string InputLine(string prompt)
   {
      Console.Write(prompt);
      return Console.ReadLine();
   }

   /** Prompt the user for an integer ans
   static int InputInt(string prompt)
   {
      string nStr = InputLine(prompt).Trim(); //Removes blanks at either end
      return int.Parse(nStr);
   }
                                             
   /** Continue to obtain a value from the user until it is in the
    * range [lowLim, highLim].  Then return the value in range.
    * Use the specified prompt, adding a reminder of the allowed range. */
   static int InputIntInRange(string prompt, int lowLim, int highLim)
   {
      string longPrompt = string.Format("{0} ({1} through {2}) ",
                                        prompt, lowLim, highLim);
      int number = InputInt(longPrompt);
      while (number < lowLim || number > highLim) {
         Console.WriteLine("{0} is out of range!", number);
         number = InputInt(longPrompt);
      }
      return number;
   }

   static double InputDouble(string prompt)  //FIX so loops until legal
   {
      string nStr = InputLine(prompt).Trim(); //Removes blanks at either end
      return double.Parse(nStr);
   }

   /** Prompt the user with a question; return true of false.  */
   static Boolean Agree(string question)
   {
      return true;  // so stub compiles
   }
}                                          


