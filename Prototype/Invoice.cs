

using Prototype;

namespace PrototypeP;

public class Invoice  : IPrototype<Invoice>
{
    public string Customer { get; set; }
    public string Header { get; set; }
    public string Footer { get; set; }
    public decimal TaxRate { get; set; }
    public decimal Total
    {
        get => Items.Sum(i => i.Price * (1 + TaxRate));
    }
    public DateTime Date { get; set; }
    public string Number { get; set; }
    public List<InvoiceItem> Items { get; set; } = new();

    public Invoice Clone()
    {
        return new Invoice
        {
            Header= this.Header,
            Footer = this.Footer,
            TaxRate = this.TaxRate,
            Date = this.Date,
            Number = this.Number,
            Items= Items.Select(i => new InvoiceItem
            {
                Description = i.Description,
                Price = i.Price
            }).ToList(),
        };
    }
}
