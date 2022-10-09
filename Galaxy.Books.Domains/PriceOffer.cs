namespace Galaxy.Books.Domains
{
#nullable disable
    public class PriceOffer
    {
        public const int PromotionalTextLength = 200;

        public Guid PriceOfferId { get; set; }
        public decimal NewPrice { get; set; }
        public string PromotionalText { get; set; }

        //-----------------------------------------------
        //Relationships

        public Guid BookId { get; set; }
    }
}
