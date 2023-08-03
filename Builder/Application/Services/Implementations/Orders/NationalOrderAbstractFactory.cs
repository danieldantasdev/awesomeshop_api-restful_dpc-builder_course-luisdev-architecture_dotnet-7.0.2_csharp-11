using Builder.Core.Enums;
using Builder.Core.Services.Interfaces;

namespace Builder.Application.Services.Implementations.Orders;

public class NationalOrderAbstractFactory : IOrderAbstractFactory
{
    private readonly NationalOrderService _nationalOrderService;
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public NationalOrderAbstractFactory(NationalOrderService nationalOrderService,
        IPaymentServiceFactory paymentServiceFactory)
    {
        _nationalOrderService = nationalOrderService;
        _paymentServiceFactory = paymentServiceFactory;
    }

    public IPaymentService GetPaymentService(PaymentMethod paymentMethod)
    {
        return _paymentServiceFactory.GetService(paymentMethod);
    }

    public IOrderService GetDeliveryService()
    {
        return _nationalOrderService;
    }
}