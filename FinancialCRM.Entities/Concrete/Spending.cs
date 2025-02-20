namespace FinancialCRM.Entities.Concrete
{
    public class Spending : BaseEntity
    {
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
