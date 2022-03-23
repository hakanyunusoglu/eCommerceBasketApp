namespace eCommerceBasketApp.Models.Cart
{
    public class Card
    {
        public int ID { get; set; }
        public string UserID { get; set; }

        public List<CardItem> CardItems { get; set; }
    }
}
