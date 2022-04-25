namespace DecoratorPattern;

public class FacebookNotifierDecorator : NotifierDecorator
{
    public FacebookNotifierDecorator(INotifier notifier)
        : base(notifier)
    { }

    public override string Send()
    {
        var previousMessage = this._notifier.Send();
        return $"{previousMessage} - Facebook Notification";
    }
}