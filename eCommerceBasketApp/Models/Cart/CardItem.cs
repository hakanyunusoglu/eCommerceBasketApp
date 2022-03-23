namespace eCommerceBasketApp.Models.Cart
{
    public class CardItem
    {
        public int ID { get; set; }

        public Product Product { get; set; }
        public int ProductID { get; set; }
        public Card Card { get; set; }
        public int CardID { get; set; }
        public int Quantity { get; set; }
    }
}
