namespace Builder.Application.Models.Payments;

public class PaymentFraudCheckModel
{
    public PaymentFraudCheckModel(decimal totalAmount, Guid customerId, string customerName, string document)
    {
        TotalAmount = totalAmount;
        CustomerId = customerId;
        CustomerName = customerName;
        Document = document;
    }

    public decimal TotalAmount { get; private set; }
    public Guid CustomerId { get; private set; }
    public string CustomerName { get; private set; }
    public string Document { get; private set; }
}