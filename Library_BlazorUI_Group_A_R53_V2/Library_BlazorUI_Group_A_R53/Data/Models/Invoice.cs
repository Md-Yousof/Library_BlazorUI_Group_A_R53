namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int? BorrowId { get; set; }
        public BorrowedBook? BorrowedBook { get; set; }
        public string? UserId { get; set; } //for monthly fees

        public ApplicationUser? User { get; set; } //Apatoto eita comment raklam

        //public int? SubId {get; set; } //if subscribed user
        //public SubscriptionPlan? Plan { get; set; }
        public decimal? Payment { get; set; } //all kinds of payment (monthly fees and/or book price)
        public decimal? Refund { get; set; }//non subscribed pay per borrow 70% and minus other fines
        public DateTime? TransactionDate { get; set; } //added at acception also modified at returned
        public decimal? Fine { get; set; }
        public decimal? MiscellaneousFines { get; set; }

        public string? Remarks { get; set; }
        public string TransactionId { get; set; }

        public Invoice()
        {
            TransactionId = GenerateTransactionId();
        }

        private string GenerateTransactionId()
        {
            // You can use a combination of date, time, and a random component
            string datePart = DateTime.Now.ToString("yyyyMMddHHmmss");
            string randomPart = Guid.NewGuid().ToString("N").Substring(0, 6); // Generate a random 6-character string

            return datePart + randomPart;
        }

        public string UserName { get; set; } // Add this property to store the UserName
    }
}