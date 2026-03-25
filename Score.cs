class Score
    {
        private int currentScore;
        private int correctAnswers;
        private int wrongAnswers;

        public int CurrentScore
        {
            get { return currentScore; }
            set { currentScore = value; }
        }

        public int CorrectAnswers
        {
            get { return correctAnswers; }
            set { correctAnswers = value; }
        }

        public int WrongAnswers
        {
            get { return wrongAnswers; }
            set { wrongAnswers = value; }
        }

        public Score(int score, int correct, int wrong)
        {
            currentScore = score;
            correctAnswers = correct;
            wrongAnswers = wrong;
        }

        public void IncrementCorrect()
        {
            correctAnswers++;
        }

        public void IncrementWrong()
        {
            wrongAnswers++;
        }
    }
