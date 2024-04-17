using LB2.Infrastructure.Classes;
using LB2.Infrastructure.Interfaces;
using LB2.Orders;

namespace LB2;

internal class Program
{
    private static void Main(string[] args)
    {
        IOrderProcessor orderProcessor = new OrderProcessor();
        IOrderValidator orderValidator = new OrderValidator();
        IEmailConfirmationSender emailConfirmationSender = new EmailConfirmationSender();

        IOrder[] orders =
        {
            new BookOrder(),
            new ElectronicOrder(),
            new InvalidOrder(),
            new BookOrder(),
            new ElectronicOrder(),
            new BookOrder(),
            new InvalidOrder()
        };

        foreach (var order in orders)
        {
            order.Process();
            order.Validate();
            order.SendEmail();
        }
    }
}