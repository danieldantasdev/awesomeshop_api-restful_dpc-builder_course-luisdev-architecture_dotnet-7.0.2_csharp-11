using Builder.Application.Models.Orders;
using Builder.Application.Models.Payments;
using Builder.Core.Services.Interfaces;

namespace Builder.Application.Services.Implementations.Payments;

public class PaymentSlipService : IPaymentService
{
    public object Process(OrderModel model)
    {
        // Recebe os dados de Boleto de uma API Externa, por exemplo

        var paymentSlip = new PaymentSlipModel(
            "12312.23214521-1.232152131", "12324124", DateTime.Now, DateTime.Now.AddDays(3), 1234.0m,
            new Payer("Pagador", "123.567.899-10", "Rua do Pagador"),
            new Receiver("Recebedor", "987.654.321-01", "Rua do Recebedor")
        );

        var builder = new PaymentSlipBuilderModel();

        var paymentSlipWithBuilder = builder
            .Start()
            .WithPayer(new Payer("Pagador", "123.567.899-10", "Rua do Pagador"))
            .WithReceiver(new Receiver("Recebedor", "987.654.321-01", "Rua do Recebedor"))
            .WithPaymentDocument("12312.23214521-1.232152131", "12324124", 1234.0m)
            .WithDates(DateTime.Now, DateTime.Now.AddDays(3))
            .Build();

        return "Dados do Boleto";
    }
}