using System.Runtime.Intrinsics.Arm;

namespace Register
{
    internal class Program
    {
        public delegate void CarShopStateHandler(string message);
        static void Main(string[] args)
        {
            
            Register areg = new Register();

            areg.AddADocument(new InvoiceFinance(653, 1, DateTime.Today, "sales_025"));
            areg.AddADocument(new InvoiceFinance(432, 2, DateTime.Today, "marketing"));
            areg.AddADocument(new InvoiceFinance(765, 3, DateTime.Today, "leasing"));

            areg.AddADocument(new EmployeeAgreement(4, new DateTime(2008, 3, 1, 7, 0, 0), new DateTime(2023, 3, 1, 7, 0, 0), "John Smith"));
            areg.AddADocument(new EmployeeAgreement(5, new DateTime(2008, 1, 1, 7, 0, 0), new DateTime(2023, 3, 1, 7, 0, 0), "Maria Apollo"));
            areg.AddADocument(new EmployeeAgreement(6, new DateTime(2008, 3, 1, 7, 0, 0), new DateTime(2023, 3, 1, 7, 0, 0), "Emil Johansson"));

            areg.AddADocument(new ASupplyAgreement(7, "Ships", "25", new DateTime(2023, 3, 1, 7, 0, 0)));
            areg.AddADocument(new ASupplyAgreement(8, "Cars", "25", new DateTime(2023, 3, 1, 7, 0, 0)));
            areg.AddADocument(new ASupplyAgreement(9, "Boats", "25", new DateTime(2023, 3, 1, 7, 0, 0)));

            areg.AddADocument(new ASupplyAgreement(10, "Candy", "25", new DateTime(2023, 3, 1, 7, 0, 0)));

            //areg.AddADocument(new ASupplyAgreement(11, "Mondays", "30", new DateTime(2023, 3, 1, 7, 0, 0)));
            //areg.AddADocument(new ASupplyAgreement(006, "Sundays", "14", new DateTime(2023, 3, 1, 7, 0, 0)));

            
            // Console.WriteLine(areg.FindDoc(DateTime.Today));

            Console.WriteLine(areg.FindDoc(4));
            Console.WriteLine(areg.FindDoc(11));

          



        }
       

    }
}