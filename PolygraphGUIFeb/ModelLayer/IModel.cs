﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace ModelLayer
{
    public interface IModel
    {
        DataAccess.IDataLayer DataLayer { get; set; }

        List<IAdmin> AdminList { get; set; }
        void GetAllAdmin();
        bool login(string username, string password);
        List<ISubject> SubjectList { get; set; }
        List<IQuestion> QuestionList { get; set; }

        void GetAllSubjects();
        void GetAllQuestions();

        Boolean addSubject(string SubjectFName, string SubjectLName, int Incarceration, int PreviousTests, string SubjectAddress, string CustodianName);
        Boolean addQuestion(string Question);
    }
}
