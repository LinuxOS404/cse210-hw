public class Text
{

public string Letters {get;}
public bool IsBlank {get; private set;}

public Text(string text)
    {
        Letters = Letters;
        IsBlank = false;
    }

    public void cover()
    {
        IsBlank = true;
    }
    
    public void Display()
    {
        IsBlank = false;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
    