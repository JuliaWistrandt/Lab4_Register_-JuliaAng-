using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class EmployeeAgreement : Document
    {
        
        public DateTime dateExpired;
        public string employeeName;

        

        public EmployeeAgreement(uint id, DateTime dateSigned, DateTime dateExpired, string employeeName)
        { 
            this.id = id;
            this.dateSigned = dateSigned;
            this.dateExpired = dateExpired;
            this.employeeName = employeeName;
        }


        public override string GetDetailedInfo()
        {
            var printDoc = new StringBuilder();
            printDoc.AppendLine($"Details of the Employee Agreement # {id}: ");
            printDoc.AppendLine("__________________________________________ ");
            printDoc.AppendLine($"Id: {id}");
            printDoc.AppendLine($"Signed date: {dateSigned}");
            printDoc.AppendLine($"Expeired date: {dateExpired}");
            printDoc.AppendLine($"Employee name: {employeeName}\n");
            return printDoc.ToString();
        }

    }
}
