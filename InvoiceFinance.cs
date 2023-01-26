using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class InvoiceFinance : Document
    {
        public int totalSumMonth;
        public string codeDepartment;

       

        public InvoiceFinance(int totalSumMonth, uint id, DateTime dateSigned, string codeDepartment)
        { 
            this.totalSumMonth = totalSumMonth;
            this.id = id;
            this.dateSigned = dateSigned;
            this.codeDepartment = codeDepartment;
        }


        public override string GetDetailedInfo()
        {
            var printDoc = new StringBuilder();
            printDoc.AppendLine($"Details of the Invoice Finance # {id}: ");
            printDoc.AppendLine("__________________________________________ ");
            printDoc.AppendLine($"Total sum month: {totalSumMonth}");
            printDoc.AppendLine($"Id: {id}");
            printDoc.AppendLine($"Signed date: {dateSigned}");
            printDoc.AppendLine($"Department code: {codeDepartment}\n");
            return printDoc.ToString();
        }
    }
}
