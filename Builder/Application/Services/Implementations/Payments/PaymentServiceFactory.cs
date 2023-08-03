using Builder.Core.Enums;
using Builder.Core.Services.Interfaces;

namespace Builder.Application.Services.Implementations.Payments;

public class PaymentServiceFactory : IPaymentServiceFactory
{
    private readonly PaymentCreditCardService _paymentCreditCardService;
    private readonly PaymentSlipService _paymentSlipService;

    public PaymentServiceFactory(
        PaymentCreditCardService paymentCreditCardService,
        PaymentSlipService paymentSlipService
    )
    {
        _paymentCreditCardService = paymentCreditCardService;
        _paymentSlipService = paymentSlipService;
    }

    public IPaymentService GetService(PaymentMethod paymentMethod)
    {
        IPaymentService paymentService;

        switch (paymentMethod)
        {
            case PaymentMethod.CreditCard:
                paymentService = _paymentCreditCardService;

                break;
            case PaymentMethod.PaymentSlip:
                paymentService = _paymentSlipService;

                break;
            default:
                throw new InvalidOperationException();
        }

        return paymentService;
    }
}