namespace Galaxy.Books.Domains
{
#nullable disable
    public class Review
    {
        public const int NameLength = 100;

        public Guid ReviewId { get; set; }

        public string VoterName { get; set; }

        public int NumStars { get; set; }
        public string Comment { get; set; }

        //-----------------------------------------
        //Relationships

        public Guid BookId { get; set; } 
    }
}
