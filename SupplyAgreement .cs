using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Register
{
    internal class ASupplyAgreement : Document
    {
        public uint id;
        public string typeOfGoods;
        public string ammountOfGoods;
        public DateTime dateSigned;

        

        public ASupplyAgreement(uint id, string typeOfGoods, string ammountOfGoods, DateTime dateTime)
        { 
            this.id = id;
            this.typeOfGoods = typeOfGoods;
            this.ammountOfGoods= ammountOfGoods;
            this.dateSigned = dateTime;

        }

        public override string GetDetailedInfo()
        {
            var printDoc = new StringBuilder();
            printDoc.AppendLine($"Details of the Supply Agreement # {id}: ");
            printDoc.AppendLine("__________________________________________ ");
            printDoc.AppendLine($"Id: {id}");
            printDoc.AppendLine($"Type of goods: {typeOfGoods}");
            printDoc.AppendLine($"Ammount of goods: {ammountOfGoods}");
            printDoc.AppendLine($"Signed date: {dateSigned}\n");
            return printDoc.ToString();
        }

    }
}
