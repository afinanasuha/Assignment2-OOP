using System;

class Program
    {
        static void Main()
        {
            Score s1 = new Score(0, 0, 0);

            Player p1 = new Player("P001", "Afina", 3, s1);

            string[] options = { "A. 2", "B. 4", "C. 6" };
            Question q1 = new Question("What is 2 + 2?", "B", options);

            q1.DisplayQuestion();

            string answer = "B";

            if (q1.CheckAnswer(answer))
            {
                Console.WriteLine("Correct answer!");
                p1.UpdateScore(10);
                s1.IncrementCorrect();
            }
            else
            {
                Console.WriteLine("Wrong answer!");
                p1.LoseLife();
                s1.IncrementWrong();
            }

            Console.WriteLine("\n--- Player Info ---");
            Console.WriteLine("Name: " + p1.Name);
            Console.WriteLine("Lives: " + p1.Lives);

            Console.WriteLine("\n--- Score Info ---");
            Console.WriteLine("Score: " + s1.CurrentScore);
            Console.WriteLine("Correct: " + s1.CorrectAnswers);
            Console.WriteLine("Wrong: " + s1.WrongAnswers);
        }
    }