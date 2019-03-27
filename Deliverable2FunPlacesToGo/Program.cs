using System;

namespace Deliverable2Currency
{
  class Program
  {
    static void Main(string[] args)
    {
      // Greeting and prompt the user to input their name.
      Console.WriteLine("Hello! What's you're name?");

      // Read the name entered.
      string name = Console.ReadLine();

      // Greet the user with the name that was entered.
      Console.WriteLine(name + ", what are you in the mood for?");

    again:
      {
        // Display options for actions.
        Console.WriteLine("Choices: 1 - Action, 2 - Chill times, 3 - Danger, or 4 - Good food? Please enter the number.");

        // Read the choice of mood.
        string s = Console.ReadLine();

        if (!IsAllDigits(s)) // call the special method for checking for a number
        {
          Console.WriteLine("Hey! That isn't a number. Would you like to try again? Y or N");
          {
            string ans = Console.ReadLine();
            switch (ans.ToUpper())
            {
              case "Y": goto again;
              case "N": goto end;
            }
          }
        }
        //If user selects >5
        if (Convert.ToInt32(s) > 4)
        {
          Console.WriteLine("Your input was not understood! Please select one of the options 1-4.");
          Console.WriteLine("1 - Action, 2 - Chill times, 3 - Danger, or 4 - Good food");
          {
            string ans = Console.ReadLine();
            switch (ans.ToUpper())
            {
              case "Y": goto again;
              case "N": goto end;
            }
          }
        }

        //If user selects 0
        if (Convert.ToInt32(s) == 0)
        {
          Console.WriteLine("Your input was not understood! Please select one of the options 1-4.");
          Console.WriteLine("1 - Action, 2 - Chill times, 3 - Danger, or 4 - Good food");
          {
            string ans = Console.ReadLine();
            switch (ans.ToUpper())
            {
              case "Y": goto again;
              case "N": goto end;
            }
          }
        }

        // Ask user number of people in party.
        Console.WriteLine("How many people are you bringing with you?");

        // Read the number of people in party.
        int party = Convert.ToInt32(Console.ReadLine());

        // if else statement for how selection of mood and selection of people
        if (Convert.ToInt32(s) == 1 && party == 0)
        {
          Console.WriteLine("Okay if you’re in the mood for action, then you should go Stock Car Racing and travel in sneakers.");
        }
        else if ((Convert.ToInt32(s) == 1) && ((party >= 1) && (party <= 4)))
        {
          Console.WriteLine("Okay if you’re in the mood for action then you should go Stock Car Racing and travel in a sedan.");
        }
        else if ((Convert.ToInt32(s) == 1) && ((party >= 5) && (party <= 10)))
        {
          Console.WriteLine("Okay if you’re in the mood for action then you should go Stock Car Racing and travel in a Volkswagen bus.");
        }
        else if ((Convert.ToInt32(s) == 1) && (party >= 11))
        {
          Console.WriteLine("Okay if you’re in the mood for action then you should go Stock Car Racing and travel in an airplane.");
        }
        else if (Convert.ToInt32(s) == 2 && party == 0)
        {
          Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in sneakers.");
        }
        else if (Convert.ToInt32(s) == 2 && ((party >= 1) && (party <= 4)))
        {
          Console.WriteLine("Okay if you’re in the mood for chilling, then you should go hiking and travel in a sedan.");
        }
        else if ((Convert.ToInt32(s) == 2) && ((party >= 5) && (party <= 10)))
        {
          Console.WriteLine("Okay if you’re in the mood for chiling then you should go hiking and travel in a Volkswagen bus.");
        }
        else if ((Convert.ToInt32(s) == 2) && (party >= 11))
        {
          Console.WriteLine("Okay if you’re in the mood for chiling then you should go hiking and travel in an airplane.");
        }
        else if (Convert.ToInt32(s) == 3 && party == 0)
        {
          Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in sneakers.");
        }
        else if (Convert.ToInt32(s) == 3 && ((party >= 1) && (party <= 4)))
        {
          Console.WriteLine("Okay if you’re in the mood for danger, then you should go skydiving and travel in a sedan.");
        }
        else if ((Convert.ToInt32(s) == 3) && ((party >= 5) && (party <= 10)))
        {
          Console.WriteLine("Okay if you’re in the mood for danger then you should go skydiving and travel in a Volkswagen bus.");
        }
        else if ((Convert.ToInt32(s) == 3) && (party >= 11))
        {
          Console.WriteLine("Okay if you’re in the mood for danger then you should go skydiving and travel in an airplane.");
        }
        else if (Convert.ToInt32(s) == 4 && party == 0)
        {
          Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in sneakers.");
        }
        else if (Convert.ToInt32(s) == 4 && ((party >= 1) && (party <= 4)))
        {
          Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a sedan.");
        }
        else if ((Convert.ToInt32(s) == 4) && ((party >= 5) && (party <= 10)))
        {
          Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in a Volkswagen bus.");
        }
        else if ((Convert.ToInt32(s) == 4) && (party >= 11))
        {
          Console.WriteLine("Okay if you’re in the mood for good food, then you should go to Taco Bell and travel in an airplane.");
        }

      end:
        // Wait for user to acknowledge the results.
        Console.WriteLine("Goodbye! Press enter to end this program.");
        Console.ReadLine();

      }    
      // IsAllDigits Method
        bool IsAllDigits(string raw)
        {
          // First get rid of any benign characters at either end of string.
          // If there is nothing left, no number.
          string s = raw.Trim();
          if (s.Length == 0) return false;

          // Loop through the string.

          for (int index = 0; index < s.Length; index++)

          {
            // A nondigit indicates that the string is not a number.
            if (Char.IsDigit(s[index]) == false) return false;
          }

          // No nondigit is found; it's okay!
          return true;
        }
    }        

  }
}

