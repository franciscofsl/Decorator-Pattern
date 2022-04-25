namespace DecoratorPattern;

public class SmsNotifierDecorator : NotifierDecorator
{
    public SmsNotifierDecorator(INotifier notifier)
        : base(notifier)
    { }

    public override string Send()
    {
        var previousMessage = this._notifier.Send();
        return $"{previousMessage} - SMS Notification";
    }
}