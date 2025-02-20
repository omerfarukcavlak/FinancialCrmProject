namespace FinancialCRM.Entities.Concrete
{
    public class Bank : BaseEntity
    {
        public string AccountNumber { get; set; }
        public string Title { get; set; }
        public decimal Balance { get; set; }
        public virtual List<BankProcess> BankProcesses { get; set; }
        public virtual List<Bill> Bills { get; set; }


    }
}
