using Builder.Application.Models.Orders;
using Builder.Core.Services.Interfaces;

namespace Builder.Application.Services.Implementations.Payments;

public class PaymentCreditCardService : IPaymentService
{
    public object Process(OrderModel model)
    {
        return "Transação aprovada";
    }
}