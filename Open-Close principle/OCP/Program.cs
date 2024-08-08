using OCP.Example_One;
using OCP.Example_Three;
using OCP.Example_Two;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoice Amount: 10000");
            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoive : {FInvoiceAmount}");
            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoive : {PInvoiceAmount}");
            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoive : {RInvoiceAmount}");

            Console.WriteLine("-----------------------------------------");

            var pdfGenerator = new PDFReportGenerator();
            var service = new ReportGenerationService(pdfGenerator);
            service.GenerateReport("PDF Report Data");
            var csvGenerator = new CSVReportGenerator();
            service = new ReportGenerationService(csvGenerator);
            service.GenerateReport("CSV Report Data");

            Console.WriteLine("----------------------------");
            var products = new List<Product>
            {
                new Product { Name = "Red Shirt", Color = "Red", Size = 10 },
                new Product { Name = "Blue Pants", Color = "Blue", Size = 20 },
                // ... other products
            };
            var filter = new ProductFilter();
            foreach (var product in filter.Filter(products, new ColorSpecification("Red")))
            {
                Console.WriteLine($"- {product.Name}");
            }
            Console.ReadKey();
        }
    }
}
