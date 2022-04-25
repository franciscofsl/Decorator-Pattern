using FluentAssertions;
using Xunit;

namespace DecoratorPattern.Test;

public class NotificationTest
{
    [Fact]
    public void Test1()
    {
        var sendSms = true;
        var sendFacebook = true;
        var sendWhatsapp = false;
        INotifier notifier = new BasicNotifier();
        if (sendSms)
        {
            notifier = new SmsNotifierDecorator(notifier);
        }
        if (sendFacebook)
        {
            notifier = new FacebookNotifierDecorator(notifier);
        }
        if (sendWhatsapp)
        {
            notifier = new WhatsappNotifierDecorator(notifier);
        }
        var message = notifier.Send();
        message.Should().Be("Basic notification - SMS Notification - Facebook Notification");
    }
}