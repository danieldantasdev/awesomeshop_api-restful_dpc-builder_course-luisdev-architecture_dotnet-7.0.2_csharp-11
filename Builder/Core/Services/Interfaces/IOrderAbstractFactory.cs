using Builder.Core.Enums;

namespace Builder.Core.Services.Interfaces;

public interface IOrderAbstractFactory
{
    IPaymentService GetPaymentService(PaymentMethod paymentMethod);
    IOrderService GetDeliveryService();
}