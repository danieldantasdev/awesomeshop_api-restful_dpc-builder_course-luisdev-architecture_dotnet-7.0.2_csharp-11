using Builder.Application.Models.Orders;
using Builder.Application.Services.Implementations.Orders;
using Builder.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Builder.Controllers;

[ApiController]
[Route("api/orders")]
public class OrdersController : ControllerBase
{
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public OrdersController(IPaymentServiceFactory paymentServiceFactory)
    {
        _paymentServiceFactory = paymentServiceFactory;
    }

    [HttpPost("with-out-abstract-factory")]
    public IActionResult PostWithOutAbstractFactory(OrderModel model)
    {
        if (model.IsInternational != null && model.IsInternational.Value)
        {
        }
        else
        {
        }

        return NoContent();
    }

    [HttpPost("with-abstract-factory")]
    public IActionResult PostWithAbstractFactory(OrderModel model,
        [FromServices] InternationalOrderAbstractFactory internationalOrderAbstractFactory,
        NationalOrderAbstractFactory nationalOrderAbstractFactory)
    {
        IOrderAbstractFactory orderAbstractFactory;
        if (model.IsInternational != null && model.IsInternational.Value)
            orderAbstractFactory = internationalOrderAbstractFactory;
        else
            orderAbstractFactory = nationalOrderAbstractFactory;

        var paymentResult = orderAbstractFactory.GetPaymentService(model.PaymentInfo.PaymentMethod).Process(model);
        orderAbstractFactory.GetDeliveryService().Deliver(model);


        return NoContent();
    }
}