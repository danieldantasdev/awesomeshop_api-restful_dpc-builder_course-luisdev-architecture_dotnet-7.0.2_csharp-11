using Builder.Application.Models.Orders;

namespace Builder.Core.Services.Interfaces;

public interface IPaymentService
{
    object Process(OrderModel model);
}