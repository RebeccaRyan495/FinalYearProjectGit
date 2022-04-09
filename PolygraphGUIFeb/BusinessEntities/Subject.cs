using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Subject: ISubject
    {
        #region Instance Properties

        private string subjectID;
        private string subjectFirstName;
        private string subjectLastName;
        private int incarceration;
        private int previousTests;
        private string subjectAddress;
        private string custodianName;

        
        #endregion

        public string SubjectID
        {
            get
            {
                return subjectID;
            }
            set
            {
                subjectID = value;
            }
        }

        public string SubjectFirstName
        {
            get
            {
                return subjectFirstName;
            }
            set
            {
                subjectFirstName = value;
            }
        }

        public string SubjectLastName
        {
            get
            {
                return subjectLastName;
            }
            set
            {
                subjectLastName = value;
            }
        }

        public int Incarceration
        {
            get
            {
                return incarceration;
            }
            set
            {
                incarceration = value;
            }
        }

        public int PreviousTests
        {
            get
            {
                return previousTests;
            }
            set
            {
                previousTests = value;
            }
        }

        public string SubjectAddress
        {
            get
            {
                return subjectAddress;
            }
            set
            {
                subjectAddress = value;
            }
        }

        public string CustodianName
        {
            get
            {
                return custodianName;
            }
            set
            {
                custodianName = value;
            }
        }
        public Subject(string subjectID, string subjectFirstName, string subjectLastName, int incarceration, int previousTests, string subjectAddress, string custodianName)
        {
            this.subjectID = subjectID;
            this.subjectFirstName = subjectFirstName;
            this.subjectLastName = subjectLastName;
            this.incarceration = incarceration;
            this.previousTests = previousTests;
            this.subjectAddress = subjectAddress;
            this.custodianName = custodianName;
        }
    }
}
