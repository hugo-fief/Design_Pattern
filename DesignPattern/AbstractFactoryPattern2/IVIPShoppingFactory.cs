namespace DesignPattern
{
    public interface IPrioriteCommande
    {
        int Priorite { get; }
    }
    public interface IPourcentReduction
    {
        decimal Pourcentage { get; }
    }

    public class StandardPrioriteCommande : IPrioriteCommande
    {
        public int Priorite => 0;
    }
    public class VIPPrioriteCommande : IPrioriteCommande
    {
        public int Priorite => 1;
    }
    public class StandardPourcentReduction : IPourcentReduction
    {
        public decimal Pourcentage => 0m;
    }
    public class VIPPourcentReduction : IPourcentReduction
    {
        public decimal Pourcentage => 15m;
    }

    public interface IVIPShoppingFactory
    {
        IPrioriteCommande GetPriorite();
        IPourcentReduction GetReduction();
    }

    public class VIPShoppingFactory : IVIPShoppingFactory
    {
        public IPrioriteCommande GetPriorite() => new VIPPrioriteCommande();

        public IPourcentReduction GetReduction() => new VIPPourcentReduction();
    }
    public class StandardShoppingFactory : IVIPShoppingFactory
    {
        public IPrioriteCommande GetPriorite() => new StandardPrioriteCommande();

        public IPourcentReduction GetReduction() => new StandardPourcentReduction();
    }
}
