namespace DecoratorPattern;

public abstract class NotifierDecorator : INotifier
{
    protected readonly INotifier _notifier;

    protected NotifierDecorator(INotifier notifier)
    {
        this._notifier = notifier;
    }

    public abstract string Send();
}