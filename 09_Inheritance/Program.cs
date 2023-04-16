namespace _09_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new CatVirtualProperty();
            var dog = new DogVirtualProperty();
            Console.WriteLine(cat.Sound);
            Console.WriteLine(dog.Sound);

        }
    }
}