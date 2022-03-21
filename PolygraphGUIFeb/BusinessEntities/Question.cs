using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Question: IQuestion
    {
        #region Instance Properties

        private string questionID;
        private string question;
        #endregion

        public string QuestionID
        {
            get
            {
                return questionID;
            }
            set
            {
                questionID = value;
            }
        }

        public string AQuestion
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
            }
        }
    }
}
