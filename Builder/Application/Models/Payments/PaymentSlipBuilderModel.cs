namespace Builder.Application.Models.Payments;

public class PaymentSlipBuilderModel
{
    private PaymentSlipModel _paymentSlipModel;

    public PaymentSlipBuilderModel()
    {
    }

    public PaymentSlipBuilderModel Start()
    {
        _paymentSlipModel = new PaymentSlipModel();

        return this;
    }

    public PaymentSlipBuilderModel WithReceiver(Receiver receiver)
    {
        _paymentSlipModel.Receiver = receiver;

        return this;
    }

    public PaymentSlipBuilderModel WithPayer(Payer payer)
    {
        _paymentSlipModel.Payer = payer;

        return this;
    }

    public PaymentSlipBuilderModel WithPaymentDocument(string barCode, string ourNumber, decimal documentAmount)
    {
        _paymentSlipModel.BarCode = barCode;
        _paymentSlipModel.OurNumber = ourNumber;
        _paymentSlipModel.DocumentAmount = documentAmount;

        return this;
    }

    public PaymentSlipBuilderModel WithDates(DateTime processedAt, DateTime expiresAt)
    {
        _paymentSlipModel.ProcessedAt = processedAt;
        _paymentSlipModel.ExpiresAt = expiresAt;

        return this;
    }

    public PaymentSlipModel Build()
    {
        return _paymentSlipModel;
    }
}