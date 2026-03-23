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
//Gets the word it will hide
    public string GetText()
    {
        return Letters;
    }
    //It will  display word if it's not blank
    public void Display()
    {
        IsBlank = false;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}
    