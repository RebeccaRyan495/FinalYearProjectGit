using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class QuestionMethods
    {
        private static IQuestion question = null;

        public static IQuestion GetQuestion(string QuestionID, string Question)
        {
            if (question != null)  // ie is Factory is primed with an object. 
                return question;
            else
                return new Question(QuestionID, Question);
        }
        public static void SetUser(IQuestion aQuestion)   // This provides a seam in the factory where I can prime the factory with the user it will then cough up. (for test code) 
        {
            question = aQuestion;
        }
    }
}
