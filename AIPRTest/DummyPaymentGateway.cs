public class DummyPaymentGateway : IPaymentGateway
{
    private const string SuccessLog = $"SOLID: Payment successful.";

    public bool ProcessPayment(string customerId, decimal amount)
    {
        Console.WriteLine($"SOLID: Attempting payment of {amount:C} for customer {customerId}.");
        // Simulate payment success
        Console.WriteLine($"SOLID: Payment successful.");
        return true;
    }
}
