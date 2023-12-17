/*-----------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                          
 *-----------------------------------------------------------------------------
 *                      Jan Ritt                                               
 *-----------------------------------------------------------------------------
 *  Description:  Filter all numbers from a Userinput
 *-----------------------------------------------------------------------------
*/

/*_________________________________libraries_________________________________*/
using System;                   //  
using System.Reflection.Metadata;
using System.Text;              //  Unicode Symbols
using System.Threading;         //  Thread.Sleep(1000) = 1 sec

/*---------------------------------- START ----------------------------------*/
namespace DigitFilter       //  
{                           //
  public class Program      //
  {                         //
    static void Main()      //
    {
      ///*----------------------- console_settings ------------------------*///
      const int cWidth = 53;                     //  console width
      const int cHeight = 30;                    //  & height
      Console.SetWindowSize(cWidth, cHeight);    //
      Console.OutputEncoding = Encoding.UTF8;    //  Unicode Symbols

      const int ASCIIZERO = 48;
      /*----------------------------- VARIABLES -----------------------------*/
      string userInput;
      int cacheOut = 0; 
      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n                    Zahlen Filter                    " +
      /* cWidth: */ "\n=====================================================");

      /*---[in:]-------------------- PROMPT_USER ----------------------------*/
      Console.Write("\n Geben Sie einen Text ein, " +
                    "\n aus dem die Zahlen gefiltert werden sollen.  " +
                    "\n ");
      /*----------------------------- GET_INPUT -----------------------------*/
      userInput = Console.ReadLine();
      int[] cacheDigits = new int[userInput.Length];
      char[] inputDigits = new char[userInput.Length];

      for (int i = 0; i < userInput.Length; i++)
      {
        inputDigits[i] = userInput[i];

        if (inputDigits[i] >= '0' && inputDigits[i] <= '9')
        {
          // ASCII "48" = Dezimal "0"
          cacheOut = (cacheOut * 10) + (inputDigits[i] - ASCIIZERO);
        }
      }
      Console.Write("\n-----------------------------------------------------" +
                   $"\n Alle Ziffern: {cacheOut}" +
                    "\n=====================================================");
      /*-------------------------------- END --------------------------------*/
      Console.Write("\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}