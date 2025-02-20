namespace FinancialCRM.Entities.Concrete
{
    public class Bill : BaseEntity
    {
        public string Title { get; set; }
        public string Period { get; set; }
        public decimal Amount { get; set; }

    }
}
