using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chestionar.controller
{
    class QuizController
    {
        public repository.QuestionRepository QuestionRepository { get; set; }
        public model.Quiz Quiz { get; set; }

        public QuizController()
        {
            QuestionRepository = new repository.QuestionRepository();
            Quiz = new model.Quiz();
            List<model.Question> QuestionList = QuestionRepository.QuestionList;
            HashSet<int> QuestionsNumbers = new HashSet<int>();
            int questionNumber = QuestionList.Count();

            while (QuestionsNumbers.Count() < 26)
            {
                Random random = new Random();

                int number = random.Next(0, questionNumber - 1);

                if (QuestionsNumbers.Contains(number))
                    continue;

                
                Quiz.Questions.Add(QuestionList[number]);
                QuestionsNumbers.Add(number);
            }
        }

        private void DeleteWS(List<string> list)
        {
            for (int i = list.Count() - 1; i >= 0; --i)
                if (list[i] == "")
                    list.RemoveAt(i);
        }

        public bool CheckAnswer(int questionID, List < string > answerList)
        {
            DeleteWS(answerList);
            DeleteWS(Quiz.Questions[questionID].Corecte);

            if (Quiz.Questions[questionID].Corecte.Count() != answerList.Count())
                return false;

            for (int i = 0; i < answerList.Count(); ++i)
                if (Quiz.Questions[questionID].Corecte[i] != answerList[i])
                    return false;

            return true;
        }
    }
}
