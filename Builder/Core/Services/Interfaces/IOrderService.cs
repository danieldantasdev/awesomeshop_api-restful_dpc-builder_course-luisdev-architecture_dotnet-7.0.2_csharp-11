using Builder.Application.Models.Orders;

namespace Builder.Core.Services.Interfaces;

public interface IOrderService
{
    void Deliver(OrderModel orderModel);
}