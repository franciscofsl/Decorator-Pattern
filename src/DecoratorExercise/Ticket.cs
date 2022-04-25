namespace DecoratorExercise;

public class Ticket
{
    private readonly Customer _customer;
    private readonly DateTime _purchaseDate;

    public Ticket(Customer customer, DateTime purchaseDate)
    {
        this._customer = customer;
        this._purchaseDate = purchaseDate;
    }

    public int TicketBasePrice => 20;

    public double GetPrice()
    {
        if (this._customer.Age is >= 0 and <= 3)
        {
            return 0;
        }
        if (this._customer.Age is >= 4 and <= 13)
        {
            return this.TicketBasePrice * 0.60;
        }
        if (this._customer.Age is >= 14 and <= 25)
        {
            return this.TicketBasePrice * 0.75;
        }
        if (this._purchaseDate.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday &&
            this._customer.Age >= 60)
        {
            return this.TicketBasePrice * 0.60;
        }
        if (this._customer.Age >= 60)
        {
            return this.TicketBasePrice * 0.75;
        }
        return this.TicketBasePrice;
    }
}