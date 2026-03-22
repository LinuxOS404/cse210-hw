using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
public class ScriptureList{


private List<Scripture> verses = new List <Scripture>();
}

public void AddVerse(Verse verse, string text)
{
    verses.Add(new Verse (verse, text));
}

public verse 