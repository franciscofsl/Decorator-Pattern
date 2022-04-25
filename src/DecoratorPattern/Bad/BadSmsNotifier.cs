namespace DecoratorPattern.Bad;

public class BadSmsNotifier : BadNotifier
{
    public override void Send()
    {
        Console.WriteLine("Bad sms");
    }
}