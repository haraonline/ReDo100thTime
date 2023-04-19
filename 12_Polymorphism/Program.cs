namespace _12_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiverseCollections dc = new DiverseCollections();
            DiverseCollections.IterateOver(dc.arrNumbers);
            DiverseCollections.IterateOver(dc.arrSnacks);
            DiverseCollections.IterateOver(dc.listDrinks);
            DiverseCollections.IterateOver(dc.listEvens);
        }
    }
}