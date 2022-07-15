﻿namespace GamesListing.Data
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual IList<Game> Games { get; set; }
    }
}