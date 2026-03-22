public class Text
{

public string Letters;
//stores the state of the word
public bool IsBlank;

public Text(string text)
    {
        Letters = text;
        IsBlank = false;
    }
//Method for hiding the word
    public void Cover()
    {
        IsBlank = true;
    }

    public string GetText()
    {
        return Letters;
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
    