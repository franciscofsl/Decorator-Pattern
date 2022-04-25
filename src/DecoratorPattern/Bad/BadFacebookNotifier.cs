namespace DecoratorPattern.Bad;

public class BadFacebookNotifier : BadNotifier
{
    public override void Send()
    {
        Console.WriteLine("Facebook notification");
    }
}
