namespace GamesListing.Data
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Rating { get; set; }
        
        public virtual IList<Store> stores { get; set;}
    }
}
