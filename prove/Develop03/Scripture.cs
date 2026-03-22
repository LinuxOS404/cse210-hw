using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
  private List<Text> _texts;
  public Verse Verse; 

  private int CurrentWordIndex = 0;

  public Scripture(Verse verse, string letters)
    {
       Verse = verse;
       _texts = new List<Text>();

       string[] wordArray = letters.Split(' ');
       foreach (var text in wordArray)
        {
            _texts.Add(new Text(text));
        }
    }

    public void HideRandom()
    {
        List<int> hiddenIndexes = new List<int>();

        for(int i = 0; i < _texts.Count; i++)
        {
            if (_texts[i].IsBlank == false)
            {
            hiddenIndexes.Add(i);
            }
        }
    
        if (hiddenIndexes.Count > 0 )
        {
            Random random = new Random();
            int randomIndex = random.Next(0, hiddenIndexes.Count);

            int wordToHideIndex = hiddenIndexes[randomIndex];
            _texts[wordToHideIndex].Cover();
        }
    }
        
        
        public bool AllBlank()
        {
            for (int i = 0; i < _texts.Count; i++)
            {
             if (_texts[i].IsBlank == false)
                {
                    return false;
                }
            }
            return true;
        }
    

        public string ShowVerse()
        {
           List<string> wordStrings = new List<string>();

           for (int i = 0; i < _texts.Count; i++)
            {
                if (_texts[i].IsBlank == true)
            {
                wordStrings.Add("_____");
            }
            else
            {
                wordStrings.Add(_texts[i].GetText());
            }
            }
            string ShowText = string.Join(" ",wordStrings);
        return Verse.GetScriptureSeperate() + " | " + ShowText;
        }
    }




