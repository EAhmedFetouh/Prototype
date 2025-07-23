
using PrototypeP.GoodCode;
using PrototypeP;
using Prototype;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var customers = new List<Customer>
{
    new Customer { Name = "Client A", Type = "Subscription" },
    new Customer { Name = "Client B", Type = "Custom" },
    new Customer { Name = "Client C", Type = "Hosting" },
    new Customer { Name = "Client D", Type = "Bundle" }
};

var invoices = new List<Invoice>();
int counter = 1;

foreach (var customer in customers)
{
    Invoice template = customer.Type switch
    {
        "Subscription" => InvoiceTemplates.Subscription,
        "Custom" => InvoiceTemplates.Custom,
        "Hosting" => InvoiceTemplates.Hosting,
        "Bundle" => InvoiceTemplates.Bundle,
        _ => null
    };

    var invoice = template.Clone();
    invoice.Customer = customer.Name;
    invoice.Number = $"INV-{counter:000}";
    invoice.Date = DateTime.Today;

    invoices.Add(invoice);
    counter++;
}

Console.WriteLine("\n✅ Monthly Invoices (Generated with Prototype):");
foreach (var inv in invoices)
{
    Console.WriteLine("==========================================");
    Console.WriteLine(inv.Header);
    Console.WriteLine("------------------------------------------");

    Console.WriteLine($"🔹 Invoice:  {inv.Number}");
    Console.WriteLine($"   Customer: {inv.Customer}");
    Console.WriteLine($"   Date:     {inv.Date:yyyy-MM-dd}");

    Console.WriteLine("   Items:");
    foreach (var item in inv.Items)
        Console.WriteLine($"     - {item.Description,-20} {item.Price,10:N2} EGP");

    Console.WriteLine("------------------------------------------");
    Console.WriteLine($"   Tax Rate:    {inv.TaxRate:P0}");
    Console.WriteLine($"   Total:       {inv.Total,10:N2} EGP");
    Console.WriteLine("------------------------------------------");

    Console.WriteLine(inv.Footer);
    Console.WriteLine("==========================================");
    Console.WriteLine("\n🔽🔽🔽🔽🔽🔽🔽🔽🔽🔽 NEXT INVOICE 🔽🔽🔽🔽🔽🔽🔽🔽🔽🔽\n");
}

Console.WriteLine(new string('-', 40));

