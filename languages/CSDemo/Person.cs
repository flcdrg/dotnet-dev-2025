namespace CSDemo;

public class Person
{
    private int _age;

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public string Name { get; set; }
}