using FinancialCRM.Entities.Enums;

namespace FinancialCRM.Entities.Concrete
{
    public class BankProcess : BaseEntity
    {
        public int BankId { get; set; }
        public string Description { get; set; }
        public DateTime ProcessDate { get; set; }
        public ProcessType ProcessType { get; set; }
        public decimal Amount { get; set; }
        public virtual Bank Bank { get; set; }

        public override string ToString()
        {
            return Description + " " + Amount + " " + ProcessDate;
        }
    }
}
