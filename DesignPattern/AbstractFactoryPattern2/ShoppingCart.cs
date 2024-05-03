namespace DesignPattern
{
    public class Customer
    {
        public int[] Orders { get; set; } = Array.Empty<int>(); 
    }
    public class ShoppingCart
    {
        private readonly IVIPShoppingFactory _factory;

        public ShoppingCart(IVIPShoppingFactory factory)
        {
            _factory = factory;
        }

        public void PasserCommande()
        {
            int priorite = _factory.GetPriorite().Priorite;
            decimal pourcent = _factory.GetReduction().Pourcentage;

            Console.WriteLine($"Priorite : {priorite} / Pourcentage : {pourcent}");
        }
    }
}
