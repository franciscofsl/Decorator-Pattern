namespace DecoratorPattern;

public class BasicNotifier : INotifier
{
    public string Send()
    {
        return "Basic notification";
    }
}