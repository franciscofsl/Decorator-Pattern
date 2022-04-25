namespace DecoratorPattern.Bad;
public class BadSender
{
    private readonly BadFacebookNotifier _facebookNotifier;
    private readonly BadSmsNotifier _smsNotifier;
    private readonly BadSmsFacebookNotifier _smsFacebookNotifier;

    public BadSender()
    {
        this._facebookNotifier = new BadFacebookNotifier();
        this._smsNotifier = new BadSmsNotifier();
        this._smsFacebookNotifier = new BadSmsFacebookNotifier();
    }

    public void SendFacebookNotification()
    {
        this._facebookNotifier.Send();
    }

    public void SendSmsNotification()
    {
        this._smsNotifier.Send();
    }

    public void SendSmsFacebookNotification()
    {
        this._smsFacebookNotifier.Send();
    }
}
