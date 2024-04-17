using System;

// Клас, що представляє обробку замовлення
class OrderProcessor
{
    public void ProcessOrder(string orderType)
    {
        if (orderType == "electronic")
        {
            Console.WriteLine("Processing electronic order...");
        }
        else if (orderType == "book")
        {
            Console.WriteLine("Processing book order...");
        }
        else
        {
            Console.WriteLine("Invalid order type!");
        }
    }

    public void ValidateOrder(string orderType)
    {
        if (orderType == "electronic")
        {
            Console.WriteLine("Electronic order validated.");
        }
        else if (orderType == "book")
        {
            Console.WriteLine("Book order validated.");
        }
        else
        {
            Console.WriteLine("Invalid order type!");
        }
    }

    public void SendConfirmationEmail(string orderType)
    {
        if (orderType == "electronic")
        {
            Console.WriteLine("Confirmation email sent for electronic order.");
        }
        else if (orderType == "book")
        {
            Console.WriteLine("Confirmation email sent for book order.");
        }
        else
        {
            Console.WriteLine("Invalid order type!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        OrderProcessor orderProcessor = new OrderProcessor();

        // Обробка замовлень
        orderProcessor.ProcessOrder("electronic");
        orderProcessor.ProcessOrder("book");
        orderProcessor.ProcessOrder("clothes");

        // Валідація замовлень
        orderProcessor.ValidateOrder("electronic");
        orderProcessor.ValidateOrder("book");
        orderProcessor.ValidateOrder("clothes");

        // Надсилання підтверджень по електронній пошті
        orderProcessor.SendConfirmationEmail("electronic");
        orderProcessor.SendConfirmationEmail("book");
        orderProcessor.SendConfirmationEmail("clothes");
    }
}