using Magicalizer.Filters.Abstractions;

namespace App.Filters
{
  public class CategoryFilter : IFilter
  {
    public IntegerFilter Id { get; set; }
    public StringFilter Name { get; set; }

    [FilterShortcut("Products[]")]
    public ProductFilter Product { get; set; }

    public CategoryFilter() { }

    public CategoryFilter(IntegerFilter id = null, StringFilter name = null)
    {
      this.Id = id;
      this.Name = name;
    }
  }
}