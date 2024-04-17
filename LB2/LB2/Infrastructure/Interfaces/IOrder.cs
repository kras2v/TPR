namespace LB2.Infrastructure.Interfaces;

internal interface IOrder
{
    public void Process();
    public void Validate();
    public void SendEmail();
}