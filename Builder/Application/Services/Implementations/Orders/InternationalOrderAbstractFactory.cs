using Builder.Application.Services.Implementations.Payments;
using Builder.Core.Enums;
using Builder.Core.Services.Interfaces;

namespace Builder.Application.Services.Implementations.Orders;

public class InternationalOrderAbstractFactory : IOrderAbstractFactory
{
    private readonly PaymentCreditCardService _paymentCreditCardService;
    private readonly InternationalOrderService _internationalOrderService;

    public InternationalOrderAbstractFactory(PaymentCreditCardService paymentCreditCardService,
        InternationalOrderService internationalOrderService)
    {
        _paymentCreditCardService = paymentCreditCardService;
        _internationalOrderService = internationalOrderService;
    }

    public IPaymentService GetPaymentService(PaymentMethod paymentMethod)
    {
        return _paymentCreditCardService;
    }

    public IOrderService GetDeliveryService()
    {
        return _internationalOrderService;
    }
}