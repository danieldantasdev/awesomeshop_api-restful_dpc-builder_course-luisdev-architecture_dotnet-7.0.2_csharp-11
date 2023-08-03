using Builder.Core.Enums;

namespace Builder.Core.Services.Interfaces;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}