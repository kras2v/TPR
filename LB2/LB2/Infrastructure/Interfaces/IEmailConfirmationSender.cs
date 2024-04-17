namespace LB2.Infrastructure.Interfaces;

internal interface IEmailConfirmationSender
{
    public void SendConfirmationEmail(IOrder order);
}