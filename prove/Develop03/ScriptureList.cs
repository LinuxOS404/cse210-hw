using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
public class ScriptureList
{

//Verse list
private List<Verse> verses = new List<Verse>();


public void AddVerse(Verse verse, string text)
{
    verses.Add(new Verse(verse, text));
}
}
