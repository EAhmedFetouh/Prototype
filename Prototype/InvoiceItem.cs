

using Prototype;

namespace PrototypeP;

public class InvoiceItem  : IPrototype<InvoiceItem>
{
    public string Description { get; set; }
    public decimal Price { get; set; }

    public InvoiceItem Clone()
    {
       return new InvoiceItem
       {
           Description = this.Description,
           Price = this.Price
       };
    }
}
