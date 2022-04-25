namespace DecoratorExercise;

public static class VendingMachine
{
    public static Ticket GetTicketForCustomer(Customer customer, DateTime purchaseDate)
    {
        return new Ticket(customer, purchaseDate);
    }
}