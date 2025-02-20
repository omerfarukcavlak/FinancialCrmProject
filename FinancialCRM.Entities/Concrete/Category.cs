namespace FinancialCRM.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public virtual List<Spending> Spendings { get; set; }

    }
}
