namespace CSInherit {
    public class Gun {
        

        public readonly int Damage;

        public Gun(int damage, string name, int countOfBullets)
        {
            Damage = damage;
            Name = name;
            CountOfBullets = countOfBullets;
        }

        public string Name;
        public int CountOfBullets { get; set; }

        public void Shoot() {
            CountOfBullets--;
            Console.WriteLine($"Pah Pah!!! {CountOfBullets}");
        }

        public string Recharge() => "Sharah Parah!";
    }

    public class Player {
        
        public string Type;
        public byte Health;
        public int Score;
        public int Cash;
        public string Name;
        public Gun Gun;

        public Player(string type, byte health, int score, int cash, string name, Gun gun)
        {
            Type = type;
            Health = health;
            Score = score;
            Cash = cash;
            Name = name;
            Gun = gun;
        }

        public string MoveFront() => "I'm going to front";
        public string MoveBack()=> "I'm going to back";
        public string MoveLeft()=>"I'm try to left";
        public string MoveRight()=> "I'm try to right";
        public string Jump() => "I'm try to jump";
        public string Seat() => "I'm going to seat";
        public string Rotate(double x, double y, double z) => $"I try to see coordinates ${x} ${y} {z}";
    }
}