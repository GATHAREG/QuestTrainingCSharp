namespace RockPaperScissor
{
    public class User
    {
        public string Name { get;  set; }
        public int UserScore { get; set; }

        public User(string name)
        {
            Name = name;
            UserScore = 0;
        }
    }
}
