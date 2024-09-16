namespace BasketballApi1.Models
    {
        public class Team
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
            public string City { get; set; } = "";
            public List<Players> Players { get; set; }
            public List<Game> Games { get; set; }
        }
    }

