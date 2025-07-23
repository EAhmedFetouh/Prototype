🧬 Prototype Pattern – Design Patterns Series
The Prototype Pattern is a creational design pattern that allows you to clone objects instead of creating them from scratch—especially useful when object creation is costly or repetitive.

📌 What’s in This Example?
In this real-world example, we generate monthly invoices for different clients using template-based cloning.

Instead of manually reinitializing similar objects with shared structure, we:

✔️ Define reusable invoice templates
✔️ Clone them per customer
✔️ Set custom data like name, date, and number

🧪 Why Use Prototype?
Without Prototype, your code might look like:

csharp
Copy
Edit
var invoice = new Invoice {
    Header = "...",
    Footer = "...",
    TaxRate = 0.15m,
    Items = new List<InvoiceItem> {
        new InvoiceItem { Description = "Monthly Subscription", Price = 1000 }
    },
    Customer = "Client A",
    Date = DateTime.Today,
    Number = "INV-001"
};
This leads to:

🔁 Code repetition

❌ High maintenance

⚠️ Risk of inconsistency

With Prototype:

csharp
Copy
Edit
var invoice = InvoiceTemplates.Subscription.Clone();
invoice.Customer = "Client A";
invoice.Number = "INV-001";
invoice.Date = DateTime.Today;
Much cleaner, right?

🔍 Key Concepts
Invoice implements a Clone() method

Shared templates live in InvoiceTemplates

We use pattern matching to select and clone the correct template

Demonstrates both data reuse and flexibility

📁 Project Structure
Invoice.cs – base model with clone method

InvoiceTemplates.cs – static templates

Program.cs – usage with customer list

📺 Watch the Video
👉 https://youtu.be/fXPFiDc3R-s

🔗 More from the Series
💻 Full Source Code on GitHub

📺 Full YouTube Playlist

👥 Facebook Group – Ask & Discuss

💼 Follow on LinkedIn

🔄 Clone objects, not logic. Stay DRY and clean.
— The Prototype Way ✨
