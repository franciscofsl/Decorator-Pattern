namespace DecoratorPattern;

public class WhatsappNotifierDecorator : NotifierDecorator
{
    public WhatsappNotifierDecorator(INotifier notifier)
        : base(notifier)
    { }

    public override string Send()
    {
        var previousMessage = this._notifier.Send();
        return $"{previousMessage} - Whatsapp Notification";
    }

    public void DoSomething()
    {

    }
}