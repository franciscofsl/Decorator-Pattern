namespace DecoratorPattern.Bad;

public class BadSmsFacebookNotifier : BadNotifier
{
    public override void Send()
    {
        BadFacebookNotifier facebookNotifier = new BadFacebookNotifier();
        facebookNotifier.Send();
        BadSmsNotifier smsNotifier = new BadSmsNotifier();
        smsNotifier.Send();
    }
}