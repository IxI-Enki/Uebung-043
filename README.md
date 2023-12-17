<!--              READE -> VORLAGE Uebungen: Programmieren & Software Engineering              -->

# Uebung-043  --  [***Digit Filter***](https://github.com/IxI-Enki/Uebung-043/blob/main)  

<!-- ---------------------------------------------|-------------------------------------------- -->
###### 📎[**Angabe**](https://github.com/IxI-Enki/Uebung-043/blob/main/work-directory/3%20DigitFilter.pdf) *.pdf*
<sup><sub> 
---
</sub></sup>

<!-- ---------------------------------------------|-------------------------------------------- -->
## 📊 Lernziele:  
  - ↳ Stringbearbeitung    
  
<sup><sub> </sub></sup>
---

<!-- ---------------------------------------------|-------------------------------------------- -->
## 🧮 **Aufgabenstellung:**  
  - Schreiben Sie ein Programm, welches vom Benutzer einen beliebigen Text einliest und alle Ziffern  
     extrahiert und diese anschließend in einer Ausgabe-Zeichenfolge sammelt.

  - Die Benutzereingaben dürfen im gesamten Programm nicht verändert werden und müssen erhalten bleiben.  
  - Zur Lösung dieser Aufgabe dürfen Sie nicht die Standard-Methoden von String verwenden!
    
---
 
<!-- ---------------------------------------------|-------------------------------------------- -->
## 🔎 **Ausgabe** <sub>*Bsp.*</sub> 

- Benutzerschnittstelle:
  
   |            *Beispiel:*     | | 
   | :------------------------------------------: | :------------------------------------------------------------------ |
   |  Eingabetext: | Hallo Max, meine Telfonnummer ist 067854378923 innerhalb von Österreich! | 
   |  Ausgabetext: | 067854378923   |

---

<!-- ---------------------------------------------|-------------------------------------------- -->


# *SPOILER* <sub><sup> → [*Lösung*](https://github.com/IxI-Enki/Uebung-<<AUSFÜHRBAREDAT>>.cs) <sup></sub>:




### 🖥 **Ausgabe**: 
   |            *Meine Ausgabe:*   |  
   |--------------------------------|
   |  ![**Ausgabe 📎**](https://github.com/IxI-Enki/Uebung-043/assets/138018029/9766f1c3-7d58-4904-886a-dd994980ac09)  |


---

## 💾 `C#` - *Programm*:
 <details><summary>👉 ausklappen 👈 </summary>


```c#
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


```

</dertails>
