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

        public string AddADocument(Document doc)
        {
            if (docList.Count >= maxLength) return "Oops, looks like we are running out of memory space.\nPlease delete some documents from Register or try again later";
            else
            {
                docList.Add(doc);
                return $"The document was sucesfully added.\nFind the additional information below:\n\n" + doc.GetDetailedInfo();      
            }      

        }
            


        public string FindDoc(uint findId)
        {  
            var temp = docList.FirstOrDefault(item => item.id == findId);

            if (temp != null) return $"Here is the document with id {findId} you were searching for.\nPlease find the additional information below:\n\n" + temp.GetDetailedInfo();
            else return $"Oops, looks like there is no document with the particular Id {findId} in our register";
               
        }


        public string FindDoc(DateTime findDate)
        {
            List<Document> temp = docList.FindAll(item => item.dateSigned == findDate);
            if (temp != null)
            {
                
                StringBuilder sb = new StringBuilder();
                foreach (var document in temp)
                {
                   
                    sb.AppendLine(document.GetDetailedInfo());
                }
                return $"Here is the list of all documents were added at {findDate}:\n\n" + sb.ToString();

            }
            else return $"Opps, looks like there is no document were added to Register at {findDate}";

        }

    }
}
                

            
