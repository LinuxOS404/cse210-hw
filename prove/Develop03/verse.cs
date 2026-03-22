
using System.Security.Cryptography.X509Certificates;

public class Verse
    {
     
   private string _book; 
   private int _chap; 
   private int _startV; 
   private int _endV;
    private Verse verse;
    private string text;

    public Verse(string book, int chap, int startV)
    {
_book = book; 
_chap = chap; 
_startV = startV; 
_endV = startV;
    }
 public Verse(string book, int chap, int startV, int endV)
    {
_book = book; 
_chap = chap; 
_startV = startV; 
_endV = endV;
    }

    public Verse(Verse verse, string text)
    {
        this.verse = verse;
        this.text = text;
    }

    public string GetScriptureSeperate()
    {
        return $"{_book} {_chap}:{_startV}";
    }
    
    public static Verse Parse(string s)
    {
    string Seperate = s.Replace('|',' ').Replace('-',' ').Replace(':',' ');



    string[] v = Seperate.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

    string book = v[0];
    int chap = int.Parse(v[1]);
    int start = int.Parse(v[2]);

    int end = start;
    if(v.Length > 3)

    {
      end = int.Parse(v[3]); 
    }
    return new Verse(book, chap,start,end);
}
}
    