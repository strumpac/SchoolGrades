﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using SchoolGrades.DbClasses;

namespace SchoolGrades
{
    internal partial class BusinessLayer
    {
        internal List<Answer> GetAnswersOfAQuestion(int? idQuestion)
        {
            return dl.GetAnswersOfAQuestion(idQuestion);
        }
        internal object GetWeightedAveragesOfClass(Class currentClass, string idGradeType, string idSchoolSubject, DateTime value1, DateTime value2)
        {
            return dl.GetWeightedAveragesOfClass(currentClass, idGradeType, idSchoolSubject, value1, value2);
        }
        internal void RestoreTableXml(string Value, bool IsChecked)
        {
            dl.RestoreTableXml(Value, IsChecked);
        }
        internal void BackupAllStudentsDataXml()
        {
            dl.BackupAllStudentsDataXml();
        }
        internal void RestoreAllStudentsDataXml(bool IdChecked)
        {
            dl.RestoreAllStudentsDataXml(IdChecked);
        }
        internal List<Answer> GetAllCorrectAnswersToThisQuestionOfThisTest(int? idQuestion, int? idTest)
        {
            return dl.GetAllCorrectAnswersToThisQuestionOfThisTest(idQuestion, idTest);
        }
        internal void AddAnswerToQuestion(int? idQuestion, int? idAnswer)
        {
            dl.AddAnswerToQuestion(idQuestion, idAnswer);
        }
    }
}