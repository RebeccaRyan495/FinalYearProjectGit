using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public static class SubjectMethods
    {
        private static ISubject subject = null;

        public static ISubject GetSubject(string SubjectID, string SubjectFirstName, string SubjectLastName, int Incarceration, int PreviousTests, string SubjectAddress, string CustodianName)
        {
            if (subject != null)  
                return subject;
            else
                return new Subject(SubjectID, SubjectFirstName, SubjectLastName, Incarceration, PreviousTests, SubjectAddress, CustodianName);
        }
        public static void SetUser(ISubject aSubject)   
        {
            subject = aSubject;
        }
    }
}
