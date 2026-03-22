using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Scripture
{
  private List<Text> _texts;
  public Verse Verse {get;}  

  private int CurrentWordIndex = 0;

  public Scripture(Verse verse, string letters)
    {
       Verse = verse;
       _texts = new List<Text>();

       string[] wordArray = letters.Split('');
       foreach (var text in wordArray)
        {
            _texts.Add(new Text(text));
        }
    }

    public void HideRandom()
    {
        if (CurrentWordIndex < _texts.Count)
        {
            List<int> 
        }
    }
}