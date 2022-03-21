using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public class Test: ITest
    {
        #region Instance Properties

        private string testID;
        private string testDuration;
        private int criminal;

        #endregion

        public string TestID
        {
            get
            {
                return testID;
            }
            set
            {
                testID = value;
            }
        }

        public string TestDuration
        {
            get
            {
                return testDuration;
            }
            set
            {
                testDuration = value;
            }
        }

        public int Criminal
        {
            get
            {
                return criminal;
            }
            set
            {
                criminal = value;
            }
        }
    }
}
