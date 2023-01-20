using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    internal class Register
    {
        private const int maxLength = 10;
        

        List<Document> docList = new List<Document>();

        public void AddADocument(Document doc)
        {
            if (docList.Count == maxLength)
            {
                throw new DataBaseException(message: "Oops, looks like we are running out of memory space.\nPlease delete some documents from Register or try again later");
            }
            else
            {
                docList.Add(doc);
                Console.WriteLine($"the document was succesfully added\n");      
            }

        }
            


        public string FindDoc(uint findId)
        {

            List<Document> results = docList.FindAll(item => item.id == findId);
            StringBuilder sb = new StringBuilder();
            foreach (var document in results)
            {
                sb.AppendLine(document.GetDetailedInfo());
            }
            return sb.ToString();


        }


        public string FindDoc(DateTime findDate)
        {
            List<Document> temp = docList.FindAll(item => item.dateSigned == findDate);
            StringBuilder sb = new StringBuilder();
            foreach (var document in temp)
            {
                sb.AppendLine(document.GetDetailedInfo());
            }
            return sb.ToString();

        }

    }
}
                

            
