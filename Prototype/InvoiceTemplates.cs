

using PrototypeP;

namespace Prototype
{
    public  static class InvoiceTemplates
    {
        private static string DefaultHeader = "Company\nCairo - Egypt";
        private static string DefaultFooter = "Payment within 15 days\nThank you for your business";
        private static decimal DefaultTaxRate = 0.15m;


        public static Invoice Subscription => new Invoice
        {
            Header = DefaultHeader,
            Footer = DefaultFooter,
            TaxRate = DefaultTaxRate,
            Items= new List<InvoiceItem>()
            {
                new InvoiceItem{
                    Description = "Monthly Subscription",
                    Price = 1000
                }
            }
        };


        public static Invoice Hosting => new Invoice
        {
            Header = DefaultHeader,
            Footer = DefaultFooter,
            TaxRate = DefaultTaxRate,
            Items = new List<InvoiceItem>()
            {
                new InvoiceItem{
                    Description = "Housting Service",
                    Price = 1500
                }
            }
        };


        public static Invoice Custom => new Invoice
        {
            Header = DefaultHeader,
            Footer = DefaultFooter,
            TaxRate = DefaultTaxRate,
            Items = new List<InvoiceItem>()
            {
                new InvoiceItem{
                    Description = "Custom Development",
                    Price = 2000
                }
            }
        };


        public static Invoice Bundle => new Invoice
        {
            Header = DefaultHeader,
            Footer = DefaultFooter,
            TaxRate = DefaultTaxRate,
            Items = new List<InvoiceItem>()
            {
                new InvoiceItem{
                    Description = "Monthly Subscription",
                    Price = 1000
                },
                new InvoiceItem{
                    Description = "Custom Development",
                    Price = 2000
                },
               new InvoiceItem{
                    Description = "Housting Service",
                    Price = 1500
                }
            }
        };
    }
}
