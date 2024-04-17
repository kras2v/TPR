using LB2.Infrastructure.Interfaces;

namespace LB2.Infrastructure.Classes;

internal class EmailConfirmationSender : IEmailConfirmationSender
{
    public void SendConfirmationEmail(IOrder order)
    {
        order.SendEmail();
    }
}