namespace DevFreela.Payments.API.Controllers
{
    public class PaymentInfoInputModel
    {
        public int IdProject { get; set; }
        public string CreditCardNumber { get; set; }
        public string Cvv { get; set; }
        public string ExpiresAy { get; set; }
        public string FullName { get; set; }
        public decimal Amount { get; set; }
    }
}