using System;

class Question
    {
        private string questionText;
        private string correctAnswer;
        private string[] options;

        public string QuestionText
        {
            get { return questionText; }
            set { questionText = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public string[] Options
        {
            get { return options; }
            set { options = value; }
        }

        public Question(string text, string answer, string[] options)
        {
            questionText = text;
            correctAnswer = answer;
            this.options = options;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(questionText);
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
        }

        public bool CheckAnswer(string answer)
        {
            return answer == correctAnswer;
        }
    }
