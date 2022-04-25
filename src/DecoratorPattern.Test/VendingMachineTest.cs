using DesingPatterns.Test.Decorator;
using System;
using Xunit;
using DecoratorExercise;
using FluentAssertions;

namespace DecoratorPattern.Test;
 
public class VendingMachineTest
{
    [Theory]
    [ClassData(typeof(TicketVendingMachineDiscountPriceData))]
    public void TicketVendingMachine_sells_discounted_tickets_for_customer_by_his_age(int age, double expectedPrice, DateTime purchaseDate)
    {
        var ticket = VendingMachine.GetTicketForCustomer(new Customer(age), purchaseDate);
        ticket.GetPrice().Should().Be(expectedPrice);
    }
}