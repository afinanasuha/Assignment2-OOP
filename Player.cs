class Player
    {
        private string playerID;
        private string name;
        private int lives;
        private Score score;

        public string PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Lives
        {
            get { return lives; }
            set
            {
                if (value >= 0)
                    lives = value;
            }
        }

        public Score Score
        {
            get { return score; }
            set { score = value; }
        }

        public Player(string id, string name, int lives, Score score)
        {
            this.playerID = id;
            this.name = name;
            this.lives = lives;
            this.score = score;
        }

        public void UpdateScore(int points)
        {
            score.CurrentScore += points;
        }

        public void LoseLife()
        {
            if (lives > 0)
                lives--;
        }
    }
