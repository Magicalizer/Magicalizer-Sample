using Magicalizer.Filters.Abstractions;

namespace App.Filters
{
  public class ProductFilter : IFilter
  {
    public IntegerFilter Id { get; set; }
    public CategoryFilter Category { get; set; }
    public StringFilter Name { get; set; }
    public DecimalFilter Price { get; set; }
    public DateTimeFilter Created { get; set; }

    public ProductFilter() { }

    public ProductFilter(IntegerFilter id = null, CategoryFilter category = null, StringFilter name = null, DecimalFilter price = null, DateTimeFilter created = null)
    {
      this.Id = id;
      this.Category = category;
      this.Name = name;
      this.Price = price;
      this.Created = created;
    }
  }
}