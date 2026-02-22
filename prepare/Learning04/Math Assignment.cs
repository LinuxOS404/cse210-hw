public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    public MathAssignment(string student, string topic, string section, string problems)
        : base(student, topic)
    {
        _section = section;
        _problems = problems;
    }

    public string GetHomework()
    {
        return "Section " + _section + " Problems " + _problems;
    }
}
